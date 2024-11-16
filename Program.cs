using System.Text;
namespace Console_sharp_1
{
    //hw-2
    public class Program
    {
        static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int? number;
            int? sum = 0;
            int? max = 0;
            int? min = 0;
            int? product = 1;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Введіть число {i + 1}: ");
                number = Convert.ToInt32(Console.ReadLine());
                sum += number;
                if (i == 0)
                {
                    max = number;
                    min = number;
                    product = number;
                }
                else
                {
                    if (number > max)
                    {
                        max = number;
                    }
                    if (number < min)
                    {
                        min = number;
                    }
                    product *= number;
                }
            }
            
            Console.WriteLine($"Сума: {sum}");
            Console.WriteLine($"Максимальне: {max}");
            Console.WriteLine($"Мінімальне: {min}");
            Console.WriteLine($"Добуток: {product}");
        }
    }
}
