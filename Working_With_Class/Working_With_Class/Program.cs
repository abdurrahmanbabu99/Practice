/*
using System;
namespace NameSpace1
{
    class Person
    {
        public void func1()
        {
            Console.WriteLine("Its Function1");
        }
    }
}

namespace NameSpace2
{
    class Person
    {
        public void func2()
        {
            Console.WriteLine("Its function2");
        }
    }
}

class MainClass{
    static void Main(string[] args)
    {
        NameSpace1.Person NC = new NameSpace1.Person();
        NameSpace2.Person NC2 = new NameSpace2.Person();

        NC.func1(); 
    }
}
*/

// Property

/*
using Working_With_Class;

TimePeriod t = new TimePeriod();

t.Hours = 24;
Console.WriteLine($"Time in Hours:{t.Hours}");

Student s = new Student();

// Setting code, name and the age of the student
s.Code = "001";
s.Name = "Zara";
s.Age = 9;
Console.WriteLine("Student Info: {0}", s);

*/

//Method Overloading

using Working_With_Class;

MethodOverloading obj = new MethodOverloading();

int sum1 = obj.Add(2, 4);
double sum2 = obj.Add(4, 6, 8.5);

Console.WriteLine(sum1);
Console.WriteLine(sum2);


