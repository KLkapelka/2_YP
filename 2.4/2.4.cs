class Program
{
    static void Main()
    {
        Console.WriteLine("Ввкдите римское число: "); // вывод
        string line = Console.ReadLine(); // число на римском
        char[] romanNumber = line.ToCharArray(); // ... перевод в массив
        int arabic = 0; // арабское число

        // проходимся по romanNumber
        for (int i = 0; i < romanNumber.Length - 1; i++)
        {
            int currentValue = translatingNumbers(romanNumber[i]); // переменная = число по индексу
            if (i + 1 < romanNumber.Length && translatingNumbers(romanNumber[i + 1]) > currentValue) // если длинна не превышает romanNumber И число(i + 1) > i
            {
                arabic -= currentValue; // -
            }
            else
            {
                arabic += currentValue;  // +
            }
        }
        Console.WriteLine($"Арабское число: {arabic}");
    }

    // буква = число
    static int translatingNumbers(char roman)
    {
        switch(roman)
        {
            case 'I': return 1;
            case 'V': return 5;
            case 'X': return 10;
            case 'L': return 50;
            case 'C': return 100;
            case 'D':  return 500;
            case 'M': return 1000;
            default: return 0;
        }
    }
}
