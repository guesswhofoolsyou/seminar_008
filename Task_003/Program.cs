/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3

Результирующая матрица будет:
18 20
15 18
*/

int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

int[,] InitRandomMatrix(int n, int m)
{
    int[,] matrix = new int[n, m];
    Random rnd = new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

bool MultiplyCheck(int[,] firstMatrix, int[,] secondMatrix)
{
    bool check = false;
    if (firstMatrix.GetLength(1) != secondMatrix.GetLength(0))
    {
        Console.WriteLine("Произведение матриц найти невозможно!");
    }
    else
    {
        check = true;
    }
    return check;
}

int[,] MultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] resultMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < firstMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < secondMatrix.GetLength(1); k++)
            {
                resultMatrix[i, k] = firstMatrix[i, j] * secondMatrix[j, k];
            }
        }
    }
    return resultMatrix;
}

int firstRows = GetNumber("Введите кол-во строк первой матрицы:");
int firstColumns = GetNumber("Введите кол-во столбцов первой матрицы:");

int secondRows = GetNumber("Введите кол-во строк второй матрицы:");
int secondColumns = GetNumber("Введите кол-во столбцов второй матрицы:");

int[,] firstMatrix = InitRandomMatrix(firstRows, firstColumns);
int[,] secondMatrix = InitRandomMatrix(secondRows, secondColumns);
Console.WriteLine();

PrintMatrix(firstMatrix);
Console.WriteLine();

PrintMatrix(secondMatrix);
Console.WriteLine();

if (MultiplyCheck(firstMatrix, secondMatrix) != false)
{
    int[,] resultMatrix = MultiplyMatrix(firstMatrix,secondMatrix);
    PrintMatrix(resultMatrix);
}

