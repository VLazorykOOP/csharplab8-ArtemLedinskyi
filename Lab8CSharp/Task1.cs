using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Lab8CSharp
{
    internal class Task1
    {

        static public void task(string inputFilePath, string outputFilePath)
        {
            string text = File.ReadAllText(inputFilePath);
            string pattern = @"\bukrnet\S*?\.";
            int count = 0;
            text = Regex.Replace(text, pattern, match =>
            {
                count++;
                return "";
            });
            using (StreamWriter sw = new StreamWriter(outputFilePath))
            {
                sw.WriteLine($"Кiлькiсть підтекстів: {count}");
                sw.WriteLine(text);
            }
        }

    }
}
