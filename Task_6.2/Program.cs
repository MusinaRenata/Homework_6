// найти произведение двух матриц

int[,] matr1 = {
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9}
};

int[,] matr2 = {
    {8, 8, 8},
    {8, 8, 8},
    {8, 8, 8}
};


void MultiplicationMatrices(int[,] matr1)
{
for (int i = 0; i < 3; i++) 
{
    for (int j = 0; j < 3; j++)
    {
    matr1[i, j] = matr1[i, j] * matr2[i, j];
    }
}
}

void PrintArray(int[,] matr1)
{
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr1.GetLength(1); j++)
        {
        Console.Write($"{matr1[i, j]} ");  
        }
        Console.WriteLine();  
    }
}

int[,] matrix = new int[3,3];
MultiplicationMatrices(matr1);
Console.WriteLine(); 
PrintArray(matr1);
