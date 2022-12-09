//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11

//82 -> 10

//9012 -> 12

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Print(SumNumber(number));


        static int SumNumber(int number)
        {
            int len = Convert.ToString(number).Length;
            int a = 0;
            int result = 0;
            for (int i = 0; i < len; i++)
            {
                a = number - number % 10;
                result += number - a;
                number /= 10;
            }
            return result;
        }


        static void Print(int message)
        {
            Console.WriteLine(message);
        }
    }

}