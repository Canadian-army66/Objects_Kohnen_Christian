using System;
namespace Objects_Kohnen_Christian
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer myComputer = new Computer("Apple", "All-in-One", true);    //creates a computer object and assigns values to the Brand, Type, and IsOn
            IBootUP myBootUP = myComputer;  //creates the interface as an object and assigns it to the computer object
            Console.WriteLine(myComputer.Equals(myBootUP)); //compares the computer object and the interface object and oprints the result

            Computer myOtherComputer = new Computer("Apple", "All-in-One", true);   //creates a different computer object 
            Console.WriteLine(myComputer.Equals(myOtherComputer));  //compares the new object with the interface object and prints the result

            string myString = myComputer.ToString();    //creates a new string variable that is assigned to the computer object
            string myOtherString = myString;    //compares the new string to the string object

            myString = "Hi!";   //makes a nice message for the new string variable
            Console.WriteLine(myString);    //prints the new string variable
            Console.WriteLine(myOtherString);   //prints the other string object message


            Console.WriteLine(myString == myComputer.ToString());   //checks to see if myString is the same as the new string variable attached to the computer object and prints the result
            Console.WriteLine(myString == myOtherComputer.ToString());  //checks to see if myString is the same as the other string object and prints the result

            Console.WriteLine(myComputer.GetType());    //prints the type of the myComputer object
            Console.WriteLine(myBootUP.GetType());  //prints the type of the myBootUP object

            myOtherComputer.PowerOnOff();   //calls the power on/off method to change the state of the computer

            Console.WriteLine(myString == myOtherComputer.ToString());  //checks to see if the string object is the same as the ToString varriable attached ot the other computer object
            Console.WriteLine(myString);    //prints the myString object
            Console.WriteLine(myOtherComputer.ToString());  //prints the other computer object now that the computewr is off

            Console.WriteLine(myString.Contains("i"));  //checks if there are any "i" in the override message and prints the result

            Console.WriteLine(myString.ToUpper());  //turns the override message to all caps and prints the new message
        }
    }
}