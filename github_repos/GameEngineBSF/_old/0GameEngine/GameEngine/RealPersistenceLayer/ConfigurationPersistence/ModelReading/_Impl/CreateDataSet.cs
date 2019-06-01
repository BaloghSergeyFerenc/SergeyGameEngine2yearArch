using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;

namespace RealPersistenceLayer.ConfigurationPersistence.ModelReading
{
    internal class CreateDataSet : ICreateDataSet
    {
        private IList<ICreateData> data;

        public CreateDataSet()
        {
            data = new List<ICreateData>();
            using (SQLiteConnection dbConn = new SQLiteConnection(@"Data Source=c:\trydb.db"))
            {
                dbConn.Open();
                SQLiteCommand cmd = dbConn.CreateCommand();
                cmd.CommandText = "SELECT * FROM CreateTable";
                SQLiteDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    data.Add(
                        new CreateData(
                            (ushort)reader.GetInt32(0),
                            (ushort)reader.GetInt32(1),
                            (ushort)reader.GetInt32(2)));
                }
                cmd.Dispose();
                reader.Dispose();
                dbConn.Close();
            }
        }

        public IEnumerator<ICreateData> GetEnumerator()
        {
            return data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
