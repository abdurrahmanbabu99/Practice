using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    internal interface IFlyable
    {
        //Not a variable its called Signature
        string Name { get; set; }    
        void fly()
        {
            Console.WriteLine("This Plane is Take off at 6 AM");
        }
        public void Land()
        {
            Console.WriteLine("Landing");
        }

        void PlaneInfo();
    }
}
