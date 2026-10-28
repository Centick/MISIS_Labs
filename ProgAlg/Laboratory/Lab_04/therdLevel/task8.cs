namespace Lab_04_therdLevel
{

    static class Task8
    {
        public static void Run()
        {
            int rows = 7;
            int cols = 5;
            int[,] A = new int[rows, cols];
            Random rnd = new Random();

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    A[i, j] = rnd.Next(-10, 11);

            int[] counts = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (A[i, j] > 0)
                        counts[i]++;
                }
            }

            for (int i = 0; i < rows - 1; i++)
            {
                for (int k = 0; k < rows - 1 - i; k++)
                {
                    if (counts[k] < counts[k + 1])
                    {
                        int tempCount = counts[k];
                        counts[k] = counts[k + 1];
                        counts[k + 1] = tempCount;

                        for (int j = 0; j < cols; j++)
                        {
                            int tempVal = A[k, j];
                            A[k, j] = A[k + 1, j];
                            A[k + 1, j] = tempVal;
                        }
                    }
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                    Console.Write($"{A[i, j],4}");
                Console.WriteLine($"  | положительных: {counts[i]}");
            }
        }
    }
}