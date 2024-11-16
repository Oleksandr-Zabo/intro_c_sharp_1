using System;
using System.Globalization;//for CultureInfo
using System.Text;

namespace Console_sharp_1
{
    //lab-5
    public class Program
    {
        static void Main()
        {
             
            

            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            try
            {
                Console.WriteLine("Введіть дату у форматі dd.MM.yyyy:");
                string? input = Console.ReadLine();
                DateTime date;

                if (DateTime.TryParseExact(input, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                {
                    string? season;
                    int month = date.Month;
                    if (month == 12 || month == 1 || month == 2)
                    {
                        season = "Winter";
                    }
                    else if (month >= 3 && month <= 5)
                    {
                        season = "Spring";
                    }
                    else if (month >= 6 && month <= 8)
                    {
                        season = "Summer";
                    }
                    else if (month >= 9 && month <= 11)
                    {
                        season = "Autumn";
                    }
                    else
                    {
                        throw new Exception("Неправильний місяць.");
                    }


                    string dayOfWeek = date.ToString("dddd", new CultureInfo("en-US"));//culture for english day of week
                    Console.WriteLine($"{season} {dayOfWeek}");
                }
                else
                {
                    throw new Exception("Неправильний формат дати.");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Помилка: {ex}"); ;
            }

            
        }   
    }
}
