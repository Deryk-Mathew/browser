using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AwesomeBrowser
{
    public partial class Bookmarks 
    {
        // Key is URL, value is alias
        static Dictionary<string, string> bookmarks = new Dictionary<string, string>();

        //
        // Constructor
        //
        public Bookmarks() {
            bookmarks = Deserialize();
        }

        //
        // Add bookmark method
        //
        internal void addBookmark(string key, string value)
        {
            try
            {
                bookmarks.Add(key, value);
                Serialize(bookmarks);
            }
            catch (Exception) { }
        }

        //
        // edit bookmark method
        //
        internal void editBookmark(string key, string value)
        {
            bookmarks.Remove(key); // delete bookmark before adding edited bookmark
            bookmarks.Add(key, value);
            Serialize(bookmarks);
        }

        //
        // return the current bookmarks
        //
        internal List<string> displayBookmarks()
        {
            List<string> list = new List<string>(bookmarks.Values);
            return list;
        }

        //
        // return specific bookmark key from value
        //
        internal string getBookmark(string value)
        {
            return bookmarks.FirstOrDefault(x => x.Value == value).Key;
        }

        //
        // Serialize bookmark to bookmark.bin
        //
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

        //
        // Deserialize bookmark.bin to bookmark
        //
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

        //
        // Delete specific bookmark
        //
        internal void deleteBookmark(string v)
        {
            bookmarks.Remove(bookmarks.FirstOrDefault(x => x.Value == v).Key);
            Serialize(bookmarks);
        }
    }
}
