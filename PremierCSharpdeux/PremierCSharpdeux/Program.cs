using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierCSharpdeux
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Complexe c1 = new Complexe(3, 5);
            Complexe c2 = new Complexe(2, 3);
            Console.WriteLine(c1.Addition(c2).ToString());
            Console.ReadLine();
        }
    }
}
