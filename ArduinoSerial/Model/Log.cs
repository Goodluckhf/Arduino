using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoSerial.Model
{
    public class Log
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public Log(DateTime date)
        {
            this.Date = date;
        }

        public Log() {

        }

        public static Log LogFromReader(IDataReader reader)
        {
            Log log = new Log();
            log.Id = int.Parse(reader["id"].ToString());
            log.Date = DateTime.Parse(reader["created_at"].ToString());           
            return log;
        }
    }
}
