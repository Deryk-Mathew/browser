using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeBrowser
{
    public partial class Bookmarks 
    {
        static Dictionary<string, string> bookmarks = new Dictionary<string, string>();

        public Bookmarks() {
            bookmarks = Deserialize();
        }

        internal void addBookmark(string key, string value)
        {
            bookmarks.Add(key, value);
            Serialize(bookmarks);
        }

         static void Serialize(Dictionary<string, string> data)
        {
            using (var file = File.Create(@"bookmark.bin"))
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
            using (var file = File.OpenRead(@"bookmark.bin"))
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
