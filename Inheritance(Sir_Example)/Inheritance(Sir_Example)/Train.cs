using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Sir_Example_
{
    internal class Train : Transport
    {
        public override void StartEngine()
        {
            Console.WriteLine("Starting Train Engine");
        }
    }
}
