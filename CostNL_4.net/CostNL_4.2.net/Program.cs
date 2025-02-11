namespace CostNL_4._2.net
{
    //2. Поиск числа, которое встречается чаще всего
    //Условие:
    //Дан массив байтов.Найдите байт, который встречается чаще всего, и верните его.
    //Если таких байт несколько, верните минимальный из них.
    internal class Program
    {
        static void Main()
        {
            int[] array = new int[10000];
            RandomArray(ref array);
            Array.Sort(array);
            int bait = HighArray(array);
            Console.WriteLine($"Bait: " + bait);
        }


        /// <summary>
        /// Takes an array and makes it random (0 - 1000)
        /// </summary>
        /// <param name="array"></param>
        /// <returns>Random array of numbers</returns>
        public static void RandomArray(ref int[] array)
        {
            Random rnd = new();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 1001);
            }
        }

        public static int HighArray(int[] array)
        {
            int index = 0, length = 1, highBait = 0, highLength = 0;

            return HighArray(array, index, length, highBait, highLength);
        }

        public static int HighArray(int[] array, int index, int length, int highBait, int highLength)
        {
            if (index == array.Length - 1)
            {
                Console.WriteLine($"Length: " + highLength);
                return highBait;
            }
            if (array[index] == array[index + 1])
            {
                return HighArray(array, index + 1, length + 1, highBait, highLength);
            }
            else
            {
                if (!(length == highLength && array[index] < highBait))
                {
                    if (length > highLength)
                    {
                        highLength = length;
                        highBait = array[index];
                    }
                }
                return HighArray(array, index + 1, 1, highBait, highLength);
            }
        }
    }
}
