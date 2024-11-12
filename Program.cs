using System.Text;
namespace Console_sharp_1
{
    //lab-1
    public class Program
    {
        static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Введіть число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number < 1 || number > 100)
            {
                Console.WriteLine("Некорекний діапазон");
            }
            else
            {
                if (number % 3 == 0)
                {
                    Console.Write("Fill");
                }
                if (number % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }

                else if (number % 3 != 0) 
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
