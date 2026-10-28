using System.Xml.Schema;

namespace Lab_04_firstLevel
{
    static class Task24
    {
        public static void Run()
        {
            int[,] X = new int[6, 5];
            Random rnd = new Random();

            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 5; j++)
                    X[i, j] = rnd.Next(-50, 10);

            int minRow = 0, maxRow = 0;
            int minCount = int.MaxValue;
            int maxCount = int.MinValue;

            for (int i = 0; i < 6; i++)
            {
                int negCount = 0;
                for (int j = 0; j < 5; j++)
                {
                    if (X[i, j] < 0)
                        negCount++;
                }

                if (negCount < minCount)
                {
                    minCount = negCount;
                    minRow = i;
                }

                if (negCount > maxCount)
                {
                    maxCount = negCount;
                    maxRow = i;
                }
            }

            if (minRow != maxRow)
            {
                for (int j = 0; j < 5; j++)
                {
                    int temp = X[minRow, j];
                    X[minRow, j] = X[maxRow, j];
                    X[maxRow, j] = temp;
                }
            }

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 5; j++)
                    Console.Write($"{X[i, j],4}");
                Console.WriteLine();
            }
        }
   }
}
