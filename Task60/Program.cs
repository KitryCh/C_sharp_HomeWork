// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void CreateArray(int[,,] array)
{
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
                array[x, y, z] = new Random().Next(10, 100);
        }
    }
}
void PrintArray(int[,,] inArray)
{
    for (int x = 0; x < inArray.GetLength(0); x++)
    {
        Console.WriteLine("Страница №: " + (x + 1));
        Console.Write($"X({x}) ");
        for (int y = 0; y < inArray.GetLength(1); y++)
        {
        Console.Write($"Y({y}) ");
        {
            for (int z = 0; z < inArray.GetLength(2); z++)
            {
                Console.Write($"Z({z}) = {inArray[x, y, z]}; ");
            }
            Console.WriteLine();
        }
        Console.WriteLine(" ");
    }
    }
}

int[,,] newArray = new int[3, 3, 3];
CreateArray(newArray);
PrintArray(newArray);