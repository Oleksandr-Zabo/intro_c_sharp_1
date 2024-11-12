using System.Text;
namespace Console_sharp_1
{
    //lab-2
    public class Program
    {
        static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Введіть число: ");
            int? number = Convert.ToInt32(Console.ReadLine());
            number = number ?? 1;

            Console.WriteLine("Введіть відсоток: ");

            int? percent = Convert.ToInt32(Console.ReadLine());
            percent = percent ?? 1;

            // Ensure number and percent are not null before performing arithmetic
            double result = (number.GetValueOrDefault() * percent.GetValueOrDefault()) / 100.0;


            Console.WriteLine($"Відсоток {percent} від числа {number}: " + result);
        }
    }
}
