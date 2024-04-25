using System;
class program
{
    static void Main()
    {
        string rules = "af"; // искомые данные
        string line = "0a4ggffa-+/1"; // предоставляемые 
        int count = 0; // счётчик
        
        // проходимся по line
        foreach (char i in line)
        {
            if (rules.Contains(i)) // содержиться ли i в rules
            {
                count++; // счётчик +1
            }
        }

        Console.WriteLine(count); // вывод
    }
}
