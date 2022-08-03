// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120
int fact = Convert.ToInt32(System.Console.ReadLine());
int result = 1;
for (int i = 1; i <= fact; i++)
{
    result = result*i;
}
System.Console.WriteLine(result);