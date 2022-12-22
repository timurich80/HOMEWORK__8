/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */


int[,] array = new int[2,2];
int[,] secondArray = new int[2,2];
int[,] resultArray = new int[2,2];


FillArrayRandom(array);
PrintArray2D(array);

Console.WriteLine();

FillArrayRandom(secondArray);
PrintArray2D(secondArray);

Console.WriteLine();

PrintArray2D(resultArray);

Console.WriteLine();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        
        for (int k = 0; k < array.GetLength(1); k++)
        {
            resultArray[i, j] += array[i, k] * secondArray[k, j];
        }
    }
}

void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

// Функция вывода двумерного массива в терминал 
void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}