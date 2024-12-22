namespace CostNL_3._10.net
{
    //10. Генерация массива случайных уникальных чисел.
    //У тебя есть длина массива и диапазон допустимых значений(min, max).
    //Нужно сгенерировать массив уникальных случайных чисел заданной длины в заданном диапазоне.
    //Пример:
    //Длина: 5
    //Min: 0
    //Max: 10
    //Решение: [9, 7, 8, 1, 4]
    internal class Program
    {
        static void Main()
        {
            int length = 5, mininumRandom = 0, maxinumRandom = 10;
            int[] array = new int[length];

            array = RandomArray(array, mininumRandom, maxinumRandom);

            Console.Write("Решение: [");
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("]");
        }

        /// <summary>
        /// Рандом масива уникальных чисел
        /// </summary>
        /// <param name="array"></param>
        /// <param name="mininumRandom"></param>
        /// <param name="maxinumRandom"></param>
        /// <returns></returns>
        static int[] RandomArray(int[] array, int mininumRandom, int maxinumRandom)
        {
            Random rand = new();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(mininumRandom, maxinumRandom);
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j] && i != j)
                    {
                        i--;
                        break;
                    }
                }
            }

            return array;
        }
    }
}
