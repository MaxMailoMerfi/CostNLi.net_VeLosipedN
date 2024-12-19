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
            while (true)
            {
                int[] array = new int[11]; // 0 = ручний ввод, більше це кількість рандома
                int minimalDifference = 0, minimalNumberDifference = 0;

                if (array.Length != 0)
                {
                    RandomArray(ref array);
                }
                else
                {
                    int quantity = 1;
                    for (int i = 0; ;)
                    {
                        Console.Write("Массив: [");

                        for (int j = 0; j < array.Length; j++)
                        {
                            Console.Write(array[j] + ", ");
                        }

                        string input = Console.ReadLine();

                        //Закончить ввод
                        if (string.IsNullOrWhiteSpace(input))
                        {
                            Console.WriteLine("]");
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
                        Console.Clear();
                    }
                }

                for (int i = 1; i < array.Length; i++) // перебор всего масива
                {
                    if (i == 1) // начальные значения
                    {
                        minimalDifference = i;
                        minimalNumberDifference = array[i - 1] - array[i];

                        if (minimalNumberDifference < 0)
                        {
                            minimalNumberDifference *= -1;
                        }
                    }
                    else
                    {
                        if ((array[i - 1] - array[i]) < minimalNumberDifference)
                        {
                            if ((array[i - 1] - array[i] < 0) && ((array[i - 1] - array[i]) * (-1) < minimalNumberDifference))
                            {
                                minimalDifference = i;
                                minimalNumberDifference = (array[i - 1] - array[i]) * (-1);
                            }

                            else if ((array[i - 1] - array[i]) * (-1) < minimalNumberDifference)
                            {
                                minimalDifference = i;
                                minimalNumberDifference = array[i - 1] - array[i];
                            }
                        }
                    }
                }

                Console.Write("Минимальна разница между [" + (minimalDifference - 1) + ", " + (minimalDifference) + "] ");
                Console.WriteLine("(разница " + (array[minimalDifference - 1] - array[minimalDifference]) + ")");

                Console.WriteLine("\n\nЧтобы попробовать еще раз, нажмите на любую клавишу");
                Console.ReadKey();
                Console.Clear();
                continue;
            }
        }



        static void RandomArray(ref int[] array)
        {
            Random rnd = new();

            Console.Write("Массив : [");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(11);
                if (i == 0)
                {
                    Console.Write(array[i]);
                }
                else
                {
                    Console.Write(", " + array[i]);
                }
            }
            Console.WriteLine("]");
        }
    }
}
