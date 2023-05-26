// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"


// Console.WriteLine("Введите целое, положительное число -->");
// int number = Convert.ToInt32(Console.ReadLine());

// NaturalNumbers(number);  // 5

// void NaturalNumbers(int num) // 5
// {
//     //условие выхода                                     
//     if(num == 0) return;                                 // if(num == 0) return;
//     //рекурсивный вызов       1 2 3 4 5                  // Console.Write($"{num}; ");     5 4 3 2 1 
//     NaturalNumbers(num - 1);                             // NaturalNumbers(num - 1); 
//     Console.Write($"{num}; ");
// }


//-------------------------------------------------------------------------------------------------------------------------------------


// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"


// Console.WriteLine("Введите первое целое, положительное число -->");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе целое, положительное число -->");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// NaturalNumbers(firstNumber, secondNumber);

// void NaturalNumbers(int firstNum, int secondNum)
// {
//     if (firstNum < secondNum)
//     {
//         Console.Write($"{firstNum}; ");
//         NaturalNumbers(firstNum + 1, secondNum);      
//     }
//     else if (firstNum > secondNum)
//     {
//         Console.Write($"{firstNum}; ");
//         NaturalNumbers(firstNum - 1, secondNum);
//     }
//     else Console.WriteLine(firstNum);
// }


//-------------------------------------------------------------------------------------------------------------------------------------


// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// int FactorialRec(int n)
// {
// if (n == 1) return 1;
// else return n * FactorialRec(n - 1);
// }

// Console.WriteLine(SumDigit(345)); 

// int SumDigit(int num)
// {
//     if(num == 0) return 0;
//     return num % 10 + SumDigit(num / 10);
// }


//-------------------------------------------------------------------------------------------------------------------------------------


// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int sumDigit = SumDigit(3, 5);
Console.WriteLine(sumDigit);

int SumDigit(int numA, int numB)
{
    if(numB == 0) return 1;
    return numA * SumDigit(numA, numB - 1);
    
}
