using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp._30_Days_of_Code
{
    class Day28_String_EmailAddress
    {
        public List<string> CompileEmailList(Dictionary<string, string> emailMap, string domain)
        {
            List<string> names = new List<string>();

            foreach(var item in emailMap)
            {
                if (item.Key.Contains(domain))
                {
                    names.Add(item.Value);
                }
            }

            return names;
        }
    }
}
