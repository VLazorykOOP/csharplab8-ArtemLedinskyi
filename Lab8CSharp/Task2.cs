using System;
using System.IO;
using System.Text;


namespace Lab8CSharp
{
    internal class Task2
    {
        static public void task(string inputPath,string outputPath)
        {
            using (StreamReader reader = new StreamReader(inputPath))
            using (StreamWriter writer = new StreamWriter(outputPath))
            {
                string line = reader.ReadLine();
                while ((line=reader.ReadLine())!=null)
                {
                    StringBuilder sb = new StringBuilder();
                    char prevChar = '\0';
                    foreach (char c in line)
                    {
                        if (char.IsLetter(c))
                        {
                            if(prevChar == '\0' || c - prevChar != 1)
                            {
                                sb.Append(c);
                            }else if (sb.Length > 0 && sb[sb.Length-1]!='-') { 
                            sb.Append("-");
                            }
                            else
                            {
                                sb.Append(c);
                            }
                            prevChar = c;
                        }
                        writer.WriteLine(sb.ToString());
                    }
                }
            }
        }
    }
}
