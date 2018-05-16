using System;
using System.Collections;
using System.IO;

namespace Testpath
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter streamWriter = new StreamWriter(@"testpath.txt");
            streamWriter.WriteLine("Путь к файлу: " + Path.GetFullPath(@"testpath.txt"));
            Console.WriteLine("Путь к файлу: " + Path.GetFullPath(@"testpath.txt") + "\n");

            streamWriter.WriteLine("Рабочий путь: " + Environment.CurrentDirectory);
            Console.WriteLine("Рабочий путь: " + Environment.CurrentDirectory + "\n");

            Console.WriteLine("-Полная информация -" + "\n");

            Console.WriteLine("GetEnvironmentVariables: ");
            foreach (DictionaryEntry de in Environment.GetEnvironmentVariables())
            {
                streamWriter.WriteLine("  {0} = {1}", de.Key, de.Value);
                Console.WriteLine("  {0} = {1}", de.Key, de.Value);
            }
            streamWriter.Close();
            Console.ReadKey();
                
        }
    }
}
