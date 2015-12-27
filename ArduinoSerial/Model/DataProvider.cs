using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoSerial.Model
{
    public class DataProvider
    {
        private static string CONNECTION_STRING = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Model\\log_db.accdb;Persist Security Info=False;";

        private static DataProvider instance = null;
        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataProvider();
                }
                return instance;
            }
        }

        private DataProvider()
        {

        }
        private DateTime GetDateWithoutMilliseconds(DateTime d)
        {
            return new DateTime(d.Year, d.Month, d.Day, d.Hour, d.Minute, d.Second);
        }
        public int CreateLog(DateTime date)
        {
            int result = 0;

            OleDbConnection connection = new OleDbConnection(CONNECTION_STRING);
           
            OleDbCommand command = new OleDbCommand(
                @"INSERT INTO
                    [log]([created_at])
                    VALUES(@date)", connection);

            command.Parameters.AddWithValue("?", GetDateWithoutMilliseconds(DateTime.Now));

            
            connection.Open();

            if (connection.State == ConnectionState.Open)
            {
                command.ExecuteNonQuery();
                command.CommandText = "SELECT @@IDENTITY";
                result = (int)command.ExecuteScalar();
            }

            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }

            return result;
        }

        public int CreateParameter(Parameter par)
        {
            int result = 0;

            OleDbConnection connection = new OleDbConnection(CONNECTION_STRING);
            OleDbCommand command = new OleDbCommand(
                @"INSERT INTO
                    [param](
                        [name],
                        [value],
                        [log_id])
                    VALUES(
                        @name,
                        @value,
                        @log_id)", connection);

            command.Parameters.Add(new OleDbParameter("name", par.Name));
            command.Parameters.Add(new OleDbParameter("value", par.Value));
            command.Parameters.Add(new OleDbParameter("log_id", par.LogId));
            connection.Open();

            if (connection.State == ConnectionState.Open)
            {
                try
                {
                    command.ExecuteNonQuery();
                }catch(Exception e) {
                   
                }
            }

            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }

            return result;
        }

        public List<Parameter> GetParams()
        {
            OleDbConnection connection = new OleDbConnection(CONNECTION_STRING);
            OleDbCommand command = new OleDbCommand("SELECT * FROM [param]", connection);

            try
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    List<Parameter> result = new List<Parameter>();

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Parameter parameter = Parameter.ParameterFromReader(reader);
                        result.Add(parameter);
                    }
                    
                    return result;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }

        public List<Parameter> getParamsByLogId(int id)
        {
            OleDbConnection connection = new OleDbConnection(CONNECTION_STRING);
            OleDbCommand command = new OleDbCommand(@"SELECT * FROM [param]
                                                      WHERE [param].[log_id] = @id", connection);
            command.Parameters.Add(new OleDbParameter("id", id));
            try
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    List<Parameter> result = new List<Parameter>();

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Parameter parameter = Parameter.ParameterFromReader(reader);
                        result.Add(parameter);
                    }

                    return result;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }


        public List<Parameter> getParamsByLogRange(int fromId, int toId)
        {
            OleDbConnection connection = new OleDbConnection(CONNECTION_STRING);
            OleDbCommand command = new OleDbCommand(@"SELECT * FROM [param]
                                                      WHERE [param].[log_id] > @from_id
                                                            AND [param].[log_id] < @to_id", connection);
            command.Parameters.Add(new OleDbParameter("from_id", fromId));
            command.Parameters.Add(new OleDbParameter("to_id", toId));
            try
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    List<Parameter> result = new List<Parameter>();

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Parameter parameter = Parameter.ParameterFromReader(reader);
                        result.Add(parameter);
                    }

                    return result;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }

        public List<Log> getLogs()
        {
            OleDbConnection connection = new OleDbConnection(CONNECTION_STRING);
            OleDbCommand command = new OleDbCommand(@"SELECT * FROM [log]", connection);
            try
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    List<Log> result = new List<Log>();

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Log log = Log.LogFromReader(reader);
                        result.Add(log);
                    }

                    return result;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }
    }
}
