using System.Text;
namespace Console_sharp_1
{
    //hw-3
    public class Program
    {
        static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            try
            {
                Console.WriteLine("Введіть нижню межу діапазону:");
                int lowerBound = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введіть верхню межу діапазону:");
                int upperBound = Convert.ToInt32(Console.ReadLine());

                if (lowerBound > upperBound) {
                    throw new Exception("Нижня межа діапазону не може бути більшою за верхню межу діапазону");
                }

                int a = 0;
                int b = 1;

                Console.WriteLine($"Числа Фібоначчі в діапазоні від {lowerBound} до {upperBound}:");

                while (a <= upperBound)
                {
                    if (a >= lowerBound)
                    {
                        Console.Write(a + " ");
                    }

                    int temp = a;
                    a = b;
                    b = temp + b;
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Помилка: {ex}");
            }
            
        }
    }
}

