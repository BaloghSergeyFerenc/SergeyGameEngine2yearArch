using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;

namespace RealPersistenceLayer.ConfigurationPersistence.ModelReading
{
    internal class ActionDataSet : IActionDataSet
    {
        private IList<IActionData> data;

        public ActionDataSet()
        {
            data = new List<IActionData>();
            using (SQLiteConnection dbConn = new SQLiteConnection(@"Data Source=c:\trydb.db"))
            {
                dbConn.Open();
                SQLiteCommand cmd = dbConn.CreateCommand();
                cmd.CommandText = "SELECT * FROM ActionTable";
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    data.Add(
                        new ActionData(
                            (ushort)reader.GetInt32(0),
                            (ushort)reader.GetInt32(1)));
                }
                cmd.Dispose();
                reader.Dispose();
                dbConn.Close();
            }
        }

        public IEnumerator<IActionData> GetEnumerator()
        {
            return data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
