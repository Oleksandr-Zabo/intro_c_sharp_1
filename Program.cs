using System.Text;
namespace Console_sharp_1
{
    //hw-6
    public class Program
    {
        static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            try
            {
                Console.WriteLine("Введіть довжину лінії:");
                int length = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введіть символ лінії:");
                string? input = Console.ReadLine();
                char? symbol;

                if (string.IsNullOrEmpty(input) || input.Length != 1)
                {
                    throw new Exception("Введіть лише один символ");
                }
                else
                {
                    symbol = input[0];
                    // Proceed with using the 'symbol' variable
                }


                Console.WriteLine("Введіть напрям(1- горизонтально, 2- вертикально): ");
                int direction = Convert.ToInt32(Console.ReadLine());
                if (direction != 1 && direction != 2)
                {
                    throw new Exception("Введіть лише 1 або 2");
                }
                for (int i = 0; i < length; i++)
                {
                    if (direction == 1)
                    {
                        Console.Write(symbol);
                    }
                    else
                    {
                        Console.WriteLine(symbol);
                    }
                }


            }
            catch (Exception ex)
            {

                Console.WriteLine($"Помилка: {ex}");
            }

        }
    }
}
