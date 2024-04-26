class Program
{
    public float number { get; set; } // число
    public string text { get; set; } // текст

    // Конструктор с входными параметрами
    public Program(float number, string text)
    {
        this.number = number; // прсвоить number
        this.text = text; // прсвоить text
    }

    // Конструктор свойств по умолчанию
    public Program()
    {
        this.number = 0; // прсвоить number = 0
        this.text = "Null"; // прсвоить text = Null
    }

    // Деструктор удалено
    ~Program()
    {
        Console.WriteLine("Объект был удален"); // вывод
    }

    // вывод
    public void ConclusionInformation()
    {
        Console.WriteLine($"Число: {number}, Текст: {text}"); // вывод
    }  
}

class Conclusion
{
    static void Main()
    {
        Console.WriteLine("Введите число:"); // вывод
        float num = float.Parse(Console.ReadLine()); // данные
        Console.WriteLine("Введите текст: "); // вывод
        string tex = Console.ReadLine(); // данные

        Console.WriteLine("\nСоздание объекта с параметрами:"); // вывод
        Program program1 = new Program(num, tex); // принимающий Program
        program1.ConclusionInformation(); // вывод

        Console.WriteLine("\nСоздание объекта с использованием конструктора по умолчанию:"); // вывод
        Program program2 = new Program(); // пустой Program
        program2.ConclusionInformation(); // вывод

        GC.Collect(); // очистка памяти под объект
        Console.Read(); // задержка через tnter
        Console.WriteLine("Объект удалён"); // вывод
    }
}
