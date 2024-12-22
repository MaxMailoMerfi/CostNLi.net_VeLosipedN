namespace CostNL_3._11.net
{
    //11. Первые N чисел Фибоначчи.
    //Нужно сгенерировать массив первых N чисел Фибоначчи.
    //Пример:
    //N: 5
    //Решение: [1, 2, 3, 5, 8]
    internal class Program
    {
        static void Main()
        {
            int N = 10;
            int[] array = new int[N];
            array[0] = 1;
            array[1] = 2;

            for (int i = 2; i < N; i++)
            {
                array[i] = array[i - 1] + array[i - 2];
            }


            Console.Write("Решение: [");
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("]");
        }
    }
}
