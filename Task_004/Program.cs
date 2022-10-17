/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

int[,,] InitRandomMatrix(int x, int y, int z)
{
    int[,,] matrix = new int[x, y, z];
    Random rnd = new Random();
    int num = rnd.Next(10, 50);
    for (int k = 0; k < x; k++)
    {
        for (int i = 0; i < y; i++)
        {
            for (int j = 0; j < z; j++)
            {
                matrix[i, j, k] += num;
                num ++;
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int k = 0; k < matrix.GetLength(2); k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j, k] + "(" + i + "," + j + "," + k + ")" + "\t");
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}



int x = GetNumber("Введите число x:");
int y = GetNumber("Введите число y:");
int z = GetNumber("Введите число z:");

int[,,] matrix = InitRandomMatrix(x, y, z);
PrintMatrix(matrix);

