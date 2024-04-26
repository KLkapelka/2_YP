using System;
class Train
{
    public string[] theDestination = {"Новосиб", "Томск", "Северск"}; // пункт назначения
    public int[] trainNumber = [1, 2, 3]; // номер поезда
    public TimeSpan[] timeNumber = {TimeSpan.Parse("12:30:00"), TimeSpan.Parse("13:45:00"), TimeSpan.Parse("16:00:00")}; // время отправления
    public int index = -1; // индекс trainNumber
    public void  Сonclusion() // вывод инфы о поезде
    {
        Console.WriteLine($"Пункт назначения: {theDestination[index]}");
        Console.WriteLine($"Номер поезда: {trainNumber[index]}");
        Console.WriteLine($"Время отправления: {timeNumber[index]} \0");
    }
}

class Program
{
    static void Main()
    {
        Train train = new Train(); // ссылка на Train
        while(true)
        {
            Console.WriteLine("Хотите узнать о рейсе?(yes, no): "); // ввод
            string answer = Console.ReadLine(); // данные

            if (answer == "yes")
            {
                Console.WriteLine("Введите номер поезда: "); // ввод
                string number = Console.ReadLine(); // данные
                train.index = Array.IndexOf(train.trainNumber, int.Parse(number)); // возврат индекса(масиив с эллементом, строчка в число)
                train.Сonclusion(); // метод вывода информации
            }
            else
            {
                return; // возврат
            }
        }
    }
}
