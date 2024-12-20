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
            while (true)
            {
                int shift = 3;// сдвиг

                Console.Write("Ввод:     ");
                string input = Console.ReadLine();

                char[] result = input.ToCharArray();

                //Console.WriteLine("Ввод:        " + new string(result));

                int i = 0;
                foreach (char c in result)
                {
                    if (char.IsUpper(c)) // Большая буква
                    {
                        result[i] = (char)('A' + (c - 'A' + shift) % 26);
                    }
                    else if (char.IsLower(c)) // Малая буква
                    {
                        result[i] = (char)('a' + (c - 'a' + shift) % 26);
                    }
                    else if (char.IsDigit(c)) // Число
                    {
                        result[i] = (char)('0' + (c - '0' + shift) % 10);
                    }
                    else // Остальные
                    {
                        result[i] = c;
                    }
                    i++;
                }

                Console.WriteLine("Результат:" + new string(result));


                /*
                int shift = 3;// сдвиг


                int position = 0;

                string result = "ABC";

                char[] result = result.ToCharArray(), a = new char[shift];

                foreach (char c in result)
                {
                    if (shift <= position)
                    {
                        if (position > result.Length - shift - 1)
                        {
                            result[position - shift] = c;
                            result[position] = a[position - result.Length + shift];
                        }
                        else
                        {
                            result[position - shift] = c;
                        }
                    }
                    else
                    {
                        a[position] = c;
                    }

                    position++;
                    Console.Write(c + "|");
                }

                Console.Write("\n");
                Console.WriteLine(new string(result));
                foreach (char c in result)
                {
                    Console.Write(c + "|");
                }
                */



                Console.WriteLine("\n\nЧтобы попробовать еще раз, нажмите на любую клавишу");
                Console.ReadKey();
                Console.Clear();
            }



        }
    }
}
