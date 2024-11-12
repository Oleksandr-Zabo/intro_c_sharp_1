using System.Text;
namespace Console_sharp_1
{
    //lab-3
    public class Program
    {
        static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            try
            {
                int? result = 0;
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine($"Введіть {i + 1} цифру: ");
                    int number = Convert.ToInt32(Console.ReadLine());
                    
                    if (number < 0 || number > 9)
                    {
                        throw new Exception("Введено не цифру");
                    }
                    else
                    {
                        if (i == 0)
                        {
                            result = number;
                        }
                        else
                        {
                            result = result * 10 + number;
                        }
                    }
                }

                Console.WriteLine($"Ваше число: {result}");

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Шось пішло не так... : {ex.Message}");
            } 
        }
    }
}

