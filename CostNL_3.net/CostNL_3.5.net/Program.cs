namespace CostNL_3._5.net
{
    //5. Массив для шифра Цезаря
    //У тебя есть массив символов(тип char), которые представляют текст.
    //Твоя задача — сдвинуть каждый символ массива на заданное число позиций в алфавите.Если это цифры, сдвиг должен циклически менять их значение.
    //Пример:
    //Вход: ['A', 'B', 'C'], Сдвиг: 3
    //Решение: ['D', 'E', 'F']

    internal class Program
    {
        static void Main()
        {
            int shift = 3, i = 0;

            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] input = alphabet.ToCharArray();

            foreach (char c in input)
            {
                Console.Write(c + "|");
            }
            Console.Write("\n\n | | |");
            foreach (char c in input)
            {
                if (shift <= i || shift > input.Length - shift)
                {
                    input[i - shift] = c;
                }
                else
                {
                    input[input.Length - shift + i] = c;
                }
                i++;
            }

            foreach (char c in input)
            {
                Console.Write(c + "|");
            }
        }
    }
}
