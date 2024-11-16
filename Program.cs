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
                Console.WriteLine("Введіть число:");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Твоє число: ");

                if (number < 0) {
                    number *= -1;
                    Console.Write("-");
                }

                while(number > 0)
                {
                    Console.Write(number % 10);
                    number /= 10;
                }
                Console.WriteLine();
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Помилка: {ex}");
            }
            
        }
    }
}

