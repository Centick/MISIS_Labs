namespace Lab_04_therdLevel
{

    static class Task9
    {
        public static void Run()
        {
                int rows = 5;
            int cols = 7;
            int[,] A = new int[rows, cols];
            Random rnd = new Random();

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    A[i, j] = rnd.Next(-10, 11);

            int[] counts = new int[cols];
            for (int j = 0; j < cols; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    if (A[i, j] < 0)
                        counts[j]++;
                }
            }

            for (int i = 0; i < cols - 1; i++)
            {
                for (int k = 0; k < cols - 1 - i; k++)
                {
                    if (counts[k] > counts[k + 1])
                    {
                        int tempCount = counts[k];
                        counts[k] = counts[k + 1];
                        counts[k + 1] = tempCount;

                        for (int r = 0; r < rows; r++)
                        {
                            int tempVal = A[r, k];
                            A[r, k] = A[r, k + 1];
                            A[r, k + 1] = tempVal;
                        }
                    }
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                    Console.Write($"{A[i, j],4}");
                Console.WriteLine();
            }

            Console.Write("---------");
            for (int j = 0; j < cols; j++)
                Console.Write($"{counts[j],4}");
            Console.WriteLine();
        }
    }
}