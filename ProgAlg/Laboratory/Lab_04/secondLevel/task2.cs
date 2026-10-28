namespace Lab_04_secondLevel
{

    static class Task2
    {
        public static void Run()
        {
            const int rows = 7;
            const int cols = 5;
            double[,] A = new double[rows, cols];
            Random rnd = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    A[i, j] = rnd.Next(-30, 30);
                }
            }

            for (int j = 0; j < cols; j++)
            {
                int maxRow = 0;
                int posCount = 0;
                int negCount = 0;

                for (int i = 0; i < rows; i++)
                {
                    if (A[i, j] > A[maxRow, j])
                    {
                        maxRow = i;
                    }

                    if (A[i, j] > 0) posCount++;
                    else if (A[i, j] < 0) negCount++;
                }

                if (posCount > negCount)
                {
                    A[maxRow, j] = 0;
                }
                else
                {
                    A[maxRow, j] = maxRow + 1;
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{A[i, j],6:F0}");
                }
                Console.WriteLine();
            }
        }
    }
}