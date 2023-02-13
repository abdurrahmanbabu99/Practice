using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Sir_Example_
{
    public class Electronics : Product
    {
       // public string Model { get; set; }   



        /*
        public Electronics()
        {
            BarCode = "201011";
        }
        */

        public string Brand { get; set; }   

        public Electronics(string title) : base(title)
        {

        }

    }
}
