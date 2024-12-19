namespace CostNL_3._4.net
{
    //4. Два массива — два противника
    //Ты получил два массива одинаковой длины.
    //Твоя задача — создать третий массив, где каждый элемент равен разнице соответствующих элементов из первого и второго массивов.
    //Если разница меньше нуля, в третий массив помещается 0.
    //Пример:
    //Массив 1: [10, 20, 30]
    //Массив 2: [15, 10, 40]
    //Решение: [0, 10, 0]

    internal class Program
    {
        static void Main()
        {
            int length;
            while (true)
            {
                Console.Write("Введите длину масивов:");
                string input = Console.ReadLine();
                // Проверка на дурака
                if (!int.TryParse(input, out length))
                {
                    Console.WriteLine("Некорректный ввод");
                    Console.WriteLine("Нажмите на любую клавишу");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                break;
            }

            int[] arrayOne = new int[length];
            int[] arrayTwo = new int[length];
            int[] arrayThree = new int[length];

            Console.Write("Массив 1 : [");
            RandomArray(ref arrayOne);

            Console.Write("Массив 2 : [");
            RandomArray(ref arrayTwo);

            Console.Write("Массив 3 : [");
            for (int i = 0; i < arrayThree.Length; i++)
            {
                arrayThree[i] = arrayOne[i] - arrayTwo[i]; // ришэние
                if (arrayThree[i] < 0)
                {
                    arrayThree[i] = 0;
                }
                /*// теж можливий код
                if (arrayOne[i] > arrayTwo[i])
                {
                    arrayThree[i] = arrayOne[i] - arrayTwo[i];
                }
                else
                {
                    arrayThree[i] = 0;
                }
                */
                if (i == 0)
                {
                    Console.Write(arrayThree[i]);
                }
                else
                {
                    Console.Write(", " + arrayThree[i]);
                }
            }
            Console.WriteLine("]");
        }

        static void RandomArray(ref int[] array)
        {
            Random rnd = new();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(101);
                if (i == 0)
                {
                    Console.Write(array[i]);
                }
                else
                {
                    Console.Write(", " + array[i]);
                }
            }
            Console.WriteLine("]");
        }
    }
}
