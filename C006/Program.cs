// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120
int inputNumber = Convert.ToInt32(System.Console.ReadLine());
int result = 1;
int start = 1;
while(start<=inputNumber)
{
    result *= start;
    start++;
}
System.Console.WriteLine(result);