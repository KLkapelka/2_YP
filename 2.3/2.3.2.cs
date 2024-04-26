class Worker
{
    private string name = "Трик";  // имя
    private string surname = "Киллуа"; // фамилия
    private string rate = "Киберспортсмен"; // должность
    private int days = 5; // количество отработанных дней

    // геттеры
    public string GetName() // имя
    {
        return name;
    }

    public string GetSurname() // фамилия
    {
        return surname;
    }

    public string GetRate() // должность
    {
        return rate;
    }

    public int GetDays() // дни
    {
        return days;
    }

    // конструктор
    public Worker(string name, string surname, string rate, int days)
    {
        this.name = name;
        this.surname = surname;
        this.rate = rate;
        this.days = days;
    }

    // ЗП
    public void GetSalary()
    {
        int money = 0;  // счётчик
        switch (rate)
        {
            case "Курато":
                money = 1000;
                break;
            case "Спикер":
                money = 800;
                break;
            case "Киберспортсмен":
                money = 1100;
                break;
            default:
                break;
        }

        Console.WriteLine($"Зарплата {GetName()} {GetSurname()} составляет {money * GetDays()}"); //  вывод
    }

    static void Main()
    {
        Worker worker = new Worker("Трик", "Киллуа", "Киберспортсмен", 5); // вызов конструктора
        worker.GetSalary(); // расчёт ЗП и вывод
    }
}
 
