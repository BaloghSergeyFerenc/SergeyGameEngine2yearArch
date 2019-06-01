using GameEngine.ContextPool.RealPersistenceLayer.ConfigurationPersistence.ModelReader;
using GameEngine.RealPersistenceLayer.ConfigurationPersistence.Context;
using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;

namespace GameEngine.RealPersistenceLayer.ConfigurationPersistence.ModelReader
{
    internal class RelationDataSet : IRelationDataSet
    {
        private IList<IRelationData> data;

        public RelationDataSet(IRfcpLocalConextProvider localcontextpovider)
        {
            data = new List<IRelationData>();
            using (SQLiteConnection dbConn = new SQLiteConnection(localcontextpovider.Get(CpLocalContextType.Rfcp).GetDbNameWithPath))
            {
                dbConn.Open();
                SQLiteCommand cmd = dbConn.CreateCommand();
                cmd.CommandText = "SELECT * FROM RelationTable";
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    data.Add(
                        new RelationData(
                            (ushort)reader.GetInt32(0),
                            (ushort)reader.GetInt32(1),
                            (ushort)reader.GetInt32(2)));
                }
                cmd.Dispose();
                reader.Dispose();
                dbConn.Close();
            }
        }

        public IEnumerator<IRelationData> GetEnumerator()
        {
            return data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
