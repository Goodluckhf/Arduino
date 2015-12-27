using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoSerial.Model
{
    public class Parameter
    {
        private const String ACTIVE = "Активен";
        private const String INACTIVE = "Не активен";
        public int Id { get; set; }
        [JsonProperty("key")]
        public String Name { get; set; }
        [JsonProperty("value")]
        public String Value { get; set; }
        public int LogId { get; set; }

        public Parameter(String name, String val)
        {
            this.Name = name;
            this.Value = val;
            this.LogId = 1;
        }

        public Parameter() { }

        public static Parameter ParameterFromReader(IDataReader reader)
        {
            Parameter parameter = new Parameter();
            parameter.Id = int.Parse(reader["id"].ToString());
            parameter.Name = reader["name"].ToString();
            parameter.Value = reader["value"].ToString();
            parameter.LogId = int.Parse(reader["log_id"].ToString());
            return parameter;
        }

        public String[] getStringArray() {
            return new String[] {this.Name, this.Value};
        }

        public Parameter toString() {
            int intVal = int.Parse(this.Value);
            this.Value = intVal == 1 ? ACTIVE : INACTIVE;
            return this;
        }
    }
}
