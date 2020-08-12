using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using TODOApp.BL.Interfaces;

namespace TODOApp.BL.Models
{
    public class FileDataSaver : IDataSaver
    {
        private readonly string SAVEFILE_PATH;

        public FileDataSaver()
        {
            SAVEFILE_PATH = Directory.GetCurrentDirectory() + "/tasks.dat";
        }

        public List<Task> Load()
        {
            var formatter = new BinaryFormatter();
            var data = new List<Task>();

            using (var stream = new FileStream(SAVEFILE_PATH, FileMode.OpenOrCreate))
            {
                if (stream.Length > 0)
                {
                    data = formatter.Deserialize(stream) as List<Task>;
                }
            }

            return data;
        }

        public void Save(List<Task> data)
        {
            var formatter = new BinaryFormatter();

            using (var stream = new FileStream(SAVEFILE_PATH, FileMode.OpenOrCreate))
            {
                formatter.Serialize(stream, data);
            }
        }
    }
}
