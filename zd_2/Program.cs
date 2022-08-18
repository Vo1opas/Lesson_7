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
Console.WriteLine("Введите максимальное количество столбцов и строк в массиве:");
int maxSize = int.Parse(Console.ReadLine());
int maxRow = maxSize;
int maxCol = maxSize;
Console.WriteLine("Введите номер столбца от 1 до " + maxCol + ":");
int colNum = int.Parse(Console.ReadLine()) - 1;
Console.WriteLine("Введите номер строки от 1 до " + maxRow + ":");
int rowNum = int.Parse(Console.ReadLine()) - 1;

int[,] array = GetArray(maxRow, maxCol);

PrintArray(array);

if(colNum >= maxCol || rowNum >= maxRow) {
    Console.WriteLine("Извините, но такого элемента нет");
} else {
    Console.WriteLine("Значение элемента array[{0},{1}]: {2}", colNum, rowNum, array[rowNum, colNum]);
}
