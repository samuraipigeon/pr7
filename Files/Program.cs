using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace file
{

    class MyPage
    {
        public static string HighAndLow(string numbers)
        {
            var list = numbers.Split(' ').ToList();
            var max = list.Select(int.Parse).Max();
            var min = list.Select(int.Parse).Min();
            return max + " " + min;
        }
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            File.WriteAllText("D://new_file.txt", "414 490 145 443 17 404 123 144 445 158 291 315 159 389 99 330 149 160 225 423");
            string[] lines = File.ReadAllLines(@"D://new_file.txt");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
                Console.WriteLine("Максимальне і мінімальне значення:\n"+HighAndLow(line));
            }
            Console.ReadLine(); 


        }
    }
}









