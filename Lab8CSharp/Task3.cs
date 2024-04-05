using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace Lab8CSharp
{
    internal class Task3
    {
        static public void task(string inputFilePath,string outputFilePath )
        {
            Dictionary<string,int>res = new Dictionary<string,int>();
            using(StreamReader reader = new StreamReader(inputFilePath))
            {
                
                string line;
                while ((line = reader.ReadLine()) != null)
                {

                    string[] words = Regex.Split(line, @"[^\w.,]+");

                    foreach (string word in words)
                    {
                        if (string.IsNullOrWhiteSpace(word))
                            continue;
                        if (res.ContainsKey(word))
                        {
                            res[word] += 1;
                        }
                        else
                        {
                            res[word] = 1;
                        }
                    }
                    
                    }
                }
                StringBuilder sb = new StringBuilder();
                foreach (KeyValuePair<string,int> pair in res)
                    {
                        if( pair.Value == 1 ) { 
                            sb.Append(pair.Key);
                            sb.Append(" ");
                        }
                    }
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                writer.WriteLine(sb.ToString().Trim());
            }
        }

    }
}
