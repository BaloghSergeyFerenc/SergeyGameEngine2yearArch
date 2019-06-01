using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;

namespace RealPersistenceLayer.ConfigurationPersistence.ModelReading
{
    internal class BooleanPropertyDataSet : IBooleanPropertyDataSet
    {
        private IList<IBooleanPropertyData> data;

        public BooleanPropertyDataSet()
        {
            data = new List<IBooleanPropertyData>();
            using (SQLiteConnection dbConn = new SQLiteConnection(@"Data Source=c:\trydb.db"))
            {
                dbConn.Open();
                SQLiteCommand cmd = dbConn.CreateCommand();
                cmd.CommandText = "SELECT * FROM BoolPropertyTable";
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    bool temp;
                    Boolean.TryParse(reader.GetString(2), out temp);
                    data.Add(
                        new BooleanPropertyData(
                            (ushort)reader.GetInt32(0),
                            (ushort)reader.GetInt32(1),
                            temp));
                }
                cmd.Dispose();
                reader.Dispose();
                dbConn.Close();
            }
        }

        public IEnumerator<IBooleanPropertyData> GetEnumerator()
        {
            return data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
