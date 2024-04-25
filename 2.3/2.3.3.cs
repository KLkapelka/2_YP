using System;

class Student // объектный класс 
{
    // свойство
    public string lastName { get; set; } // фамилия. {чтение, изменения}
    public DateTime dateOfBirth { get; set; } // дата рождения
    public int groupNumber { get; set; } // номер группы
    public int[] grades { get; set; } = new int[4]; // оценки

    public void Сonclusion() // вывод инфы о студенте
    {
        Console.WriteLine($"Фамилия: {lastName}");
        Console.WriteLine($"Дата рождения: {dateOfBirth}");
        Console.WriteLine($"Номер группы: {groupNumber}");
        Console.Write("Оценки: ");
        foreach (int i in grades)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}

class Program_1
{
    static void Main()
    {
        Student student = new Student(); // Вызывает конструктор по умолчанию и присваивает ссылку. Оператор создание объектса

        Console.Write("Введите фамилию студента: "); // вывод
        student.lastName = Console.ReadLine(); // ввод фамилии. объект.свойство = (запись)
        Console.Write("Введите дату рождения учащегося (гггг-мм-дд): "); // вывод
        student.dateOfBirth = DateTime.Parse(Console.ReadLine()); // ввод  даты
        Console.Write("Введите номер группы студента: "); // вывод
        student.groupNumber = int.Parse(Console.ReadLine()); // ввод группы

        Console.WriteLine("Введите оценки учащегося (4 цифр, разделенных пробелом): "); // вывод
        string[] gradeInputs = Console.ReadLine().Split(' '); // ввод оценок. переменная = берёт строку.Разбивает через(' ')
        for (int i = 0; i < 4; i++) // проход по Grades
        {
            student.grades[i] = int.Parse(gradeInputs[i]); // Grades[i] = в инт.преобразует(из gradeInputs[i])
        }

        student.Сonclusion(); // метод вывода информации
        
        // функция изменения
        while(true)
        {
            Console.WriteLine("Хотите изменить данные?(yes, no)"); // ввод
            string answer = Console.ReadLine(); // ответ

            if (answer == "yes")
            {
                Console.WriteLine("Введите новую фамилию для студента: "); // вывод
                student.lastName = Console.ReadLine(); // ввод фамилии
                Console.WriteLine("Введите новую дату рождения учащегося (гггг-мм-дд): "); // вывод
                student.dateOfBirth = DateTime.Parse(Console.ReadLine()); // ввод даты
                Console.WriteLine("Введите новый номер группы для учащегося: "); // вывод
                student.groupNumber = int.Parse(Console.ReadLine()); // ввод группы

                student.Сonclusion(); // метод вывода информации
            }
            else
            {
                return; // возврат
            }
        }
    }
}
