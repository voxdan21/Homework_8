// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


//  Функция заполнения массива по спирали начиная с 1
void FillArraySpiral(int[,] array, int quantityline)
{
    int line = 0;
    int column = 0;
    int temp  = 1;
    while (temp <= array.GetLength(0) * array.GetLength(1))
    {
        array[line, column] = temp;
        temp++;
        if (line <= column + 1 && line + column < array.GetLength(1) - 1)
            column++;
        else if (line < column && line + column >= array.GetLength(0) - 1)
            line++;
        else if (line >= column && line + column > array.GetLength(1) - 1)
            column--;
        else
            line--;
    }
}

//  Функция вывода двумерного массива в терминал
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j] + " ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }

}

int len = 4;
int[,] table = new int[len, len];
FillArraySpiral(table, len);
PrintArray(table);