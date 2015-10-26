using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AwesomeBrowser
{
    class GlobalHistory
    {
        static HashSet<string> history = new HashSet<string>();

        //
        // Constructor
        //
        public GlobalHistory()
        {
            history = Deserialize();
        }

        //
        // Add webpage address to history
        //
        internal void addHistory(string value)
        {
            history.Add(value);
            Serialize(history);
        }

        //
        // Return the history hashset
        //
        internal HashSet<string> displayHistory()
        {
            return history;
        }

        //
        // Clear History method
        //
        internal void clearHistory() {
            history.Clear();
            Serialize(history);
        }

        //
        // Serialize history to history.bin
        //
        static void Serialize(HashSet<string> data)
        {
            using (var file = File.Create(@"history.bin"))
            using (var writer = new BinaryWriter(file))
            {
                writer.Write(data.Count);
                foreach (var pair in data)
                {
                    writer.Write(pair);
                }
            }
        }

        //
        // Deserialize history.bin to history
        //
        static HashSet<string> Deserialize()
        {
            using (var file = File.OpenRead(@"history.bin"))
            using (var reader = new BinaryReader(file))
            {
                int count = reader.ReadInt32();
                var data = new HashSet<string>();
                while (count-- > 0)
                {
                    data.Add(reader.ReadString());
                }
                return data;
            }
        }

        //
        // return specific history item from hashset
        //
        internal string getHistory(string v)
        {
            return history.SingleOrDefault(x => x == v);
        }
    }
}
