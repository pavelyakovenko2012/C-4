// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
int number = Convert.ToInt32(Console.ReadLine());
string numstr = Convert.ToString(number);
System.Console.WriteLine(numstr.Length);