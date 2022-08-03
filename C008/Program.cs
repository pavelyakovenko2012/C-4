// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
int[] array = GetBinaryArray(8);
System.Console.Write($"[{String.Join(",", array)}]");
int[] GetBinaryArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(2);
    }
    return result;
}
