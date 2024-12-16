namespace CostNL_3._1.net
{
    //1. Задача с числовым шифром
    //У тебя есть массив целых чисел, который является шифром.Каждое число в массиве — это позиция в алфавите (от 1 до 26).
    //Твоя задача — преобразовать массив в строку, которая представляет собой слово, где каждое число соответствует букве алфавита.
    //{A B C D E F G H I J K L M N O P Q R S T U V W X Y Z}
    //
    //Пример: Массив: [8, 5, 12, 12, 15]
    //Решение: "HELLO"
    internal class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                int quantity = 1, inputNomber;
                string inputText;
                int[] arr = new int[0];
                string[] arrABC = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" }, arrText = new string[0];

                for (int i = 0; ;) // ввод
                {
                    Console.WriteLine("Введите числа для шифрования (от 1 до 26)");
                    Console.WriteLine("Чтобы закончить ввод, оставьте пустую ячейку\n");
                    Console.Write("Массив: ");
                    for (int j = 0; j < arr.Length; j++)
                    {
                        Console.Write(arr[j] + " ");
                    }

                    inputText = Console.ReadLine();

                    //Закончить ввод
                    if (string.IsNullOrWhiteSpace(inputText))
                    {
                        break;
                    }

                    // Проверка на дурака
                    if (!int.TryParse(inputText, out _) || int.Parse(inputText) < 1 || 26 > int.Parse(inputText))
                    {
                        Console.WriteLine("Некорректный ввод");
                        Console.WriteLine("Нажмите на любую клавишу");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }

                    inputNomber = int.Parse(inputText);

                    Array.Resize(ref arr, quantity++); // Увеличение масива
                    arr[i++] = inputNomber; // Назанчение номера до масива

                    Console.Clear();
                }

                for (int i = 0; i < arr.Length; i++) // шифровка и вывод
                {
                    Array.Resize(ref arrText, arr.Length);
                    arrText[i] = arrABC[arr[i] - 1];
                    Console.Write(arrText[i]);
                }

                Console.WriteLine("\n\nЧтобы попробовать еще раз, нажмите на любую клавишу");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
