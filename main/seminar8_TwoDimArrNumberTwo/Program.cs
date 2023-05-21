// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

// Console.WriteLine("- Введидите количество строк и столбцов -");
// Console.Write("Колличество строк --> ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Колличество столбцов --> ");
// int column = Convert.ToInt32(Console.ReadLine());


// int[,] createMatrix = CreateMatrix(row, column);
// PrintMatrix(createMatrix);
// Console.WriteLine();
// SwapPositionInMatrix(createMatrix);
// PrintMatrix(createMatrix);

//                     //строка    //столбцы
// int[,] CreateMatrix(int rows, int columns)
// {
//     int[,] matrix = new int[rows, columns];
//     var random = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = random.Next(1, 10);
//         }

//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("|");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]}|");    //для симметрии
//         }
//         Console.WriteLine();
//     }
// }

// void SwapPositionInMatrix(int[,] matrix)
// {
//     int lastPosition = matrix.GetLength(0) - 1;
//     int firstPosition = 0;
//     int temp = 0;

//     for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             temp = matrix[firstPosition, j];
//             matrix[firstPosition, j] = matrix[lastPosition, j];
//             matrix[lastPosition, j] = temp;
//         }
// }





//------------------------------------------------------------------------------------------------------------------------------------



// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для



// Console.WriteLine("- Введидите количество строк и столбцов -");
// Console.Write("Колличество строк --> ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Колличество столбцов --> ");
// int column = Convert.ToInt32(Console.ReadLine());


// int[,] createMatrix = CreateMatrix(row, column);
// PrintMatrix(createMatrix);
// Console.WriteLine();
// if (ValueMatrix(createMatrix))
// {
//     SwapRowsAndColumnsInMatrix(createMatrix);
//     PrintMatrix(createMatrix);
// }
// else
// {
//     Console.WriteLine("Error!");
// }

// //строка    //столбцы
// int[,] CreateMatrix(int rows, int columns)
// {
//     int[,] matrix = new int[rows, columns];
//     var random = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = random.Next(1, 10);
//         }

//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("|");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]}|");    //для симметрии
//         }
//         Console.WriteLine();
//     }
// }

// bool ValueMatrix(int[,] matrix)
// {
//     if (matrix.GetLength(0) == matrix.GetLength(1)) return true;
//     else return false;
// }



// void SwapRowsAndColumnsInMatrix(int[,] matrix)
// {

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < i; j++)
//         {
//             int temp = matrix[i, j];
//             matrix[i, j] = matrix[j, i];
//             matrix[j, i] = temp;
//         }
//     }
// }



//------------------------------------------------------------------------------------------------------------------------------------


// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.


// Console.WriteLine("- Введидите количество строк и столбцов -");
// Console.Write("Колличество строк --> ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Колличество столбцов --> ");
// int column = Convert.ToInt32(Console.ReadLine());


// int[,] matr = CreateMatrix(row, column);
// PrintMatrix(matr);
// Console.WriteLine();
// int[] array = NewArray(matr);
// PrintArray(array);
// Console.WriteLine();
// SortArray(array);
// PrintArray(array);
// Console.WriteLine();
// Counter(array);




// //строка    //столбцы
// int[,] CreateMatrix(int rows, int columns)
// {
//     int[,] matrix = new int[rows, columns];
//     var random = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = random.Next(1, 10);
//         }

//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("|");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]}|");    //для симметрии
//         }
//         Console.WriteLine();
//     }
// }

// int[] NewArray(int[,] matrix)
// {
//     int h = 0;
//     int[] arr = new int[matrix.Length];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             arr[h] = matrix[i, j];
//             h++;
//         }
//     }
//     return arr;
// }

// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i]);
//     }
// }

// void SortArray(int[] arr)
// {
//     Array.Sort(arr);
// }


// void Counter(int[] arr)
// {
//     int number = arr[0];
//     int count = 1;
//     for (int i = 1; i < arr.Length; i++)
//     {
//         if (arr[i] == number) count++;
//         else 
//         {
//             Console.WriteLine($"число {number} встречается {count} раз");
//             count = 1;
//             number = arr[i];
//         }
//     }
//      Console.WriteLine($"число {number} встречается {count} раз");
// }





//------------------------------------------------------------------------------------------------------------------------------------




// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7






Console.WriteLine("- Введидите количество строк и столбцов -");
Console.Write("Колличество строк --> ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Колличество столбцов --> ");
int column = Convert.ToInt32(Console.ReadLine());


int[,] createMatrix = CreateMatrix(row, column);
PrintMatrix(createMatrix);
Console.WriteLine();


//строка    //столбцы
int[,] CreateMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    var random = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(1, 10);
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}|");    //для симметрии
        }
        Console.WriteLine();
    }
}

int FindMinElement (int[,] matrix)
{
    int min = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] > min) min = matrix[i, j];
        }
    }
    return min;
}


//........мда