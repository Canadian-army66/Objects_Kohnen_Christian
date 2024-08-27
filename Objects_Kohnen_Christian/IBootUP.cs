using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Kohnen_Christian
{
    internal interface IBootUP
    {

        public bool IsOn { get; set; }  //creates an automatic bool
        public void PowerOnOff();   //creates a method
    }
}
