using System;

class Program 
{
    static void Main()
    {
        int absoluteNumber = 0; // изначалнео число
        Console.WriteLine("Хотите сменить начальное число 0?(yes, no): "); // вывод
        string changingNumber = Console.ReadLine(); // ответ
        Random range = new Random(); // рандомайзер

        if (changingNumber == "yes")
        {
            absoluteNumber = range.Next(1,101); // absoluteNumber = от 1 до 100
        }
        int number = absoluteNumber; // запоминающая переменная
        
        Console.WriteLine("Увеличить значение: + \nУменьшить: - \nЗакончить: 0 \n"); // вывод
        // можно бы было сделать и через линию которая разделена проблемами, но мне показалось
        // что через while(true) будет удобнее
        while(true)
        {
            Console.WriteLine("Выполнить: "); // вывод
            string perform = Console.ReadLine(); // ответ

            switch (perform)
            {
                case "+":
                    increase(); //  +
                    break;
                case "-":
                    reduce(); // -
                    break;
                default:
                    Console.WriteLine($"Изначальная переменная: {absoluteNumber}  \nПолучившееся значение: {number}"); // вывод
                    Environment.Exit(0); // заверщение проги
                    break;
            }
        }

        // метод +
        void increase()
        {
            number++; // +
        }

        // метод -
        void reduce()
        {
            number--; // -
        }
    }
}
