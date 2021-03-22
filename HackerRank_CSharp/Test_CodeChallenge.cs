using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace HackerRank_CSharp
{
    abstract class Test_CodeChallenge
    {
        protected Test_CodeChallenge(string filename)
        {
            ReadData(filename);
        }

        protected String Print2DArray(int[,] arr)
        {
            string          str     = String.Empty;
            int             dimSize = arr.GetLength(0);
            StringBuilder   sb      = new StringBuilder();

            sb.AppendLine();
            for (int row = 0; row < dimSize; row++)
            {
                for (int col = 0; col < dimSize; col++)
                {
                    sb.AppendFormat("{0} ", arr[row, col].ToString());
                }
                if (row != dimSize-1)
                {
                    sb.AppendLine();
                }
            }

            str = sb.ToString();


            return str;
        }

        protected String PrintList(List<int> list, char delimiter = ' ')
        {
            string str;
            StringBuilder sb = new StringBuilder();

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
            string str;
            StringBuilder sb = new StringBuilder();

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

        protected void ReadData(String filename)
        {
            string[] lines = { };

            if (!ReadInputFile(filename, ref lines))
            {
                System.Environment.Exit(-1);
            }

            Lines = lines;

            //ProcessData(lines);

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

        protected void ProcessData(string[] lines)
        {
            string line;

            for (int i = 0; i < lines.Length; i += 1)
            {
                line = lines[i];

                // Process line
                ProcessDataLine(line, i);
            }

        }

        protected abstract void ProcessDataLine(string line, int index);

        public string[] Lines { get; protected set; }

    }
}
