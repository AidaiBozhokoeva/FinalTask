using System;

class Program
{
    static void Main()
    {
        // Ввод массива строк. Можно ввести с клавиатуры или задать на старте.
        string[] inputArray = { "Hello", "2", "world", ":-)" }; // Пример заданного массива

        // Подсчитываем, сколько элементов удовлетворяют условию, чтобы знать размер нового массива.
        int validCount = 0;
        foreach (var item in inputArray)
        {
            if (item.Length <= 3)
            {
                validCount++;
            }
        }

        // Инициализация нового массива строк нужного размера.
        string[] resultArray = new string[validCount];

        // Заполнение нового массива.
        int index = 0; // Индекс для нового массива
        foreach (var item in inputArray)
        {
            if (item.Length <= 3)
            {
                resultArray[index++] = item;
            }
        }

        // Вывод нового массива.
        Console.WriteLine("[" + string.Join(", ", resultArray) + "]");
    }
}
