namespace CostNL_4._1.net
{
    //1. Jump Search
    //Условие:
    //Реализовать алгоритм Jump Search.
    internal class Program
    {
        static void Main()
        {
            int value = 123;
            Console.WriteLine($"Looking for a number: " + value);
            int indexValue;
            int[] array = new int[100000000];

            RandomArray(ref array);
            Array.Sort(array);

            indexValue = JumpSearch(array, value);

            //Checking for the existence of a number
            if (indexValue < 0)
            {
                Console.WriteLine("Unfortunately, such a number does not exist.");
            }
            else
            {
                Console.WriteLine($"Index: " + indexValue);
                Console.WriteLine($"Number: " + array[indexValue]);
            }
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

        /// <summary>
        /// Jump search searches only in the sorted array, with some step checking when it is greater than the search number.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="value"></param>
        /// <returns>The index under which the number is located</returns>
        public static int JumpSearch(int[] array, int value)
        {
            int step = array.Length / 20;

            for (int i = step; i < array.Length;)
            {
                if (array[i] == value)
                {
                    return i;
                }
                else if (array[i] > value)
                {
                    return BinarySearch(array, i - step, i, value);
                }
                else if (array[i] < value)
                {
                    i += step;
                }
            }
            return -1;
        }

        /// <summary>
        /// Binary Search - a search that takes the middle of the range and equals whether it is greater or less than the searched number and takes the part that matches and checks again
        /// </summary>
        /// <param name="array"></param>
        /// <param name="startIndex"></param>
        /// <param name="endIndex"></param>
        /// <param name="velue"></param>
        /// <returns>The index under which the number is located</returns>
        static int BinarySearch(int[] array, int startIndex, int endIndex, int velue)
        {
            int step = (endIndex - startIndex) / 2;
            //Console.WriteLine();
            //Console.WriteLine(step + startIndex);
            //Console.WriteLine(array[step + startIndex]);

            if (array[step + startIndex] == velue)
            {
                return (step + startIndex);
            }
            else if (array[step + startIndex] < velue)
            {
                return BinarySearch(array, startIndex + step, endIndex, velue);
            }
            else if (array[step + startIndex] > velue)
            {
                return BinarySearch(array, startIndex, endIndex - step, velue);
            }
            else
            {
                return -1;
            }
        }
    }
}
