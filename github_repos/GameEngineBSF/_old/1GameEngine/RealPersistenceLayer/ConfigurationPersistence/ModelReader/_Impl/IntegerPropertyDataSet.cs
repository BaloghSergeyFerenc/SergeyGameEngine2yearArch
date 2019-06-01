using GameEngine.ContextPool.RealPersistenceLayer.ConfigurationPersistence.ModelReader;
using GameEngine.RealPersistenceLayer.ConfigurationPersistence.Context;
using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;

namespace GameEngine.RealPersistenceLayer.ConfigurationPersistence.ModelReader
{
    internal class IntegerPropertyDataSet : IIntegerPropertyDataSet
    {
        private IList<IIntegerPropertyData> data;

        public IntegerPropertyDataSet(IRfcpLocalContextProvider localcontextpovider)
        {
            data = new List<IIntegerPropertyData>();
            using (SQLiteConnection dbConn = new SQLiteConnection(localcontextpovider.Get.GetDbNameWithPath))
            {
                dbConn.Open();
                SQLiteCommand cmd = dbConn.CreateCommand();
                cmd.CommandText = "SELECT * FROM IntPropertyTable";
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    data.Add(
                        new IntegerPropertyData(
                            (ushort)reader.GetInt32(0),
                            (ushort)reader.GetInt32(1),
                            reader.GetInt32(2)));
                }
                cmd.Dispose();
                reader.Dispose();
                dbConn.Close();
            }
        }

        public IEnumerator<IIntegerPropertyData> GetEnumerator()
        {
            return data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
