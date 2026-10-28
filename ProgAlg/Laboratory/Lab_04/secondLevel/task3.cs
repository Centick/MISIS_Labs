namespace Lab_04_secondLevel
{

    static class Task3
    {
        public static void Run()
        {
            int[,] A = new int[10, 5];
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 5; j++)
                    A[i, j] = rnd.Next(1, 20);

            for (int j = 0; j < 5; j++)
            {
                int maxRow = 0;
                for (int i = 1; i < 10; i++)
                    if (A[i, j] > A[maxRow, j]) maxRow = i;

                if (maxRow < 5)
                {
                    int sum = 0;
                    for (int i = maxRow + 1; i < 10; i++)
                        sum += A[i, j];

                    A[0, j] = sum;
                }
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                    Console.Write($"{A[i, j],5}");
                Console.WriteLine();
            }
        }
    }
}
