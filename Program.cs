
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в
// промежутке от N до 1. Выполнить с помощью рекурсии.
Console.Write("Введите число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int count = 1;


string NaturalToLow( int start, int end)
{
    if (start == end) return start.ToString()  ;
    
       return  start + "," + NaturalToLow(start + 1, end); 
}

Console.WriteLine($"Последовательность: '{NaturalToLow(count, numberN)}' ");



/*
//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
//элементов в промежутке от M до N.
Console.Write("Задайте значения M:");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте значения N:");
int numberN = Convert.ToInt32(Console.ReadLine());
int temp =0 ;

SumElements(numberM, numberN, temp);
void SumElements( int start, int end, int sum)
{
     sum = sum + start;
    if (start == end)  
    {
    Console.WriteLine("Сумма элементов = " + sum); 
    return;
    }
     SumElements(start + 1, end, sum); 
}
*/



/*
 //Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
 // Даны два неотрицательных числа m и n.
Console.Write("Задайте значения M:");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте значения N:");
int numberN = Convert.ToInt32(Console.ReadLine());
    
   
int Function(int m, int n)
{
     if (m == 0) 
     {
       return n + 1;
     }
      if (n == 0) 
      {
          return Function(m - 1, 1);
      }
      return Function(m - 1, Function(m, n - 1));
}

Console.Write("функции Аккермана = " + Function(numberM, numberN));
*/    


