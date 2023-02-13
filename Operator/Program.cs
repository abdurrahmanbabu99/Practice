// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
int i = 3;
Console.WriteLine(i);
Console.WriteLine(i++);
Console.WriteLine(i);

double j = 3.5;
Console.WriteLine(j);
Console.WriteLine(j++);
Console.WriteLine(j);

int k = 3;
Console.WriteLine(k);
Console.WriteLine(++k);
Console.WriteLine(k);

*/

//Unary Plus and Minus
/*

Console.WriteLine(+4);
Console.WriteLine(-5);
Console.WriteLine(-(-5));

Console.WriteLine(-13 / -5);


Console.WriteLine(16.8f / 4.1);
Console.WriteLine(16.8m / 4.1m);
Console.WriteLine(-5 % 4);

*/

//Bitwise Complement operator
/*

uint t = 0b_0000_1111_0000_1111_0000_1111_0000_1100;
uint b = ~t;
Console.WriteLine(Convert.ToString(b, toBase: 2));

uint t1 = 0b_1111_0000_0000_1111_1001;
uint b1 = ~t1;
Console.WriteLine(Convert.ToString(b1, toBase: 2));

uint a1 = 0b11111000;
uint a2 = ~a1;

Console.WriteLine(Convert.ToString(a2, toBase: 2));
*/

//Logical Operator
/*

Console.WriteLine("The OR Operator Example: ");
uint p = 0b_1111_1000;
uint q = 0b_1001_1101;
uint r = p | q;
Console.WriteLine(Convert.ToString(r, toBase: 2));

Console.WriteLine("The AND Operator Example: ");    

uint p1 = 0b_0000_1111;
uint q1 = 0b_1111_1010;
uint r1 = p1 & q1;
Console.WriteLine(Convert.ToString(r1, toBase: 2));     

Console.WriteLine("The X-OR Operator Example: ");    
uint w = 0b_1111_1000;
uint v = 0b_0001_1100;
uint z = w ^ v;
Console.WriteLine(Convert.ToString(z, toBase: 2));




int d = 13 / 5 / 2;
Console.WriteLine(d);


//boolean logical operator

bool SecondOperand()
{
    Console.WriteLine("Second Operand is evaluted");
    return true;
}

bool a = false & SecondOperand(); 

Console.WriteLine(a);

bool b = true & SecondOperand();
Console.WriteLine(b);

// Logical Exclusivr OR

Console.WriteLine(true ^ true);

Console.WriteLine(true ^ false);

//Conditional Logical AND Operator
bool SecondOperand1()
{
    Console.WriteLine("Second operand is evaluated.");
    return true;
}

bool b1 = false || SecondOperand1();
Console.WriteLine(b1);

bool c1 = true || SecondOperand1();
Console.WriteLine(c1);

*/






