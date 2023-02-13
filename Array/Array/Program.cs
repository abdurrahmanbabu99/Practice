// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
//single dimensional array
string[] Student = new string[5] ;

//Declare and set array element
int[] Student2 = new int[] {1,3,5,7} ;
//Alternative
int[] Student3 = {1,3,5,7};

int[,] multiDimensionalArray = new int[2, 3];

int[,] multiDimensionalArray2 = { {1,2,3},{4,5,6} };



Console.WriteLine(Student[0]);

int[,] array2D = new int[,] { {1,2},{3,4 },{5,6 },{7,8 } };
int[,] array2Da = new int[4, 2] { {1,2 }, {3,4 },{5,6 },{7,8}};

int[,,] array3D = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } }, {{7,8,9 } ,{ 10, 11, 12 } } };

Console.WriteLine(array2D[0,0]);
Console.WriteLine(array2D[0,1]);
Console.WriteLine(array3D[1,1,2]);
//Jagged Array

int[][] jaggedArray = new int[3][];

jaggedArray[0] = new int[5];
jaggedArray[1] = new int[4];

*/

// 2D Array
/*

int[,] numberGrid = {
    {10,20 },
    {30,40 },
    {50,60 }
  
};



//Console.WriteLine(numberGrid[0,1]);

foreach (int num in numberGrid)
{
    Console.Write($"{num} ");
   
}


/*

int[,] numberGrid2 = new int[2, 2];


Console.WriteLine();
Console.WriteLine("Enter Array Element: ");



for(int i=0;i< 2; i++)
{
    for (int j =0;j<2;j++)
    {
        numberGrid2[i,j] = Convert.ToInt32(Console.ReadLine());
    }

}

for(int i=0;i<2;i++)
{
    for (int j = 0; j < 2;j++)
    {
        Console.Write("Element({0},{1})={2}", i, j,numberGrid2[i,j]);  
    }
   
  }


*/

//3D Array

/*

int[,,] arr3D = new int[2, 2, 3]
{
    {{10,20,30},{40,50,60 } },
    {{70,80,90},{100,110,120} }

};

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        for (int k = 0; k < 3; k++)
        {
            Console.Write($" {arr3D[i, j, k]}" );
        }
    }
}

*/

//Jagged Array
/*
int[][] jArray = new int[2][];
jArray[0] = new int[3] {1,2,3 };
jArray[1] = new int[4] {4,5,6,7};

for (int i = 0; i<jArray.Length;i++)
{
    for(int j = 0; j < jArray[i].Length; j++)
    {
        Console.Write($" {jArray[i][j]}");
    }
}



int[][] jArray2 = new int[2][]
{
    new int[3]{3,4,5 },
    new int[4]{6,7,8,9 }
};


Console.WriteLine();
for (int i = 0; i < jArray2.Length; i++)
{
    for (int j = 0; j < jArray2[i].Length;j++)
    {
        Console.Write($"{jArray2[i][j]} ");
    }
}

*/

//In Jagged Array => 2D Array  

int[][,] jagged2D = new int[2][,]
{
    new int[2,3]{
     {10,20,30},
     {40,50,60}
    },
     new int[2, 2]{
     {100,200},
     {400,500}
    }
};

for (int i=0; i < jagged2D.Length; i++)
{
    for (int j = 0; j < jagged2D[i].Length;j++)
    {
        for (int k = 0; k < jagged2D[j].Length;k++)
        {
            Console.WriteLine($"{jagged2D[i][j,k]} ");
        }
    }
}

Console.ReadLine();







