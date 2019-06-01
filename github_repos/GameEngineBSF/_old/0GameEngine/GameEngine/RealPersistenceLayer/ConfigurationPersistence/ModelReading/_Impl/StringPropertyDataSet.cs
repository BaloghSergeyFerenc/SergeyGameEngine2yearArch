using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;

namespace RealPersistenceLayer.ConfigurationPersistence.ModelReading
{
    internal class StringPropertyDataSet : IStringPropertyDataSet
    {
        private IList<IStringPropertyData> data;

        public StringPropertyDataSet()
        {
            data = new List<IStringPropertyData>();
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
                        new StringPropertyData(
                            (ushort)reader.GetInt32(0),
                            (ushort)reader.GetInt32(1),
                            reader.GetString(2)));
                }
                cmd.Dispose();
                reader.Dispose();
                dbConn.Close();
            }
        }

        public IEnumerator<IStringPropertyData> GetEnumerator()
        {
            return data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
