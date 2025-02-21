namespace CostNL_4._5.net
{
    //5. Сортировка массива по частоте элементов
    //Условие:
    //Дан массив байт.Отсортируйте его так, чтобы байты с большей частотой встречались
    //раньше.Если частоты одинаковы, сортируйте по возрастанию значений.
    //Пример:
    //Исходный массив: [1, 1, 2, 4, 2, 2, 3]
    //Ответ: [2, 2, 2, 1, 1, 3, 4]
    internal class Program
    {
        static void Main()
        {
            byte[] arrayByte = new byte[256];
            byte[] arrayShort = new byte[50];
            RandomArray(ref arrayShort, 0,255);
            foreach (int i in arrayShort)
            {
                arrayByte[i]++;
            }
            SortByFrequency(ref arrayByte, arrayShort);
        }

        /// <summary>
        /// Fills an array with random numbers in the specified range
        /// </summary>
        /// <param name="array"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        public static void RandomArray(ref byte[] array, byte min, byte max)
        {
            Random rnd = new();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (byte)rnd.Next(min, max);
            }
        }


        public static void SortByFrequency(ref byte[] arrayByte, byte[] arrayShort)
        {
            byte maxByte = 0;
            byte position = 0;
            for (; position < arrayShort.Length;)
            {
                for (byte i = 0; i < arrayByte.Length - 1; i++)
                {
                    if (arrayByte[i] > arrayByte[maxByte])
                    {
                        maxByte = i;
                    }
                }
                for (byte i = 0; i < arrayByte[maxByte]; i++)
                {
                    arrayShort[position] = maxByte;
                    position++;
                }
                arrayByte[maxByte] = 0;
                if (maxByte >= 255)
                {
                    break;
                }
            }
        }
    }
}
