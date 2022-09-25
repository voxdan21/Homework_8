// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

//перемножение матрицы
int[,] MatrixMultiplication(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
    if (array1.GetLength(1) != array2.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(0); k++)
            {
                result[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return result;
}
//печать массива
static void Print(int[,] array)
{
    Console.WriteLine("Результирующая матрица будет:" );
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}


//Задал рандомный массив
int[,] myArr1 = new int[2, 2];
int[,] myArr2 = new int[2, 2];
Random ran = new Random();
//Заполнен рандомными цифрами myArr1
for (int i = 0; i < myArr1.GetLength(0); i++)
{
    for (int j = 0; j < myArr1.GetLength(1); j++)
    {
        myArr1[i, j] = ran.Next(1, 4);
        Console.Write(myArr1[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
//Заполнен рандомными цифрами myArr2
for (int i = 0; i < myArr2.GetLength(0); i++)
{
    for (int j = 0; j < myArr2.GetLength(1); j++)
    {
        myArr2[i, j] = ran.Next(1, 4);
        Console.Write(myArr2[i, j] + " ");
    }
    Console.WriteLine();
}


int[,] resultArray = MatrixMultiplication(myArr1, myArr2);
Console.WriteLine();
Print(resultArray);
