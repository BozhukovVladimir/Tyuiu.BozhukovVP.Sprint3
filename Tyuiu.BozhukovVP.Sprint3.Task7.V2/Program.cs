using Tyuiu.BozhukovVP.Sprint3.Task7.V2.Lib;
namespace Tyuiu.BozhukovVP.Sprint3.Task7.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Божуков В. П. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Вынолнил: Божуков Владимир Павлович| ИБКСб-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить значения выражения на отрезке                                 *");
            Console.WriteLine("* от -5 до 5 и округлить результаты до 2 знаков                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            var res = ds.GetMassFunction(-5, 5);
            var str = string.Join(" ", res);
            Console.WriteLine("Данный массив - " + str);
            Console.ReadKey();
        }
    }
}
