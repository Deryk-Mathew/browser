using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeBrowser
{
    class GlobalHistory
    {
        static Dictionary<string, string> history = new Dictionary<string, string>();

        public GlobalHistory()
        {
            history = Deserialize();
        }

        internal void addHistory(string key, string value)
        {
            if (history.ContainsKey(key))
            {
                history[key] = value;
                Serialize(history);
            }
            else
            {
                history.Add(key, value);
            }
        }

        internal List<string> displayHistory()
        {
            List<string> list = new List<string>(history.Keys);
            return list;
        }

        static void Serialize(Dictionary<string, string> data)
        {
            using (var file = File.Create(@"history.bin"))
            using (var writer = new BinaryWriter(file))
            {
                writer.Write(data.Count);
                foreach (var pair in data)
                {
                    writer.Write(pair.Key);
                    writer.Write(pair.Value);
                }
            }
        }

        static Dictionary<string, string> Deserialize()
        {
            using (var file = File.OpenRead(@"history.bin"))
            using (var reader = new BinaryReader(file))
            {
                int count = reader.ReadInt32();
                var data = new Dictionary<string, string>(count);
                while (count-- > 0)
                {
                    data.Add(reader.ReadString(), reader.ReadString());
                }
                return data;
            }
        }
    }
}
