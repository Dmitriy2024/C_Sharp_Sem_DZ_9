// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в
// промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Write("Введите число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int count = 1;


string NaturalToLow( int count, int numberN)
{
    if (count == numberN) return count.ToString()  ;
    
       return  count + "," + NaturalToLow(count + 1, numberN); 
}

Console.WriteLine($"Последовательность: '{NaturalToLow(1, numberN)}' ");
