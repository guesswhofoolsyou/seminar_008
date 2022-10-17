/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

void SearchingMinRow(int[,] matrix)
{
    int[] arraySum = new int[matrix.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        arraySum[i] = sum;
        sum = 0;
    }
    int min = arraySum[0];
    int rowIndex = 0;
    for (int i = 0; i < arraySum.Length; i++)
    {
        if (arraySum[i] < min)
        {
            min = arraySum[i];
            rowIndex = i;
        }
    }
    Console.WriteLine("Строка с минимальной суммой элементов - " + (rowIndex + 1));
}
int rows = GetNumber("Введите кол-во строк:");
int columns = GetNumber("Введите кол-во столбцов:");
Console.WriteLine();

int[,] matrix = InitRandomMatrix(rows, columns);
PrintMatrix(matrix);
SearchingMinRow(matrix);
Console.WriteLine();