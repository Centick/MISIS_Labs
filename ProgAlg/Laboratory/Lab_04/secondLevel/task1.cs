namespace Lab_04_secondLevel
{

    static class Task1
    {
        public static void Run()
        {
            int[,] A = new int[5, 7];
            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 7; j++)
                    A[i, j] = rnd.Next(1, 20);

            for (int i = 0; i < 5; i++)
            {
                int maxIdx = 0;
                for (int j = 1; j < 7; j++)
                    if (A[i, j] > A[i, maxIdx]) maxIdx = j;

                if (maxIdx == 0)
                {
                    A[i, 1] *= 2;
                }
                else if (maxIdx == 6)
                {
                    A[i, 5] *= 2;
                }
                else
                {
                    if (A[i, maxIdx - 1] < A[i, maxIdx + 1])
                        A[i, maxIdx - 1] *= 2;
                    else
                        A[i, maxIdx + 1] *= 2;
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                    Console.Write($"{A[i, j],4}");
                Console.WriteLine();
            }
        }
    }
}