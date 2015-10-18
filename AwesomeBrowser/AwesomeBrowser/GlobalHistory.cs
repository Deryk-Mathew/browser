using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AwesomeBrowser
{
    class GlobalHistory
    {
        private static string filePath = @"TextFile1.txt";
        static List<string> global_list = new List<string>();
        static List<string> noDupes = new List<string>();

        public GlobalHistory() {

        }

        public static void addGlobalHistory(string text)
        {
            global_list.Add(text);
            noDupes = global_list.Distinct().ToList();
        }

        public void readFile()
        {
            using (var streamReader = new StreamReader(filePath, Encoding.Default))
            {
                while (!streamReader.EndOfStream)
                {
                    global_list.Add(streamReader.ReadLine());
                }
            }
        }

        public void writeFile()
        {
            using (var streamWriter = new StreamWriter(filePath, false, Encoding.Default))
            {
                foreach (string line in noDupes)
                {
                    streamWriter.WriteLine(line);
                }
            }
        }
    }
}
