using System.Text;
namespace Console_sharp_1
{
    //hw-5
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

                if (lowerBound > upperBound)
                {
                    throw new Exception("Нижня межа діапазону не може бути більшою за верхню межу діапазону");
                }
                for (int i = lowerBound; i <= upperBound; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine();
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Помилка: {ex}");
            }

        }
    }
}
