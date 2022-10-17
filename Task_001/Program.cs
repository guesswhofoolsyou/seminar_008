/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2

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

int[,] SortMatrix(int[,] matrix)
{
    int[,] sortedMatrix = matrix;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = matrix.GetLength(1) - 1; j > 0; j--)
        {
            {
                if (sortedMatrix[i, j] > sortedMatrix[i, j - 1])
                {
                    int temp = sortedMatrix[i, j];
                    sortedMatrix[i, j] = sortedMatrix[i, j - 1];
                    sortedMatrix[i, j - 1] = temp;
                }
            }
        }
    }
    return sortedMatrix;
}

int rows = GetNumber("Введите кол-во строк:");
int columns = GetNumber("Введите кол-во столбцов:");

int[,] matrix = InitRandomMatrix(rows, columns);
Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();


int[,] sort = SortMatrix(matrix);
Console.WriteLine("Отсортированиая матрица:");
PrintMatrix(sort);
Console.WriteLine();