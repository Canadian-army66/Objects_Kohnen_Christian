using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Kohnen_Christian
{
    internal class Computer : IBootUP //makes the Computer class that implaments the IBootUp interface
    {
        public bool IsOn { get ; set; } //creates an automatic property for IsOn
        public string Brand { get; set; } //creates an automatic property for Brand
        public string Type { get; set; } //creates an automatic property for Type

        public Computer (string brand, string type, bool isOn)  //creates a constructor for Brand, Type, and IsOn
        {
            Brand = brand;
            Type = type;
            IsOn = isOn;
        }

        public void PowerOnOff()    //defines PowerOnOff
        {
            IsOn = !IsOn;   //sets the IsOn to the opposite value
            if(IsOn == true)    //if the bool is true, it prints the "Booting up" messahe
            {
                Console.WriteLine("The computer is booting up!");
            }
            else  //if not, it prints the "Shutting off" message
            {
                Console.WriteLine("The computer is shutting down!");
            }
        }

        public override string ToString()   //makes a override function that prints a message
        {
            return $"The computer is made by {Brand} and is a {Type} Computer! Is it on? {IsOn}!";
        }
    }
}
