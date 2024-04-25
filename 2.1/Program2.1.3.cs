using System;
class program
{
    static void Main()
    {
        int[] nums = {1, 2, 3, 1}; // массив

        // проходимся по массиву
        for (int i = 0; i < nums.Length; i++)
        {
            // сравниваем элемент с последующими
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j]) // парные элеманты
                {
                    Console.WriteLine("true"); // вывод
                    return; // конец программы
                }
            }
        }
        Console.WriteLine("false"); // вывод 
    }
}
