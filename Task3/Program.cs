//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33-> [6, 1, 33]

internal class Program
{
    private static void Main(string[] args)
    {
       
        int[] z = new int[8];
        AddRandomInt(z);
        Print(z);

        static void Print(int[] ar)
        {
            Console.Write($"[{ar[0]}, ");
            for (int i = 1; i < ar.Length - 1; i++)
            {
                Console.Write($"{ar[i]}, ");
            }
            Console.Write($"{ar[ar.Length - 1]}]");
        }

        static void AddRandomInt(int[] arr)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                Random r = new Random();
                arr[j] = r.Next(1, 1000);
            }
        }
    }
}