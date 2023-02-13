using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Sir_Example_
{
    internal class Book : Product
    {
        public string Author { get; set; }

        public Book(string title,uint price) : base(title)
        {
            Title = title;  
            Price = price;  
        }

        public override string ShortDescription()
        {
            if(Description.Length>15)
                return Description.Substring(0,15);
            else
                return Description; 
        }

    }
}
