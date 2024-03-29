﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using HackerRank_CSharp.Support;

namespace HackerRank_CSharp
{
    abstract class Test_CodeChallenge
    {
        protected Test_CodeChallenge(string filename)
        {
            ReadData(filename);
        }

        #region Printout Methods
        protected String Print2DArray<T>(T[,] arr)
        {
            string          str;
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

        protected String PrintList<T>(List<T> list, char delimiter = ' ')
        {
            string str;
            StringBuilder sb = new StringBuilder();

            foreach (T item in list)
            {
                sb = sb.AppendFormat("{0}{1}", item.ToString(), delimiter);
            }

            str = sb.ToString();
            str = str.Trim(delimiter);

            return str;
        }

        protected string PrintLinkedList(Node_LinkedList head)
        {
            string result;

            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("{0} ", head.Data);
            while (head.Next != null)
            {
                head = head.Next;
                sb.AppendFormat("{0} ", head.Data);
            }

            result = sb.ToString();

            return result;

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
        #endregion

        #region TestFile Methods
        protected void ReadData(String filename)
        {
            string[] lines = { };

            if (!ReadInputFile(filename, ref lines))
            {
                System.Environment.Exit(-1);
            }

            Lines = lines;
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

        protected List<int> ConvertToList(string line)
        {
            string[]    scoreStr    = line.Split(' ');
            var         array       = Array.ConvertAll(scoreStr, s => int.Parse(s));

            List<int> list          = new List<int>(array);

            return list;
        }

        protected int ConvertToInt(string line)
        {
            int value = 0;

            bool valid = true;

            try
            {
                value = int.Parse(line);
            }

            catch(FormatException ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
                valid = false;
            }

            catch(ArgumentNullException ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
                valid = false;
            }

            catch (OverflowException ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
                valid = false;
            }

            finally
            {
                if(!valid) { System.Environment.Exit(-1); }
            }

            return value;
        }

        protected double ConvertToDouble(string line)
        {
            double value = 0.0;
            bool valid = true;
            try
            {
                value = double.Parse(line);
            }

            catch (FormatException ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
                valid = false;
            }

            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
                valid = false;
            }

            catch (OverflowException ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
                valid = false;
            }

            finally
            {
                if (!valid) { System.Environment.Exit(-1); }
            }

            return value;
        }
        #endregion

        public string[] Lines { get; protected set; }

    }
}
