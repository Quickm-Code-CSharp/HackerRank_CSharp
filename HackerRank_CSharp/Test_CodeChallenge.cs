using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace HackerRank_CSharp
{
    class Test_CodeChallenge
    {

        protected String PrintList(List<int> list, char delimiter = ' ')
        {
            string          str;
            StringBuilder   sb  = new StringBuilder();

            foreach (int item in list)
            {
                sb = sb.AppendFormat("{0}{1}", item.ToString(), delimiter);
            }

            str = sb.ToString();
            str = str.Trim(delimiter);

            return str;
        }

        protected String PrintList(List<string> list, char delimiter = ' ')
        {
            string          str;
            StringBuilder   sb  = new StringBuilder();

            foreach (var item in list)
            {
                sb = sb.AppendFormat("{0}{1}", item, delimiter);
            }

            str = sb.ToString();
            str = str.Trim(delimiter);

            return str;
        }

        protected String PrintDictionary(Dictionary<String, String> dict, char delimiter = ' ')
        {
            string str;
            StringBuilder sb = new StringBuilder();

            foreach (var item in dict)
            {
                sb = sb.AppendFormat("{0}:{1}{2}", item.Key, item.Value, delimiter);
            }

            str = sb.ToString();
            str = str.Trim(delimiter);

            return str;
        }

        protected bool ReadInputFile(String filename, ref String[] data)
        {
            bool valid = true;

            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), filename);
            if (!File.Exists(filename))
            {
                Console.WriteLine("Error: test file path is invalid: {0}", path);
                valid = false;
            }

            else
            {
                data = File.ReadAllLines(path);
            }

            return valid;
        }
    }
}
