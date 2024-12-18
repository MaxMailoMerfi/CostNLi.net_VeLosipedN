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
            while (true)
            {
                int quantity = 1, inputNomber, i = 0;
                string inputText;
                int[] arr = new int[0];
                string[] arrABC = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

                while (true) // ввод
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
                    if (!int.TryParse(inputText, out inputNomber) || (int.Parse(inputText) < 1 && int.Parse(inputText) > 26))
                    {
                        Console.WriteLine("Некорректный ввод");
                        Console.WriteLine("Нажмите на любую клавишу");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }

                    Array.Resize(ref arr, quantity++); // Увеличение масива
                    arr[i++] = inputNomber; // Назанчение номера до масива

                    Console.Clear();
                }

                for (int j = 0; j < arr.Length; j++) // шифровка и вывод
                {
                    Console.Write(arrABC[arr[j] - 1]);
                }

                Console.WriteLine("\n\nЧтобы попробовать еще раз, нажмите на любую клавишу");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
