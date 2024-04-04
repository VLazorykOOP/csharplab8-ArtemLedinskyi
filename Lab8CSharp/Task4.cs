using System;
using System.IO;

namespace Lab8CSharp
{
    internal class Task4
    {
        static public void task(string outputFilePath,int len,double num)
        {

            double[] numbers = new double [len];
            for(int i = 0; i < len; i++)
            {
                Console.WriteLine("Введiть число: ");
                numbers[i]= double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Назва файлу(розширення .dat)");
            string fileName = Console.ReadLine();
            using(BinaryWriter br = new BinaryWriter(File.Open(fileName,FileMode.Create)))
            { 
                foreach(double number in numbers)
                {
                    br.Write(number);
                }
            }

            using (BinaryReader br = new BinaryReader(File.Open(outputFilePath, FileMode.Open)))
            {
                int index =0;
                while(br.BaseStream.Position < br.BaseStream.Length)
                {
                    double number = br.ReadDouble();
                    if(index %2==0 &&  number < num)
                    {
                        Console.WriteLine($"{index}: {number}");
                    }
                    index++;
                }
            }

        }

    }
}
