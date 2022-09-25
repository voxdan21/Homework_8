// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// метод сортировки
int[,] SortArrayDescending(int[,] array)
{
    //зашли в строку
    for (int i = 0; i < array.GetLength(0); i++)
    {
        //зашли в столбец
        for (int k = 0; k < array.GetLength(1); k++)
        {
            int min = array[i, k];
            // прогнали все значения в столбце и записали в столбец в котором были.
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] < min)
                {
                    min = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = min;
                }

            }
        }
    }
    return array;
}


//Задал рандомный массив
int[,] myArr = new int[4, 7];

Random ran = new Random();
//Заполнен рандомными цифрами
for (int i = 0; i < myArr.GetLength(0); i++)
{
    for (int j = 0; j < myArr.GetLength(1); j++)
    {
        myArr[i, j] = ran.Next(-5, 5);
        Console.Write(myArr[i, j] + " ");
    }
    Console.WriteLine();
}

SortArrayDescending(myArr);
Console.WriteLine();

for (int i = 0; i < myArr.GetLength(0); i++)
{
    for (int j = 0; j < myArr.GetLength(1); j++)
    {

        Console.Write(myArr[i, j] + " ");
    }
    Console.WriteLine();
}
