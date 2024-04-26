public class Calculation
{
    private string calculationLine; // строка

    // методы
    // изменение значния
    public void SetCalculationLine(string variable)
    {
        this.calculationLine = variable; // calculationLine = значению
    }

    // символ в конец строки
    public void SetLastSymbolCalculationLine(string symbol)
    {
        calculationLine += symbol; // calculationLine с symbol
    }

    // вывод свойства
    public string GetCalculationLine()
    {
        return calculationLine; // вернуть свойство
    }

    // последний символ
    public char GetLastSymbol() // char - один символ
    {
        return calculationLine[calculationLine.Length - 1]; // строка[возварт длины строки - 1] = символ по индексу строки
    }

    // удаоение последнего символа
    public void DeleteLastSymbol()
    {
        calculationLine = calculationLine.Substring(0, calculationLine.Length - 1); // строка.метод извлечения подстроки из строки(индекс от, индекс до)
    }
}

class Program
{
    static void Main()
    {
        Calculation calculation = new Calculation(); // ссылка

        calculation.SetCalculationLine("Руки дизоляторы"); // метод присвоения
        Console.WriteLine($"Строка: {calculation.GetCalculationLine()}"); // вывод

        calculation.SetLastSymbolCalculationLine("!"); // метод символа в строку
        Console.WriteLine($"Строка + символ: {calculation.GetCalculationLine()}"); // вывод

        char symbolLast = calculation.GetLastSymbol(); // symbolLast = метод последний символ
        Console.WriteLine($"Ласт символ: {symbolLast}"); // вывод

        calculation.DeleteLastSymbol(); // метод удаление символа
        Console.WriteLine($"Строка - символ: {calculation.GetCalculationLine()}"); // вывод
    }
}
