using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_With_Class
{
    internal class MethodOverloading
    {
        public int Add(int a,int b)
        {
            int sum = a + b;
            return sum; 
        }

        public double Add(int a,int b,double c)
        {
           double sum = a + b + c;
            return sum;
        }



    }
}
