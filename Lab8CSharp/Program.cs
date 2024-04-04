using System;

namespace Lab8CSharp {

class Program
{
    static void Main()
    {
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Task1 task1 = new Task1();
                    Console.WriteLine("Input FilePath: ");
                    string inputFilePathforTask1 = Console.ReadLine();
                    Console.WriteLine("Output FilePath: ");
                    string outputFilePathforTask1 = Console.ReadLine();
                    Task1.task(inputFilePathforTask1, outputFilePathforTask1);
                    break;
            case 2:
                Task2 task2 = new Task2();
                Console.WriteLine("Input FilePath: ");
                string inputFilePathforTask2 = Console.ReadLine();
                Console.WriteLine("Output FilePath: ");
                string outputFilePathforTask2 = Console.ReadLine();
                Task2.task(inputFilePathforTask2, outputFilePathforTask2);
                break;
            case 3:
                Task3 task3 = new Task3();
                Console.WriteLine("Input FilePath: ");
                string inputFilePathforTask3 = Console.ReadLine();
                Console.WriteLine("Output FilePath: ");
                string outputFilePathforTask3 = Console.ReadLine();
                Task3.task(inputFilePathforTask3, outputFilePathforTask3);
                break;
                case 4:
                    Task4 task4 = new Task4();
                    Console.WriteLine("Output FilePath: ");
                    string outputFilePathforTask4 = Console.ReadLine();
                    Console.WriteLine("Введiть довжину");
                    int len = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введiть число");
                    double num = double.Parse(Console.ReadLine());
                    Task4.task(outputFilePathforTask4,len,num);
                    break;

                case 5:
                    Task5 task5 = new Task5();
                    task5.ProcessTask("Ledinskyi");
                    break;
            }
    }
}
}