namespace CostNL_4._4.net
{
    //4. Проверка на монотонность
    //Условие:
    //Определите, является ли массив монотонным(всегда возрастает или всегда убывает).
    //Оба условия проверить за один(!) проход.
    internal class Program
    {
        static void Main()
        {
            int[] array = new int[6];
            RandomArray(ref array, 0, 10);
            //Array.Sort(array);
            if (ArrayIsMonotone(array))
            {
                Console.WriteLine("Array is monotonous");
            }
            else
            {
                Console.WriteLine("Array is no monotonous");
            }
        }

        /// <summary>
        /// Fills an array with random numbers in the specified range
        /// </summary>
        /// <param name="array"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        public static void RandomArray(ref int[] array, int min, int max)
        {
            Random rnd = new();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(min, max + 1);
            }
        }

        /// <summary>
        /// Checking for monotonicity of the array
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static bool ArrayIsMonotone(int[] array)
        {
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array.Length == i)
                {
                }
                if (array[i - 1] < array[i])
                {
                    if (array[i] < array[i + 1])
                    {
                        i++;
                    }
                    else
                    {
                        return false;
                    }
                }
                if (array[i - 1] > array[i])
                {
                    if (array[i] > array[i + 1])
                    {
                        i++;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
