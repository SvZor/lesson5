﻿// Задача 1. Вычислить факториал от натурального числа N.
// Этапы создания рекурсии:
// 1. Рекурсивный вызов.
// (N-1)! - более простая задача
// Как использовать решение более простой задачи при рекурсивном вызове.
// переставить от множителя наоборот N! = N*(N-1)*...*1
// итоговая формурла примет следующий вид: N! = N * (N-1)! тут тоже используется факториал
// т е формула здается рекурсивно
// 2. Условние остановки рекурсии.
// например 3! = 3 * 2!
// далее 2! = 2 * 1!
// далее 1! = 1 - это и есть базовый/тривиальный случай которую дальше с помощью факториала 
// решать нет смысла

// int  Fakt(int n)
// {
//     return n * Fakt(n-1);
// }
// Fakt(5);
// // в таком виде вышел  такой результат
// // tack overflow.
// // Repeat 24094 times т .е память переполнена, т к рекурсия не была остановлена


int Fact(int n)  // добавить в код отладочный вывод, который позволит увидеть
// "раскручивание" рекурсии, т е процесс возврата к местам рекурсивного вызова функции 
// на строке34
{
    if (n == 1 || n == 0)
    {
        Console.WriteLine($"Stop: {n}");
        return 1;
    }
    Console.WriteLine(n);
    return n * Fact(n-1); // для решения дз надо разделить на составные части
}
Console.Write(Fact(10));

// решение выше только для примера, на практиве такое не используется
// на практике такая задача решалась бы с помощью цикла:

// int Fact(int n)
// {
//     int result = 1;
//     for(int i = 2; i <= n; i++)
//     {
//         result *= i;
//     }
//     return result;
// }
// Console.Write(Fact(10));
// в таком виде не будет перегрузки памяти


