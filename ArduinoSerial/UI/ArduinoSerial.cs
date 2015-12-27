using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArduinoSerial.UI;
using System.Collections;
using ArduinoSerial.Model;

namespace ArduinoSerial.UI
{
    public partial class ArduinoSerial : Form
    {
        private ArduinoManager _aruinoManager;

        public ArduinoSerial()
        {
            InitializeComponent();
            this._aruinoManager = new ArduinoManager();

            var dates = DataProvider.Instance.getLogs();

            this.cmbToDate.Items.AddRange(dates.ToArray());
            this.cmbFromDate.Items.AddRange(dates.ToArray());

            this._aruinoManager.SimDataRecieve += (Object sender, SimDataEventArgs data) =>
            {
                this.BeginInvoke(new Action(() =>
                {
                    this.dataList.Items.Clear();
                    DateTime now = DateTime.Now;
                    this.dateField.Text = now.ToUniversalTime().ToString();
                    var logId = DataProvider.Instance.CreateLog(now);
                    Log newLog = new Log(now);
                    newLog.Id = logId;
                    this.cmbFromDate.Items.Add(newLog);
                    this.cmbToDate.Items.Add(newLog);
                    foreach(var item in data.Data) {
                        item.LogId = logId;
                        this.dataList.Items.Add(new ListViewItem(item.toString().getStringArray()));
                        DataProvider.Instance.CreateParameter(item);
                    }                    
                    
                }));
                
            };
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this._aruinoManager.Open();
            
            
        }


        private void ArduinoSerial_FormClosing(object sender, FormClosingEventArgs e)
        {
            this._aruinoManager.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ArduinoSerial_Load(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this._aruinoManager.Close();
        }

        private void btnShowLog_Click(object sender, EventArgs e)
        {
            var fromId = ((Log)this.cmbFromDate.SelectedItem).Id;
            var toId = ((Log)this.cmbToDate.SelectedItem).Id;
            List<Parameter> paramList;
            if(fromId > toId) {
                return;
            }
            if(fromId == toId) {
                paramList = DataProvider.Instance.getParamsByLogId(fromId);
            }
            else {
                paramList = DataProvider.Instance.getParamsByLogRange(fromId, toId);
            }
            this.dataList.Items.Clear();
            foreach (var item in paramList)
            {
                this.dataList.Items.Add(new ListViewItem(item.getStringArray()));
            }       
        }


        
    }
}
