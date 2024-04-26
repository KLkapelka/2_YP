class Worker
{
    public string name;  // имя
    public string surname; // фамилия
    public string rate; // должность
    public int days; // количество отработанных дней

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

        Console.WriteLine($"Зарплата {name} {surname} составляет {money * days}"); //  вывод
    }

    static void Main()
    {
        Worker worker = new Worker("Трик", "Киллуа", "Киберспортсмен", 5); // вызов конструктора
        worker.GetSalary(); // расчёт ЗП и вывод
    }
}
