namespace CostNL_3._3.net
{
    //3. Поиск минимального разрыва
    //Тебе дается массив чисел.Твоя задача — найти пару соседних чисел в массиве, разница между которыми минимальна.Верни индексы этих чисел.
    //Пример: Массив: [10, 2, 5, 12, 7]
    //Решение: Индексы: [1, 2] (разница 3)

    internal class Program
    {
        static void Main()
        {
            int[] array = new int[10]; // 0 = ручний ввод, більше це кількість рандома

            if (array.Length != 0)
            {
            RandomArray(array);
            }
            else
            {
                int quantity = 1;
                for (int i = 0; ;)
                {
                    Console.Write("Массив: ");

                    for (int j = 0; j < array.Length; j++)
                    {
                        Console.Write(array[j] + " ");
                    }

                    string input = Console.ReadLine();

                    //Закончить ввод
                    if (string.IsNullOrWhiteSpace(input))
                    {
                        break;
                    }

                    // Проверка на дурака
                    if (!int.TryParse(input, out _))
                    {
                        Console.WriteLine("Некорректный ввод");
                        Console.WriteLine("Нажмите на любую клавишу");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }

                    Array.Resize(ref array, quantity++); // Увеличение масива

                    array[i++] = int.Parse(input);
                    Console.Clear() ;
                }

            }
        }



        static void RandomArray(int[] array)
        {
            Random rnd = new();

            Console.Write("Массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(21);
                Console.Write(array[i] + " ");
            }
        }
    }
}
