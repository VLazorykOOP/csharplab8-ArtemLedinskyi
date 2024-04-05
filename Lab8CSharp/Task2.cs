using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;


namespace Lab8CSharp
{
    internal class Task2
    {
        static public void task(string inputFileName, string outputFileName)
        {
            // Використання блоку using для автоматичного звільнення ресурсів
            using (StreamReader reader = new StreamReader(inputFileName))
            using (StreamWriter writer = new StreamWriter(outputFileName))
            {
                // Читання тексту з вхідного файлу
                string text = reader.ReadToEnd();

                // Регулярний вираз для знаходження послідовності букв в алфавітному порядку
                string pattern = @"([a-z])(?:([a-z])(?!\1))+";

                // Заміна за допомогою регулярного виразу та запис результату у вихідний файл
                writer.Write(Regex.Replace(text, pattern, m =>
                {
                    string matched = m.Value;
                    if (matched.Length > 2)
                    {
                        // Скорочений запис послідовності
                        return $"{matched[0]}-{matched[matched.Length - 1]}";
                    }
                    else
                    {
                        // Повернення без змін, якщо послідовність не виправляється
                        return matched;
                    }
                }));
            }
        }
        }
}
