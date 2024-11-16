using System.Text;
namespace Console_sharp_1
{
    //lab-6
    public class Program
    {
        static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            try
            {
                Console.WriteLine("Введіть перше число: ");
                int number_1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введіть друге число: ");
                int number_2 = Convert.ToInt32(Console.ReadLine());

                if (number_1 > number_2) { 
                    int temp = number_1;
                    number_1 = number_2;
                    number_2 = temp;
                }

                for (int i = number_1; i <= number_2; i++)
                {
                    if (i % 2 == 0) {
                        Console.Write(i + " ");
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
