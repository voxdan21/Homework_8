// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// создание массива
int[,,] arrayTrippe()
{
    Console.WriteLine("Введите сторону x трехмерного массива :");
    int x = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите сторону x трехмерного массива :");
    int y = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите сторону x трехмерного массива :");
    int z = int.Parse(Console.ReadLine());
    int[,,] array = new int[x, y, z];
    return array;
}

// метод помогает созавать уникальные рандомные цифры, неповторяющиеся
int CheckNewNumber(int[] array, int min, int max)
{
    Random ran = new Random();
    int x = ran.Next(min, max);
    for (int n = 0; n < array.Length; n++)
    {
        if (array[n] == x)
        {
            return CheckNewNumber(array, min, max);
        }
    }
    return x;


}


// создание массива с рандомными цифрами
int[,,] arrayTrippeRandom(int[,,] array)
{
    Console.WriteLine("Введите сторону min трехмерного массива :");
    int min = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите сторону max трехмерного массива :");
    int max = int.Parse(Console.ReadLine());
    int[] tempArray = new int[max - min];
    int count = 0;
    Random ran = new Random();
    if (tempArray.Length < (array.GetLength(0) + array.GetLength(1) + array.GetLength(2)))
    {
        throw new Exception("Отрезок уникальных значений меньше, чем колличество ячеек в массиве");
    }
    else
    {
        for (int x = 0; x < array.GetLength(0); x++)
        {
            for (int y = 0; y < array.GetLength(1); y++)
            {
                for (int z = 0; z < array.GetLength(2); z++)
                {
                    tempArray[count] = CheckNewNumber(tempArray, min, max);
                    array[x, y, z] = tempArray[count];
                    count++;
                }
            }
        }
        return array;
    }


}
// вывод массива
static void Print(int[,,] array)
{
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                Console.WriteLine($"{array[x, y, z]}({x},{y},{z}) ");
            }
        }
    }

}

int[,,] result = arrayTrippe();
arrayTrippeRandom(result);
Print(result);