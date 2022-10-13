// Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой 
//элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер 
//строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Зададим массив");
int r = ReadData("Введите кол-во строк: ");
int c = ReadData("Введите кол-во столбцов: ");
int ReadData(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int[,] CreateArray(int rows, int colums)
{
    int[,] Array = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            Array[i, j] = new Random().Next(1, 9);
        }
    }
    return Array;
}

void PrintArray(int[,] arra)
{
    for (int i = 0; i < arra.GetLength(0); i++)
    {
        for (int j = 0; j < arra.GetLength(1); j++)
        {
            Console.Write($"{arra[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] OurArray = CreateArray(r, c);

int SumLine(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}

PrintArray(OurArray);
Console.WriteLine();

int minSumLine = 0;
int sumLine = SumLine(OurArray, 0);
for (int i = 1; i < OurArray.GetLength(0); i++)
{
  int temp = SumLine(OurArray, i);
  if (sumLine > temp)
  {
    sumLine = temp;
    minSumLine = i;
  }
}

Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой");




