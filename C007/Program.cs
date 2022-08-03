// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120
int inputNumber = Convert.ToInt32(System.Console.ReadLine());
int result = 1;
for (int start = 1; start <= inputNumber; start++)
{
    result*=start;
}
System.Console.WriteLine(result);
