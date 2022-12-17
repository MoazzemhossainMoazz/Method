using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        //{
        //    age(2020, 1990);
        //    Console.ReadLine();
        //}

        //public static void age(int currentYear, int dateOfBirth)
        //{
        //    Console.WriteLine(currentYear - dateOfBirth);
        //}
        {
            int myAge = age(2020, 1990);
            if (myAge > 17)
                Console.WriteLine("Adult");
            else
                Console.WriteLine("Not Adult");
            Console.ReadLine();
        }
        public static int age(int currentYear, int dateOfBirth)
        {
            return currentYear - dateOfBirth;
        }
    }
}
