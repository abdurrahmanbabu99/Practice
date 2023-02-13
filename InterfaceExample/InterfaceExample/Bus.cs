using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    internal class Bus : ITransport
    {
        public string Name { get; set; }   
        public void Move()
        {
            Console.WriteLine("This Bus Moved at: 7:15 AM");
        }

        public void StartEngine()
        {
            Console.WriteLine("This Bus Engine Start at: 7:15 AM");
        }

        public void StopEngine()
        {
            Console.WriteLine("This Bus Engine Stopped at: 7:15 AM");
        }
        public void BusInfo()
        {
            Console.WriteLine("Bus Name is: "+Name);
            Move();
            StartEngine();
            StopEngine();
        }

    }
}
