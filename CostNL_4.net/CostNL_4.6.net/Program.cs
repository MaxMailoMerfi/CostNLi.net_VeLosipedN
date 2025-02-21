namespace CostNL_4._6.net
{
    //6. Максимальное количество последовательных единиц с одним изменением
    //Условие:
    //Дан массив, содержащий только 0 и 1. Найдите максимальное количество
    //последовательных единиц, если вы можете изменить ровно один 0 на 1.
    //Исходный массив: [1, 1, 0, 1, 0, 1, 1, 1]
    //Ответ: 5 (индексы с 3 по 7)
    internal class Program
    {
        static void Main()
        {
            int[] array = [1, 1, 1, 0, 1, 0, 1, 1, 1, 1, 1, 1];
            int[] arrayOfZeroIndices = SearchForZerosInAnArray(array);
            int numberOfUnits = NumberOfConsecutiveUnits(array);

            SearchForTheMaximumNumberOfUnits(ref array, arrayOfZeroIndices, numberOfUnits);
        }

        /// <summary>
        /// Finds all indices of zeros
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] SearchForZerosInAnArray(int[] array)
        {
            int[] arrayOfZeroIndices = [0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    Array.Resize(ref arrayOfZeroIndices, arrayOfZeroIndices.Length + 1);
                    arrayOfZeroIndices[^1] = i;
                }
            }
            Array.Resize(ref arrayOfZeroIndices, arrayOfZeroIndices.Length + 1);
            arrayOfZeroIndices[^1] = array.Length - 1;
            return arrayOfZeroIndices;
        }


        public static int NumberOfConsecutiveUnits(int[] array)
        {
            int numberOfUnits = 0;
            int numberMax = 0;
            for (int i = 0; i <= array.Length; i++)
            {
                if (i == array.Length || array[i] == 0)
                {
                    if (numberOfUnits < numberMax)
                    {
                        numberOfUnits = numberMax;
                    }
                    numberMax = 0;
                }
                else
                {
                    numberMax++;
                }
            }
            return numberOfUnits;
        }


        public static void SearchForTheMaximumNumberOfUnits(ref int[] array, int[] arrayOfZeroIndices, int numberOfUnits)
        {
            int[] timeArray;
            int[] maxArray = array;
            int start = 0;
            int end = 0;
            for (int i = 1; i < arrayOfZeroIndices.Length; i++)
            {
                timeArray = (int[])array.Clone();
                timeArray[arrayOfZeroIndices[i]] = 1;
                int after = NumberOfConsecutiveUnits(timeArray);
                if (numberOfUnits < after)
                {
                    maxArray = timeArray;
                    numberOfUnits = after;
                    start = arrayOfZeroIndices[i - 1] + 1;
                    if (arrayOfZeroIndices[i + 1] == maxArray.Length - 1)
                    {
                        end = arrayOfZeroIndices[i + 1];
                    }
                    else
                    {
                        end = arrayOfZeroIndices[i + 1] - 1;
                    }
                }
            }
            array = maxArray;

            Console.WriteLine($"Response " + numberOfUnits + " (indices from " + start + " to " + end + ")");
        }
    }
}