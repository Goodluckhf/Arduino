using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArduinoSerial.Model;
using Newtonsoft.Json;


namespace ArduinoSerial.UI
{
    public class SimDataEventArgs : EventArgs
    {
        public List<Parameter> Data { get; set; }

        public SimDataEventArgs(List<Parameter> data)
        {
            this.Data = data;
        }
    }

    public delegate void SimRecieveEventHandler(object sender, SimDataEventArgs e);

    

    class ArduinoManager
    {
        private const string ARDUINO_PORT = "COM7";
        private SerialPort _arduinoPort;

        public event SimRecieveEventHandler SimDataRecieve;
        private void onSimDataRecieve(List<Parameter> data)
        {
            if (this.SimDataRecieve != null)
            {
                this.SimDataRecieve(this, new SimDataEventArgs(data));
            }
        }

        public ArduinoManager()
        {
            this._arduinoPort = new SerialPort();
            
        }

        public void Open()
        {
            if (!this._arduinoPort.IsOpen)
            {
                this._arduinoPort.DataReceived += _arduinoPort_DataReceived;
                this._arduinoPort.PortName = ARDUINO_PORT;
                this._arduinoPort.Open();
            }
            else
            {
                throw new InvalidOperationException("The serial port is already open!");
            }
        }

        public void Close()
        {
            this._arduinoPort.Close();
        }

        private void _arduinoPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string test = this._arduinoPort.ReadTo("$");
            int len = test.Length;
            var arData = JsonConvert.DeserializeObject<List<Parameter>>(test);
            this.onSimDataRecieve(arData);           
        }
    }
}
