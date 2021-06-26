using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace ConsoleApp2
{
    class Program
    {
        static void Main1(string[] args)
        {
            string filename = "file1.txt";
              ReadFileText(filename);
            //WriteFileText();
        }

        static void ReadFileText(string filename)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string[] lines;
            string str;

            if (File.Exists(filename))
            {
                //lines = File.ReadAllLines(filename);
                //for (int i = 0; i < lines.Length; i++)
                //{
                //    Console.WriteLine("Line " + i + " : " + lines[i]);
                //}
                str = File.ReadAllText(filename);
                Console.WriteLine(str);
            }
            else
            {
                Console.WriteLine("Không có file " + filename);
            }
        }
        static void WriteFileText()
        {
            string file1 = @"file2.txt";
            string file2 = @"file3.txt";
            string[] lines = new string[2];
            lines[0] = "Covid 19 has outbreak in the world";
            lines[1] = "Everyone should be at home";
            File.WriteAllLines(file1,lines);

            //cach 2
            string str = "Cộng hòa xã hội chủ nghĩa Việt nam";
            File.WriteAllText(file2, str);

        }
    }
}
