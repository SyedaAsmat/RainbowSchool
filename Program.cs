using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace RainbowSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\HP\source\repos\RainbowSchool\RainbowSchool\Students.txt";

            if (File.Exists(path))
            {
                string[] alldata = File.ReadAllLines(path);
                List<string> list = new List<string>(alldata);//adding data to list

                if (alldata.Length == 0)
                {
                    Console.WriteLine("Empty file.");
                    return;
                }

                Console.WriteLine("Unsorted Student Data");
                var unsortedData = alldata.Select(row => row.Split(',').ToList());
                Console.WriteLine("Name\t\tClass");
                foreach (var item in unsortedData)
                {
                    Console.WriteLine($"{item[0]}\t{item[1]}");
                }

                Console.WriteLine("\nSorted By Names");
                var sortData = alldata.Select(row => row.Split(',')).OrderBy(row => row[0]).ToList();
                Console.WriteLine("Name\t\tClass");
                foreach (var item in sortData)
                {
                    Console.WriteLine($"{item[0]}\t{item[1]}");
                }

                Console.Write("\nEnter Student Name to Find: ");
                string n = Console.ReadLine();
                var find = sortData.FirstOrDefault(row => row[0].IndexOf(n, StringComparison.OrdinalIgnoreCase) >= 0);
                if (find != null)
                {
                    Console.WriteLine("Name:\t" + find[0] + "\nClass:\t" + find[1]);
                }
                else
                {
                    Console.WriteLine("Student Not Found");
                }
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }
        }
    }
}