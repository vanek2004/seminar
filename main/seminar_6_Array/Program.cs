// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// Console.Write("Введите размер массива --> ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] arr = RandomArray(size);
// PrintArray(arr);
// Console.WriteLine();
// ReversArray(arr);
// PrintArray(arr);
// Console.WriteLine();
// Array.Reverse(arr);
// PrintArray(arr);

// int[] RandomArray(int length)
// {
//     int[] array = new int[length];
//     var random = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = random.Next(1, 10);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }   
// }

// void ReversArray(int[] array)
// {
//     for (int i = 0; i < array.Length / 2; i++)              //создаем цикл, в котором что бы не выйти за рамки делим его на 2
//     {
//         int temp = array[i]; //1                            //переменной temp мы даем значение текущего индекса
//         array[i] = array[array.Length - 1 - i];             //передаем число из последнего индекса в первый
//         array[array.Length - 1 - i] = temp;                 //передаем число из первого в последний
//     }
// }



//|-------------------------------------------------------------------------------------------------------------------------------------




// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

// Console.WriteLine("Введите 3 числа означающих длину стороны треугольника -->");
// Console.Write("A = ");
// int Asides = Convert.ToInt32(Console.ReadLine());
// Console.Write("B = ");
// int Bsides = Convert.ToInt32(Console.ReadLine());
// Console.Write("C = ");
// int Csides = Convert.ToInt32(Console.ReadLine());

// bool end = SidesTriangle(Asides, Bsides, Csides);
// Console.Write(end ? "Такой треугольник возможен" : "Не возможно создать треугольник(поменяйте значения)!!!");


// bool SidesTriangle (int A, int B, int C )
// {
//     if ((B + C) > A && (A + C) > B && (A + B) > C) return true;
//     else return false;
// }




//|-------------------------------------------------------------------------------------------------------------------------------------





// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


// Console.WriteLine("Введите десятичное число -->");
// Console.Write("number = ");
// int number = Convert.ToInt32(Console.ReadLine());

// int convertNumber = ConvertNumber(number);
// Console.Write(convertNumber);

// int ConvertNumber (int num)
// {
//     int result = 0;
//     int counter = 1;
//     while (num > 0)                      //выполняем пока число больше 0
//     {
//         result += num % 2 * counter;     //в переменную result мы вносим остаток от num%2 и * на counter
//         num /= 2;                        //далее число делим на 2
//         counter *= 10;                   // и counter *10
//     }
//     return result;
// }





//|-------------------------------------------------------------------------------------------------------------------------------------




// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


// Console.WriteLine("- Укажите сколько вы хотите видеть  чисел Фибоначчи - ");
// Console.Write(" SIZE - ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] fibonacci = Fibonacci(size);
// PrintArray(fibonacci);

// int[] Fibonacci (int length)
// {
//     int[] arr = new int[length];
//     arr[1] = 1;
//     for (int i = 2; i < arr.Length; i++)
//     {
//         arr[i] = arr[i -1] + arr[i -2];
//     }
//     return arr;
// }

// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
// }






//|-------------------------------------------------------------------------------------------------------------------------------------






// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

Console.WriteLine(" - Введите размер массива - ");
Console.Write("SIZE - ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("First array - ");
int[] arr = RandomArray(size);
PrintArray(arr);
Console.WriteLine();
Console.Write("New array - ");
int[] newArr = CreateCopyArray(arr);
PrintArray(newArr);

int[] RandomArray(int length)
{
    int[] array = new int[length];
    var random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(1, 10);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }   
}

int[] CreateCopyArray (int[] arr)
{
    int[] newArray = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        newArray[i] = arr[i];
    }
    return newArray;
}





//|-------------------------------------------------------------------------------------------------------------------------------------






