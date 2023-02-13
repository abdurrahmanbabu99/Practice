using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Sir_Example_
{
    public class Product
    {
       // public string Name { get; set; }    
       // public string BarCode { get; set; }

        public string Title { get; set; }
        public uint Price { get; set; } 
        public string Picture { get; set; } 

        public string Description { get; set; }

        public Product(string title)
        {
            Title = title;
        }
        
        public virtual string ShortDescription()
        {
            if(Description.Length > 20)
                return Description.Substring(0,20);
            else
                return Description; 
        }

        

    }
}
