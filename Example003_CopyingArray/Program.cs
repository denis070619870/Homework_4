// Написать программу копирования массива

public class Example
{
    public static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 7, 77 };
        int i = 0;
        int length = arr.Length;
        while (i < length)
        {
            Console.WriteLine(arr[i]);
            i++;
        }
        int j = 0;
        int[] copy = new int[length];
        Array.Copy(arr, j, copy, 0, length);
        Console.WriteLine("Копия массива: ");
        Console.WriteLine(copy);
    }
}