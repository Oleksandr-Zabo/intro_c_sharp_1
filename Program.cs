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
                Console.WriteLine("Введіть температуру: ");
                double number = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введіть тип конвертації (0- градуси Цельсія в фаренгейт; 1- Фаренгейт в градуси Цельсія) : ");
                bool type = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()));

                if (type)
                {
                    Console.WriteLine("Температура в градусах Цельсія: " + ((number - 32) * 5 / 9));
                }
                else
                {
                    Console.WriteLine("Температура в градусах Фаренгейта: " + (number * 9 / 5 + 32));
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Помилка: {ex}");
            }

            
        }
    }
}
