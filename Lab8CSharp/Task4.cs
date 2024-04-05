using System;
using System.IO;

namespace Lab8CSharp
{
    internal class Task4
    {
        static public void task(string outputFilePath, int len, double num)
        {
            double[] numbers = new double[len];
            for (int i = 0; i < len; i++)
            {
                double input;
                Console.WriteLine($"Введiть число {i + 1}: ");
                while (!double.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Введено некоректне значення. Спробуйте ще раз.");
                }
                numbers[i] = input;
            }

            string fileName = outputFilePath;

            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                foreach (double number in numbers)
                {
                    writer.Write(number);
                }
            }
            Console.WriteLine();
            using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
            {
                int index = 1; // Починаємо з 1, оскільки індекси в C# починаються з 0
                while (reader.BaseStream.Position < reader.BaseStream.Length)
                {
                    double number = reader.ReadDouble();
                    if (index % 2 == 0 && number < num) // Перевіряємо непарні індекси
                    {
                        Console.WriteLine($"{number}");
                    }
                    index++;
                }
            }
        }
    }
}