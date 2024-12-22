namespace CostNL_3._7.net
{
    //7. Удалить элемент массива по индексу
    //У тебя есть массив чисел и индекс элемента, который нужно удалить.
    //Пример:
    //Индекс: 2
    //Массив: [1, 3, 2, 4, 1, 5]
    //Решение: [1, 3, 4, 1, 5]
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                //1
                //int[] array = {1,2,3,4,5,5,7,8,3,2};

                //2
                int[] array = new int[10]; 
                array = RandomArray(array);


                Console.Write("Основной масив: ");
                foreach (int i in array)
                {
                    Console.Write(i + " ");
                }
                string text = "\nВведите какой елемент удалить (0 - максимума): ";

                
                int input = int.Parse(ConsoleRead(text));

                if (input < 0)
                {
                    Console.Clear();
                    Console.WriteLine("Некорректный ввод");
                    Console.WriteLine("Нажмите на любую клавишу");
                    Console.ReadKey();
                    Console.Clear();

                    continue;
                }


                int[] result = Result(array, input);
                Console.Clear();
                foreach (int i in array)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
                foreach (var i in result)
                {
                    Console.Write(i + " ");
                }

                Console.WriteLine("\n\nЧтобы закончить нажмите Ctrl + C");
                Console.WriteLine("Чтобы попробовать еще раз, нажмите на любую клавишу");
                Console.ReadKey();
                Console.Clear();
            }


            static string ConsoleRead(string text)
            {
                string console;

                Console.Write(text);
                console = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(console))
                {
                    Console.Clear();
                }

                if (!double.TryParse(console, out _))
                {
                    Console.Clear();
                    Console.WriteLine("Некорректный ввод");
                    Console.WriteLine("Нажмите на любую клавишу");
                    Console.ReadKey();
                    Console.Clear();

                    Main();
                }

                return console;
            }


            static int[] Result(int[] array, int input)
            {
                int[] result = new int[array.Length];

                if (input < array.Length)
                {
                    result = new int[array.Length - 1];
                }

                for (int i = 0; i < result.Length; i++)
                {
                    if (i >= input && input < array.Length)
                    {
                        result[i] = array[i + 1];
                    }
                    else
                    {
                        result[i] = array[i];
                    }
                }

                return result;
            }


            static int[] RandomArray(int[] array)
            {
                Random rand = new();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rand.Next(101);
                }

                return array;
            }
        }
    }
}
