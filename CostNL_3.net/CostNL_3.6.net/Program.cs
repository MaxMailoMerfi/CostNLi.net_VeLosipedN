namespace CostNL_3._6.net
{
    //6. Массив как карта высот
    //У тебя есть массив чисел, представляющий высоты.Твоя задача — найти все "пики".
    //Пик — это элемент, который больше обоих своих соседей.
    //Пример:
    //Массив: [1, 3, 2, 4, 1, 5]
    //Решение: [3, 4, 5]

    internal class Program
    {
        static void Main()
        {
            string input = "12349457765434"; // Цыфри высот
            char[] peakArray = PeakArray(input);
            Console.WriteLine(new string(peakArray));
        }

        static char[] PeakArray(string input)
        {
            char[] peakArray = input.ToCharArray();
            Console.WriteLine(new string(peakArray));
            char[] result = [];
            int i = 0, j = 0;

            foreach (char c in peakArray)
            {
                if (i > 0 && i < peakArray.Length-1 && peakArray[i - 1] <= c && c >= peakArray[i + 1])
                {
                    result = new char[j + 1];
                    j++;
                }
                else if (i<0 && c >= peakArray[i+1])
                {
                    result = new char[j + 1];
                    j++;
                }
                else if (i >= peakArray.Length - 1 && i < peakArray.Length && peakArray[i - 1] <= c)
                {
                    result = new char[j + 1];
                    j++;
                }
                i++;
            }
            i = 0; j = 0;

            foreach (char c in peakArray)
            {
                if (i > 0 && i < peakArray.Length - 1 && peakArray[i - 1] <= c && c >= peakArray[i + 1])
                {
                    result[j++] = c;
                }
                else if (i < 0 && c >= peakArray[i + 1])
                {
                    result[j++] = c;
                }
                else if (i >= peakArray.Length - 1 && i < peakArray.Length && peakArray[i - 1] <= c)
                {
                    result[j++] = c;
                }
                i++;
            }

            return result;
        }
    }
}
