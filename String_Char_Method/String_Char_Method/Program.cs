// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string str1 = "I love";
string str2 = " Bangladesh";

//concat

string joinedString = string.Concat(str1, str2);  
Console.WriteLine(joinedString);

//compare

string str3 = "C# Programming";
string str4 = "C# Programming";
//string str5 = "xyz";

if(string.Compare(str3,str4)== 0)
{
    Console.WriteLine("Both String are matched");
}
else
{
    Console.WriteLine("Not matched");
}

//Compare Ordinal

string str6 = "JackSparrow";

string str7 = "     xyzzhgcghgh";
char[] arr = { 'J', 'a' }; 

//Console.WriteLine(string.CompareOrdinal(str6,str7));

Console.WriteLine(str7.Trim());
Console.WriteLine(str6.Trim(arr));

//contains method

string str9 = "Hello";
string str10 = "Hellodfdffff";
string str11 = "No";

Console.WriteLine(str9.Contains(str10));
Console.WriteLine(str9.Contains(str11));   

// EndsWith method

Console.WriteLine(str9.EndsWith(str10));

//Indexof Method

Console.WriteLine(str10.GetHashCode());
Console.WriteLine(str10.IndexOf("l")); 


//Insert Method()

Console.WriteLine(str10.Insert(5,"World"));

//Join method
string[] strArr = {"One","Two","Three" };
string strA = string.Join("/",strArr);

Console.WriteLine(strA);


