using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    internal class Plane : ITransport, IFlyable
    {
        public string Name { get; set; }

        public void fly()
        {
            Console.WriteLine("This Plane flied at: 6:30 AM");
        }

        public void Move()
        {
            Console.WriteLine("This Plane Moved at: 6:15 AM");
        }

        public void StartEngine()
        {
            Console.WriteLine("This Plane Starting Time is: 5:30 AM");
        }

        public void StopEngine()
        {
            Console.WriteLine("This Plane Engine Stoped at: 1 PM");
        }
        public void Land()
        {
            Console.WriteLine("The plane is Landing");
        }
        public void PlaneInfo()
        {
            Console.WriteLine("Plane Name is: "+Name);
            fly();
            Move();
            StartEngine();
            StopEngine();   
        }
    }
}
