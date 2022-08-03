// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(System.Console.ReadLine());
int countPositive = 0;
while(number !=0)
{
    number/=10;
    countPositive++;
}
System.Console.WriteLine($"Количество чисел: {countPositive}");