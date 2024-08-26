﻿using System;
namespace Objects_Kohnen_Christian
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer myComputer = new Computer("Apple", "All-in-One", true);
            IBootUP myBootUP = myComputer;
            Console.WriteLine(myComputer.Equals(myBootUP));

            Computer myOtherComputer = new Computer("Apple", "All-in-One", true);
            Console.WriteLine(myComputer.Equals(myOtherComputer));

            string myString = myComputer.ToString();
            string myOtherString = myString;

            myString = "Hi!";
            Console.WriteLine(myString);
            Console.WriteLine(myOtherString);


            Console.WriteLine(myString == myComputer.ToString());
            Console.WriteLine(myString == myOtherComputer.ToString());

            Console.WriteLine(myComputer.GetType());
            Console.WriteLine(myBootUP.GetType());

            myOtherComputer.PowerOnOff();

            Console.WriteLine(myString == myOtherComputer.ToString());
            Console.WriteLine(myString);
            Console.WriteLine(myOtherComputer.ToString());

            Console.WriteLine(myString.Contains("i"));

            Console.WriteLine(myString.ToUpper());
        }
    }
}