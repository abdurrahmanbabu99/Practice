using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_With_Class
{
    //Bydefault Class is Internal in namespace 
    //in namespace class can not be a private,protected
      class Student
    {
        private string code;
        private string name;
        private int age;

        // Declare a Code property of type string:
        public string Code
        {

            get;
            set;
            /*
             get
            {
                return code;
            }
            set
            {
                code = value;
            }
            */
        }

        // Declare a Name property of type string:
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        // Declare a Age property of type int:
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public override string ToString()
        {
            return "Code = " + Code + ", Name = " + Name + ", Age = " + Age;
        }

    }
}
