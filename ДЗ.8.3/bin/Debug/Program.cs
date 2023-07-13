// Задайте две матрицы.
// Напишите программу, которая будет находить произведение двух матриц.


// int InputInt(string output)
// {
//     Console.Write(output);
//     return int.Parse(Console.ReadLine());
// }

// void FillArrayRandomNumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 5);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.Write("]");
//         Console.WriteLine();
//     }
// }

// int size = InputInt("размерность матриц: ");
// int[,] matrixA = new int[size, size];
// int[,] matrixB = new int[size, size];
// FillArrayRandomNumbers(matrixA);
// FillArrayRandomNumbers(matrixB);
// int[,] matrixC = new int[size, size];

// for (int i = 0; i < size; i++)
// {
//     for (int j = 0; j < size; j++)
//     {
//         for (int z = 0; z < size; z++)
//         {
//             matrixC[i, j] = matrixC[i, j] + (matrixA[i, z] * matrixB[z, j]);
//         }
//     }
// }
// Console.WriteLine("Матрица - А");
// PrintArray(matrixA);
// Console.WriteLine();
// Console.WriteLine("Матрица - В");
// PrintArray(matrixB);
// Console.WriteLine();
// Console.WriteLine("Произведение матриц А*В");
// PrintArray(matrixC);

int Prompt(string message)
{
  Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int[,] CreateArray(int m, int n)
{
  int[,] array = new int[m, n];
  return array;
}

void PrintArray(int[,] array)
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

int[,] FillArrayRandom(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1, 10);
    }
  }
  return array;
}

int[,] MultiplyArray(int[,] firstArr, int[,] secondArr)
{
  int newRow, newCol;
  if (firstArr.GetLength(0) > secondArr.GetLength(0))
  {
    newRow = secondArr.GetLength(0);
  }
  else
  {
    newRow = firstArr.GetLength(0);
  }
  if (firstArr.GetLength(1) > secondArr.GetLength(1))
  {
    newCol = secondArr.GetLength(1);
  }
  else
  {
    newCol = firstArr.GetLength(1);
  }

  int[,] newArray = new int[newRow, newCol];

  for (int i = 0; i < newRow; i++)
  {
    for (int j = 0; j < newCol; j++)
    {
      for (int e = 0; e < newRow; e++)
      {
        newArray[i, j] += firstArr[i, e] * secondArr[e, j];
      }
    }
  }
  return newArray;
}

int[,] firstArr = CreateArray(Prompt("Введите количество строк массива1: "), Prompt("Введите количество столбцов массива1: "));
int[,] secondArr = CreateArray(Prompt("Введите количество строк массива2: "), Prompt("Введите количество столбцов массива2: "));
Console.WriteLine("Первый массив:");
FillArrayRandom(firstArr);
PrintArray(firstArr);
Console.WriteLine("Второй массив:");
FillArrayRandom(secondArr);
PrintArray(secondArr);
Console.WriteLine("Результирующая матрица:");
int[,] newArray = MultiplyArray(firstArr, secondArr);
PrintArray(newArray);