using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace HackerRank_CSharp
{
    class Test_CodeChallenge
    {

        protected String printListInt(List<int> list, char delimiter = ' ')
        {
            String str = String.Empty;

            foreach(int item in list)
            {
                str += item.ToString();
                str += delimiter;
            }

            str = str.Trim(delimiter);

            return str;
        }

        protected bool ReadInput(String filename, ref String[] data)
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
