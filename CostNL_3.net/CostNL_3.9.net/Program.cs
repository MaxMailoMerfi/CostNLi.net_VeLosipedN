namespace CostNL_3._9.net
{
    //9. Генерация отсортированного массива случайных чисел.
    //У тебя есть длина массива и диапазон допустимых значений(min, max).
    //Нужно сгенерировать массив отсортированный случайных чисел заданной
    //длины в заданном диапазоне.
    //Сортировку использовать нельзя =)
    //Пример:
    //Длина: 5
    //Min: 0
    //Max: 10
    //Решение: [1, 3, 4, 9, 9]
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                int length = 5, mininumRandom = 0, maxinumRandom = 10;
                int[] array = new int[length];

                array = RandomArray(array, mininumRandom, maxinumRandom);

                Console.Write("Массив: [");
                foreach (int i in array)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine("]");

                array = Result(array);

                Console.Write("Решение: [");
                foreach (int i in array)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine("]");

                Console.WriteLine("\n\nЧтобы закончить нажмите Ctrl + C");
                Console.WriteLine("Чтобы попробовать еще раз, нажмите на любую клавишу");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static int[] Result(int[] array)
        {
            int arr;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] <= array[i])
                    {
                        arr = array[i];
                        array[i] = array[j];
                        array[j] = arr;
                    }
                }
            }

            return array;
        }

        /// <summary>
        /// Рандом масива
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        static int[] RandomArray(int[] array, int mininumRandom, int maxinumRandom)
        {
            Random rand = new();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(mininumRandom, maxinumRandom);
            }

            return array;
        }
    }
}
