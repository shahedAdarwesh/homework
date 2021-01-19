using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cSharpHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = "";
            int Age = 0;
            int TYear = 2021;
            int YOB =0;

            Console.WriteLine("enter your name: ");
            Name = Console.ReadLine();

            Console.WriteLine("enter your age: ");
            Age = Convert.ToInt32(Console.ReadLine());

            YOB = TYear - Age;

            Console.WriteLine("your name is " + name + " and the year that you are born in " + YOB);

            

        }
    }
}
