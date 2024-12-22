namespace CostNL_3._8.net
{
    //8. Сумма двух элементов
    //Дан отсортированный массив целых чисел и число Х.
    //Надо проверить есть ли в массиве 2 элемента, которые в сумме дают Х.
    //Если такие элементы есть вернуть их индексы в виде массива.
    //Если таких элементов несколько вернуть индексы любых удовлетворяющих условие.
    //Пример:
    //Х: 11
    //Массив: [1, 2, 4, 7, 9, 11]
    //Решение: [1, 4]
    internal class Program
    {
        static void Main()
        {
            int[] array = new int[10];
            int[] result = [-1, -1];
            array = RandomArray(array);
            Array.Sort(array);

            Console.Write("Массив: [");
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("]");

            int input = ConsoleRead();
            result = Result(array, input, result);

            Console.Write("Решение: [");
            foreach (int i in result)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("]");
        }

        /// <summary>
        /// Ввод з консолі, перевірка на int і більше за 0
        /// </summary>
        /// <returns></returns>
        static int ConsoleRead()
        {
            string console;

            console = Console.ReadLine();

            if (!double.TryParse(console, out _))
            {
                Console.Clear();
                Console.WriteLine("Некорректный ввод");
                Console.WriteLine("Нажмите на любую клавишу");
                Console.ReadKey();
                Console.Clear();

                Main();
            }
            int input = int.Parse(console);

            if (input < 0)
            {
                Main();
            }

            return input;
        }

        /// <summary>
        /// Бере отсортований масив визначаючи першу пару яка в сумі буде заданому числу і записує індекси в результат
        /// </summary>
        /// <param name="array"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        static int[] Result(int[] array, int input, int[] result)
        {

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == input)
                    {
                        result[0] = i;
                        result[1] = j;
                        return result;
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// Рандом масива який визначає сам розмір
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        static int[] RandomArray(int[] array)
        {
            Random rand = new();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1, 11);
            }

            return array;
        }
    }
}

