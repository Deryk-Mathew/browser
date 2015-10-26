using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeBrowser
{
    class LocalHistory
    {
        List<string> local_list = new List<string>();
        int pointer = 0;

        public LocalHistory(){}

        //
        // Add returned html code to local history list
        //
        internal void addLocalHistory(string text)
        {
            local_list.Add(text);
            local_list.TrimExcess();
        }

        //
        // Method for moving backwards through local history list
        //
        internal string back()
        {
            
            if (pointer > 0)
            {
                pointer--;
                return local_list[pointer];
            }
            else
                return local_list[0];
                
        }

        //
        // Method for moving forwards through local history list
        //
        internal string forward()
        {
            if (pointer < local_list.Count - 1)
            {
                pointer++;
                return local_list[pointer];
            }
            else if (pointer > local_list.Count)
            {
                return local_list[pointer];
            }
            else
                return local_list[pointer];
        }
    }


}
