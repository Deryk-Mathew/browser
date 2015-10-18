using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeBrowser
{
    public partial class Bookmarks 
    {
        Dictionary<string, string> bookmarks = new Dictionary<string, string>();

        public Bookmarks() { bookmarks.Add("dave", "wibble"); }

        internal void addBookmark(string key, string url)
        {
            bookmarks.Add(key, url);
        }

       internal string readBookmark()
        {
            List<string> list = new List<string>(bookmarks.Keys);

            return list.ToString();
        }
    }
}
