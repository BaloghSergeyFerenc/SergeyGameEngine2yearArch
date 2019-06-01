using System;

namespace EngineController
{
    public class PublicController
    {
        bool IsRunning { get; private set; }

        public void Start()
        {

        }

        public void Stop()
        {

        }

        public void Init(string SerializedJsonForContexData)
        {
            new God(SerializedJsonForContexData);
        }

        public string Terminate()
        {
            return "SerializedJsonFromContexData";
        }
    }
}
