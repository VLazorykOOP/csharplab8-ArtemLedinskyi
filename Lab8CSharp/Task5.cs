using System;
using System.IO;

namespace Lab8CSharp
{
    public class Task5
    {
        public void ProcessTask(string studentSurname)
        {
            string folder1Path = $@"d:\temp\{studentSurname}1";
            string folder2Path = $@"d:\temp\{studentSurname}2";

            // 1. Створення папок
            Directory.CreateDirectory(folder1Path);
            Directory.CreateDirectory(folder2Path);

            // 2. Створення файлів та запис в них тексту
            string text1 = "<Шевченко Степан Іванович, 2001> року народження, місце проживання <м. Суми>";
            string text2 = "<Комар Сергій Федорович, 2000> року народження, місце проживання <м. Київ>";

            // Заміна кутових дужок на лапки
            text1 = text1.Replace("<", "\"").Replace(">", "\"");
            text2 = text2.Replace("<", "\"").Replace(">", "\"");

            File.WriteAllText(Path.Combine(folder1Path, "t1.txt"), text1);
            File.WriteAllText(Path.Combine(folder1Path, "t2.txt"), text2);

            // 3. Переписування тексту з файлів t1.txt та t2.txt в t3.txt
            string t1Content = File.ReadAllText(Path.Combine(folder1Path, "t1.txt"));
            string t2Content = File.ReadAllText(Path.Combine(folder1Path, "t2.txt"));

            File.WriteAllText(Path.Combine(folder2Path, "t3.txt"), t1Content + Environment.NewLine + t2Content);

            // 4. Виведення розгорнутої інформації про створені файли
            Console.WriteLine("Створені файли:");
            string[] allFiles = Directory.GetFiles(folder2Path);
            foreach (string file in allFiles)
            {
                Console.WriteLine(file);
            }

            // 5. Переміщення файлу t2.txt до папки folder2Path
            File.Move(Path.Combine(folder1Path, "t2.txt"), Path.Combine(folder2Path, "t2.txt"));

            // 6. Копіювання файлу t1.txt у папку folder2Path
            File.Copy(Path.Combine(folder1Path, "t1.txt"), Path.Combine(folder2Path, "t1.txt"), true);

            // 7. Перейменування папки folder2Path в ALL та видалення папки folder1Path
            Directory.Move(folder2Path, @"d:\temp\ALL");
            Directory.Delete(folder1Path, true); // Вказуємо true для рекурсивного видалення

            // 8. Виведення повної інформації про файли папки ALL
            Console.WriteLine("Повна інформація про файли папки ALL:");
            string[] allFilesInAllFolder = Directory.GetFiles(@"d:\temp\ALL", "*", SearchOption.AllDirectories);
            foreach (string file in allFilesInAllFolder)
            {
                Console.WriteLine(file);
            }
        }
    }
}
