using System;
using System.IO;

namespace RainbowSchools
{
    internal class Program
    {
        static void Read(string teachers)
        {
            using (StreamReader r = new StreamReader(teachers))
            {
                Console.WriteLine("Teacher Data\nId, Name, Class, Section");
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            Console.WriteLine();
            Menu(teachers);
        }

        static void Write(string teachers)
        {
            using (StreamWriter w = new StreamWriter(teachers, true))
            {
                Console.WriteLine("\nAdding new Data to File:");
                Console.Write("Format: Id,Name,Class,Section" +
                          "\nEnter data to add in file: ");
                string text = Console.ReadLine();
                w.WriteLine(text);
            }
            Read(teachers);
        }

        static void Replace(string teachers)
        {
            Console.Write("\nSearching data\nEnter data to search: ");
            string searchFor = Console.ReadLine();
            Console.Write("Enter new data(id, name, class, section) to replace: ");
            string newData = Console.ReadLine();
            string[] lines = File.ReadAllLines(teachers);

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains(searchFor))
                {
                    lines[i] = newData;
                    File.WriteAllLines(teachers, lines);
                }
            }
            Read(teachers);
        }

        static void Menu(string teachers)
        {
            Console.Write("1.Retrieve Teacher Data" +
                          "\n2.Store new data into File" +
                          "\n3.Update existing data" +
                          "\n4.Exit" +
                          "\nEnter your choice: ");
            int ch = Convert.ToInt16(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Read(teachers);
                    break;
                case 2:
                    Write(teachers);
                    break;
                case 3:
                    Replace(teachers);
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid Choice!\nChoose any from 1-4");
                    break;
            }
        }

        static void Main(string[] args)
        {
            string teachers = @"C:\Users\HP\source\repos\RainbowSchools\RainbowSchools\Teachers.txt";
            try
            {
                if(File.Exists(teachers))
                {
                    Menu(teachers);
                }
                else
                {
                    Console.WriteLine("File Not Found");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}