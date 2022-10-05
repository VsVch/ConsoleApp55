using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int chislo = int.Parse(Console.ReadLine());
            bool check = 100 <= chislo && chislo <= 200 || chislo == 0;
            if (!check)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
