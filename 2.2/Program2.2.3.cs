class NumberAndData
{
    public float number1 { get; set; } // число 1
    public float number2 { get; set; } // число 2

    public void Сonclusion() // вывод чисел
    {
        Console.WriteLine($"Число 1: {number1} \nЧисло 2: {number2}"); // число 1 и 2
        Console.WriteLine($"Сумма чисел: {SumNumbers()}"); // сумма чисел
        Console.WriteLine($"Максимальное число: {LargestNumber()}"); // max
        Console.WriteLine(); // разделитель
    }

    public float SumNumbers() // сумма чисел
    {
        return number1 + number2;
    }

    public float LargestNumber() // max
    {
        return Math.Max(number1, number2);
    }
}

class Program 
{
    static void Main()
    {
        NumberAndData numberAndData = new NumberAndData(); // ссылка
        while(true) 
        {
            Console.WriteLine($"Изменение чисел введите: 1 \nСумма чисел введите: 2 \nМаксимальное число: 3 \nЗакончить: 0");
            int answer = int.Parse(Console.ReadLine()); // ответ
            
            if(answer == 1)
            {
                Console.Write("Введите первое число: "); // вывод
                numberAndData.number1 = float.Parse(Console.ReadLine()); // ввод числа
                Console.Write("Введите второе число: "); // вывод
                numberAndData.number2 = float.Parse(Console.ReadLine()); // ввод числа
                Console.WriteLine(); // разделитель
                numberAndData.Сonclusion(); // вывод
            }
            else if(answer == 2)
            {
                Console.WriteLine($"Сумма чисел: {numberAndData.SumNumbers()}"); // сумма чисел
                Console.WriteLine(); // разделитель
            }
            else if(answer == 3)
            {
                Console.WriteLine($"Максимальное число: {numberAndData.LargestNumber()}"); // max
                Console.WriteLine(); // разделитель
            }
            else if(answer == 0)
            {
                return; // выход из цикла
            }
        }
    }
}
