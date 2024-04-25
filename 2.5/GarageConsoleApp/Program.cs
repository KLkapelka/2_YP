using System.Runtime.InteropServices;
// РАБОТАЕТ:
// 1, 2

// НЕ РАБОТАЕТ:
// 3 - Добавление машин - 2

namespace GarageConsoleApp;

/// <summary>
/// Класс Program
/// здесь описываем логику приложения
/// вызываем нужные методы пишем обработчики и тд
/// </summary>
public class Program 
{
    // public static void Main(string[] args)
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nВыход - 0 \nФункционал: \n-типов машин - 1 \n-водителей и их прав - 2 \n-машин - 3"+
                              "\n-маршрутов - 4 \n-рейсов - 5"); // вывод
            int task = int.Parse(Console.ReadLine()); // данные
            
            if (task == 0)
            {
                break; // Выход из цикла
            }

            switch (task)
            {
                case 1: // просмотр и добавление типов машин
                    Console.WriteLine("\nПросмотр типов машин - 1 \nДобавление типов машин - 2"); // вывод
                    int task_1 = int.Parse(Console.ReadLine()); // данные
                    switch (task_1)
                    {
                        case 1:
                            DatabaseRequests.GetTypeCarQuery(); // метод просмотра
                            break; 
                        case 2:
                            Console.Write("Введите тип машины: "); // вывод
                            string typeCar = Console.ReadLine(); // данные
                            DatabaseRequests.AddTypeCarQuery(typeCar); // метод заполнения
                            DatabaseRequests.GetTypeCarQuery(); // метод просмотра
                            break;
                        default:
                            Console.WriteLine("Возвра на главную");
                            break;
                    }
                    break;
                case 2: // просмотр и добавление водителей и их прав
                    Console.WriteLine("\n-Добавления водителя - 1 \n-Список водителей - 2 \n-Добавление категорий прав - 3"+
                                      "\n-Добавление категорий прав водителей - 4 \n-Категория прав водителей - 5");
                    int task_2 = int.Parse(Console.ReadLine()); 
                    switch (task_2)
                    {
                        case 1: // добавления водителя
                            Console.Write("Имя водителя: ");
                            string firstName = Console.ReadLine();
                            
                            Console.Write("Фамилия водителя: ");
                            string lastName = Console.ReadLine();
                            
                            Console.Write("Дата водителя(ММ/ДД/ГГГГ): ");
                            DateTime birthdate =  DateTime.Parse(Console.ReadLine()); // ММ/ДД/ГГГГ
                            DatabaseRequests.AddDriverQuery(firstName, lastName, birthdate);
                            break;
                        case 2: // список водителей
                            DatabaseRequests.GetDriverQuery();
                            break;
                        case 3: // добавление категорий прав
                            Console.Write("Категория прав: "); 
                            string name = Console.ReadLine();  
                            DatabaseRequests.AddRightsCategoryQuery(name);
                            break;
                        case 4: // добавление категорий прав водителей
                            DatabaseRequests.GetDriverQuery(); // список водителей
                            
                            Console.Write("Введите номер водителя: ");
                            int driver = int.Parse(Console.ReadLine());
                            DatabaseRequests.GetDriverRightsCategoryQuery(driver); // категория прав водителей

                            Console.Write("Введите номер категории прав: ");
                            int rightsCategory = int.Parse(Console.ReadLine());
                            DatabaseRequests.AddDriverRightsCategoryQuery(driver, rightsCategory);
                            break;
                        case 5:
                            DatabaseRequests.GetDriverQuery(); // список водителей
                            Console.Write("Введите номер водителя: ");
                            int driver_2 = int.Parse(Console.ReadLine());
                            DatabaseRequests.GetDriverRightsCategoryQuery(driver_2); // категория прав водителей
                            break;
                        default:
                            Console.WriteLine("Возвра на главную");
                            break;
                    }
                    break;
                case 3: // просмотр и добавления машин
                    Console.WriteLine("\nПросмотр машин - 1 \nДобавление машин - 2"); 
                    int task_3 = int.Parse(Console.ReadLine()); 
                    switch (task_3)
                    {
                        case 1:
                            DatabaseRequests.GetCarQuery(); // метод просмотра
                            break; // string name, string stateNumber, int numberPassengers
                        case 2: 
                            DatabaseRequests.GetTypeCarQuery(); // просмотр тип маины
                            Console.Write("Введите id типа машины: "); 
                            int idTypeCar = int.Parse(Console.ReadLine()); 
                            
                            Console.Write("Введите название машины: "); 
                            string name = Console.ReadLine(); 
                            
                            Console.Write("Введите номер: "); 
                            string stateNumber = Console.ReadLine(); 
                            
                            Console.Write("Введите кол-во пассажиров: "); 
                            int numberPassengers = int.Parse(Console.ReadLine());
                            
                            DatabaseRequests.AddCarQuery(idTypeCar, name, stateNumber, numberPassengers); // метод заполнения
                            DatabaseRequests.GetCarQuery(); // метод просмотра
                            break;
                        default:
                            Console.WriteLine("Возвра на главную");
                            break;
                    }
                    break;
                case 4: // Просмотр и добавление маршрутов
                    Console.WriteLine("\nПросмотр маршрутов - 1 \nДобавление маршрутов - 2"); 
                    int task_4 = int.Parse(Console.ReadLine()); 
                    switch (task_4)
                    {
                        case 1:
                            DatabaseRequests.GetItinerary();
                            break;
                        case 2:
                            Console.Write("Введите рейс: (от-до): "); // москва-томск
                            string name = Console.ReadLine();  
                            DatabaseRequests.AddItinerary(name);
                            break;
                        default:
                            Console.WriteLine("Возвра на главную");
                            break;
                    }
                    break;
                case 5: // Просмотр и добавление рейсов
                    Console.WriteLine("\nПросмотр рейсов - 1 \nДобавление рейсов - 2"); 
                    int task_5 = int.Parse(Console.ReadLine()); 
                    switch (task_5)
                    {
                        case 1:
                            DatabaseRequests.GetRoute();
                            break;
                        case 2: // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! не работать
                            // авйди водителя
                            DatabaseRequests.GetDriverQuery(); // список водителей
                            Console.Write("Введите id водителя: "); 
                            int idDriver = int.Parse(Console.ReadLine()); 

                            // айди машины
                            DatabaseRequests.GetCarQuery(); // список машин
                            Console.Write("Введите id машины: "); 
                            int idCar = int.Parse(Console.ReadLine()); 

                            // айди маршрута
                            DatabaseRequests.GetItinerary(); // список маршрутов
                            Console.Write("Введите id маршрута: "); 
                            int idItinerary = int.Parse(Console.ReadLine()); 

                            // число пассажиорв
                            Console.Write("Введите кол-во пассажиров: ");
                            int numberPassengers = int.Parse(Console.ReadLine()); 

                            DatabaseRequests.AddRoute(idDriver, idCar, idItinerary, numberPassengers);
                            break;
                        default:
                            Console.WriteLine("Возвра на главную");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Неверный ввод");
                    break;
            }
        }
    }
}