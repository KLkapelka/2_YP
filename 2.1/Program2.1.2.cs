public class Solution
{
    // данные + вывод
    static void Main()
    {
        int[] candidates = { 2, 5, 2, 1, 2 }; // масиив
        int target = 5; // цель
        Solution solution = new Solution(); // ссылка

        IList<IList<int>> combinations = solution.CombinationSum(candidates, target); // вызов метода передав массив с число и возвращает список комбинаций

        Console.WriteLine($"Комбинации по: {target}:"); // вывод
        foreach (var i in combinations) // проходится по комбнациям
        {
            Console.WriteLine(string.Join(", ", i)); // вывод. string.Join - оьбъеденения эллементов с разделителем
        }
    }

    // все конминации
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        IList<IList<int>> result = new List<IList<int>>(); // список комбинаций
        Array.Sort(candidates); // сортировка массива
        Backtrack(result, new List<int>(), candidates, target, 0); // метод(список, лист, массив, цель, 0)
        return result; // возврат
    }

    // поиск комбинаций
    private void Backtrack(IList<IList<int>> result, List<int> tempList, int[] candidates, int targetCopy, int start) // target = targetCopy чтоюы не изменять target
    {
        if (targetCopy < 0)
        {
            return; // возврат
        }

        else if (targetCopy == 0) // если сумма комбинаций = targetCopy
        {
            result.Add(new List<int>(tempList)); // записываем компинацию. в result.добавить(лист tempList)
        }

        else // если сумма комбинаций < targetCopy
        {
            for (int i = start; i < candidates.Length; i++) // проходимся по массиву
            {
                if (i > start && candidates[i] == candidates[i - 1]) // пропуск дубликатов. i > 0 и эллемент == пердыдущий эллемент
                {
                    continue;  // пропуск
                }
                tempList.Add(candidates[i]); // добавляем эллемент в комбинацию. tempList.добавить(число i)
                Backtrack(result, tempList, candidates, targetCopy - candidates[i], start + 1); // рекурсия. Метод(список, лист, массив, число - число i, start + 1)
                tempList.RemoveAt(tempList.Count - 1); // удаление последнего числа из списка
            }
        }
    }
} 
