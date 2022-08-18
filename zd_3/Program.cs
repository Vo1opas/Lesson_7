/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4*/


int[,] GetArray(int row, int col)
{
    int[,] array = new int[row, col];
    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

double GetArrayColumnAverage(int[,] arr, int colNum)
{
    double average = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        average += arr[i, colNum];
    }
    return Math.Round(average / arr.GetLength(0), 2);
}

Console.WriteLine("Введите максимальное количество столбцов и строк в массиве:");
int maxSize = int.Parse(Console.ReadLine());
int maxRow = maxSize;
int maxCol = maxSize;

int[,] array = GetArray(maxRow, maxCol);

PrintArray(array);

for (int i = 0; i < array.GetLongLength(1); i++)
{
    Console.WriteLine("Среднее арефметическое столбца {0} = {1}", i + 1, GetArrayColumnAverage(array, i));
}
