using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo wsbDir = new DirectoryInfo(".");
            DirectoryInfo studentDir = new DirectoryInfo("C:\\users\\student ");




            Console.WriteLine(wsbDir.FullName);
            Console.WriteLine(wsbDir.Name);
            Console.WriteLine(wsbDir.Parent);
            Console.WriteLine(wsbDir.Attributes);
            Console.WriteLine(wsbDir.CreationTime);

            string[] customers =
            {
                "Anna Kowalska",
                "Janusz Kowalski",
                "Anna Kowal",
            };

            string path = @"C:\useres\student\files";

            if (Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                string pathFile = @"C:\useres\student\files\plik.txt";
                //File.WriteAllText(pathFile, customers); // errrrrror
                File.WriteAllLines(pathFile, customers);
                File.Exists(pathFile);
                Console.WriteLine("Plik został utworzony");
            }
            else
            {
                Console.WriteLine("Katalog istnieje");
                //Directory.Delete(path);
            }
            
 

            



            Console.ReadKey();
        }
    }
}
