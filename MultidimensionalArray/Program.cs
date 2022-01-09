using System;

// Multidimensional array
int[,,] square = new int[3, 3, 3]
{
    { {1,2,3}, {4,5,6}, {7,8,9} },
    { {10,11,12}, {13,14,15}, {16,17,18} },
    { {19,20,21}, {22,23,24}, {25,26,27} },
};


for (int i = 0; i < 3; i++)
{
    // var noInnerArray = square[i]; No inner array 

    for (int z = 0; z < 3; z++)
    {
        for (int j = 0; j < 3; j++)
        {
            Console.WriteLine(square[i, z, j]);
        }

    }
}


string[,] heros = new string[2, 3]
{
    { "Loki","Borc","Lokum" },
    { "Ironman","Wanda","Captain Marwel" }
};

for (int i = 0; i < 2; i++)
{
    for (int z = 0; z < 3; z++)
    {
        Console.WriteLine(heros[i, z]);
    }
}


/// <summary>
/// Another type multidimensional array which is called Jagged array
/// Jagged array contains inner arrays , each inner array may have a different upper limit
/// </summary>
string[][] sections = new string[2][]
{
    new string [] { "A1","A2","A3" },
    new string [] { "B1","B2","B3","B4" }
};


for (int i = 0; i < sections.Length; i++)
{
    string[] innerArray = sections[i];

    for (int z = 0; z < innerArray.Length; z++)
    {
        Console.WriteLine(innerArray[z]);
    }
}



