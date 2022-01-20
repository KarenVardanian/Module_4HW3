using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Module_4HW3.ServerSettings
{
    public class Path
    {
        public string ServerPath { get; set; }
        public void SerializePath(Path objects)
        {
            using (FileStream fs = new FileStream("configs.json", FileMode.OpenOrCreate))
            {

                JsonSerializer.SerializeAsync<Path>(fs, objects);
            }
        }
        public async Task<string> GetPath(string path)
        {
            Path restoredPerson = new Path();
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                restoredPerson = await JsonSerializer.DeserializeAsync<Path>(fs);
            }

            return restoredPerson.ServerPath.ToString();
        } 
        
    }
}
