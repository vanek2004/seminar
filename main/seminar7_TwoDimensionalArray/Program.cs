// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// Console.WriteLine("- Введидите количество строк и столбцов -");
// Console.Write("Колличество строк --> ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Колличество столбцов --> ");
// int column = Convert.ToInt32(Console.ReadLine());


// int[,] createMatrix = CreateMatrix(row, column);
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
//             Console.Write($"{matrix[i, j], 5}|");    //для симметрии
//         }
//         Console.WriteLine();
//     }
// }



//|-------------------------------------------------------------------------------------------------------------------------------------



// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Amn = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5



// int[,] createMatrix = CreateMatrix(3, 4);
// PrintMatrix(createMatrix);

//                     
// int[,] CreateMatrix(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns];
//     var random = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = i + j;
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
//             Console.Write($"{matrix[i, j]}|");    
//         }
//         Console.WriteLine();
//     }
// }


//|-------------------------------------------------------------------------------------------------------------------------------------



// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.



// int[,] createMatrix = CreateMatrix(3, 4, 1, 10);
// PrintMatrix(createMatrix);
// ChangeMatrix(createMatrix);
// Console.WriteLine();
// PrintMatrix(createMatrix);


                   
// int[,] CreateMatrix(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns];
//     var random = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = random.Next(min, max);
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
//             Console.Write($"{matrix[i, j], 5}|");    
//         }
//         Console.WriteLine();
//     }
// }


// void ChangeMatrix (int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i+=2)      //для того что бы не создавать цикл можно просто делать шаг через нечетные 
//     {                                                   //числа
//         for (int j = 0; j < matrix.GetLength(1); j+=2)
//         {
//             matrix[i,j] *= matrix[i, j];
//         }
//     }
    
// }







//|-------------------------------------------------------------------------------------------------------------------------------------




// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12


int[,] createMatrix = CreateMatrix(3, 4, 1, 10);
PrintMatrix(createMatrix);
int findSum = FindSum(createMatrix);
Console.WriteLine(findSum);




int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var random = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(min, max);
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
            Console.Write($"{matrix[i, j], 5}|");    
        }
        Console.WriteLine();
    }
}


int FindSum(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j)
            {
                sum += matrix[i, j];
            }
        }
    }
    return sum;
}