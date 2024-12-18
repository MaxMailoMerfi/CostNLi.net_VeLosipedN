namespace CostNL_3._2.net
{
    //2. Массив-чудо
    //Ты должен создать новый массив, в котором каждый элемент будет умножен на свое место в исходном массиве(по индексу).
    //Но есть одно исключение: если индекс элемента — это простое число, элемент умножается на два.
    //Пример: Массив: [3, 5, 2, 7, 9]
    //Решение: [0, 10, 4, 21, 36]
    //(Индексы 1 и 3 — простые, поэтому элементы на этих индексах умножаются на два.)

    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int[] arr = [], arrFinal = [];
                int quantity = 1;
                string input;

                for (int i = 0; ;) // ввод
                {
                    Console.WriteLine("Введите числа для Массив-чудо");
                    Console.WriteLine("Чтобы закончить ввод, оставьте пустую ячейку\n");
                    Console.Write("Массив: ");

                    for (int j = 0; j < arr.Length; j++)
                    {
                        Console.Write(arr[j] + " ");
                    }

                    input = Console.ReadLine();

                    //Закончить ввод
                    if (string.IsNullOrWhiteSpace(input))
                    {
                        break;
                    }

                    // Проверка на дурака
                    if (!int.TryParse(input, out _))
                    {
                        Console.WriteLine("Некорректный ввод");
                        Console.WriteLine("Нажмите на любую клавишу");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }

                    Array.Resize(ref arr, quantity); // Увеличение масива
                    Array.Resize(ref arrFinal, quantity++); // Увеличение масива

                    arr[i] = int.Parse(input);

                    if (IsPrime(i))
                    {
                        arrFinal[i] = arr[i] * 2;
                    }
                    else
                    {
                        arrFinal[i] = arr[i] * i;
                    }
                    i++;
                    Console.Clear();
                }

                Console.WriteLine("Новый массив: ");
                for (int i = 0; i < arrFinal.Length; i++)
                {
                    Console.Write(arrFinal[i] + " ");
                }

                Console.WriteLine("\n\nЧтобы попробовать еще раз, нажмите на любую клавишу");
                Console.ReadKey();
                Console.Clear();
            }

            static bool IsPrime(int n)
            {
                if (n < 1)
                    return false;

                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                        return false;
                }
                return true;
            }
        }
    }
}
