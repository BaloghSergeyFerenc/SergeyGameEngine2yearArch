using GameEngine.ContextPool.RealPersistenceLayer.ConfigurationPersistence.ModelReader;
using GameEngine.RealPersistenceLayer.ConfigurationPersistence.Context;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;

namespace GameEngine.RealPersistenceLayer.ConfigurationPersistence.ModelReader
{
    internal class StringPropertyDataSet : IStringPropertyDataSet
    {
        private IList<IStringPropertyData> data;

        public StringPropertyDataSet(IRfcpLocalContextProvider localcontextpovider)
        {
            data = new List<IStringPropertyData>();
            using (SQLiteConnection dbConn = new SQLiteConnection(localcontextpovider.Get.GetDbNameWithPath))
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
