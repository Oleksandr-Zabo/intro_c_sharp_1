using System;
using System.Text;

namespace Console_sharp_1
{
    //lab-4
    public class Program
    {
        static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            try
            {
                Console.WriteLine("Введіть число: ");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number < 100000 || number > 999999)
                {
                    throw new Exception("Число не входить в діапазон");
                }

                Console.WriteLine("Введіть цифру 1: ");
                int number_1 = Convert.ToInt32(Console.ReadLine());
                if (number_1 < 1 || number_1 > 6)
                {
                    throw new Exception("Цифра 1 не входить в діапазон");
                }

                Console.WriteLine("Введіть цифру 2: ");
                int number_2 = Convert.ToInt32(Console.ReadLine());
                if (number_2 < 1 || number_2 > 6 || number_2 == number_1)
                {
                    throw new Exception("Цифра 2 не входить в діапазон");
                }

                int temp = number;
                int digit1 = 0;
                int digit2 = 0;
                int multiplier1 = 1;
                int multiplier2 = 1;

                for (int i = 0; i < 6 - number_1; i++)
                {
                    multiplier1 *= 10;
                }
                for (int i = 0; i < 6 - number_2; i++)
                {
                    multiplier2 *= 10;
                }

                digit1 = (number / multiplier1) % 10;
                digit2 = (number / multiplier2) % 10;

                int leftPart1 = number / (multiplier1 * 10);
                int rightPart1 = number % multiplier1;
                number = leftPart1 * (multiplier1 * 10) + digit2 * multiplier1 + rightPart1;

                int leftPart2 = number / (multiplier2 * 10);
                int rightPart2 = number % multiplier2;
                number = leftPart2 * (multiplier2 * 10) + digit1 * multiplier2 + rightPart2;

                Console.WriteLine($"Результат: {number}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Щось пішло не так... : {ex.Message}");
            }
        }
    }
}
