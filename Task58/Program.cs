//Задача 54: Задайте двумерный массив. 
//Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Создадим двумерный массив и упорядочим по убыванию элементы каждой строки");
int rows = ReadData("Введите кол-во строк: ");
int colums = ReadData("Введите кол-во столбцов: ");
int ReadData(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
int[,] Massiv = CreateArray(rows, colums);
int[,] CreateArray(int r, int c)
{
    int[,] Array = new int[r, c];
    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            Array[i, j] = new Random().Next(1, 99);

        }
    }
    return Array;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
}
Console.WriteLine();
PrintArray(Massiv);
Console.WriteLine();
Console.WriteLine("Отсортированый массив");
Console.WriteLine();
void MassivLine(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

MassivLine(Massiv);
PrintArray(Massiv);