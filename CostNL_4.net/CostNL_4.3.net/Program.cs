using System.Globalization;
using System.Xml.Linq;

namespace CostNL_4._3.net
{
    //3. Слияние двух отсортированных массивов
    //Условие:
    //Даны два отсортированных массива.Объедините их в один отсортированный массив.
    //Сортировку использовать нельзя.
    internal class Program
    {
        static void Main()
        {
            int[] arrayOne = new int[5000];
            int[] arrayTwo = new int[5000];
            RandomArray(ref arrayOne);
            RandomArray(ref arrayTwo);
            Array.Sort(arrayOne);
            Array.Sort(arrayTwo);

            int[] arr = MergingIntoOneSortedArray(arrayOne, arrayTwo);
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

        public static int[] MergingIntoOneSortedArray(int[] arrayOne, int[] arrayTwo)
        {
            int[] combinedArray = new int[arrayOne.Length+arrayTwo.Length];

            return MergingIntoOneSortedArray(combinedArray, arrayOne, arrayTwo, 0, 0, 0);
        }

        public static int[] MergingIntoOneSortedArray(int[] combinedArray, int[] arrayOne, int[] arrayTwo, int firstElement, int secondElement, int index)
        {
            if (index >= combinedArray.Length)
            {
                return combinedArray;
            }
            if (firstElement == arrayOne.Length)
            {
                firstElement--;
            }
            if (secondElement == arrayTwo.Length)
            {
                secondElement--;
            }

            if (arrayOne[firstElement] == arrayTwo[secondElement])
            {
                if (firstElement < arrayOne.Length && index < combinedArray.Length)
                {
                    combinedArray[index++] = arrayOne[firstElement++];
                }
                if (secondElement < arrayTwo.Length && index < combinedArray.Length)
                {
                    combinedArray[index++] = arrayTwo[secondElement++];
                }
                return MergingIntoOneSortedArray(combinedArray, arrayOne, arrayTwo, firstElement, secondElement, index);
            }
            else if (arrayOne[firstElement] < arrayTwo[secondElement])
            {
                combinedArray[index++] = arrayOne[firstElement++];

                return MergingIntoOneSortedArray(combinedArray, arrayOne, arrayTwo, firstElement, secondElement, index);
            }
            else /*if (arrayOne[firstElement] > arrayTwo[secondElement])*/
            {
                combinedArray[index++] = arrayTwo[secondElement++];
                return MergingIntoOneSortedArray(combinedArray, arrayOne, arrayTwo, firstElement, secondElement, index);
            }
        }
    }
}
