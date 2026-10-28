namespace Lab_04_therdLevel
{

    static class Task7
    {
        public static void Run()
        {
            int n = 3;
            int triSize = n * (n + 1) / 2;

            int[] A = new int[triSize];
            int[] B = new int[triSize];
            Random rnd = new Random();

            for (int i = 0; i < triSize; i++)
            {
                A[i] = rnd.Next(1, 10);
                B[i] = rnd.Next(1, 10);
            }

            int[,] matA = new int[n, n];
            int[,] matB = new int[n, n];

            int idx = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    matA[i, j] = A[idx];
                    matA[j, i] = A[idx];

                    matB[i, j] = B[idx];
                    matB[j, i] = B[idx];

                    idx++;
                }
            }

            int[] C = new int[n * n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < n; k++)
                    {
                        sum += matA[i, k] * matB[k, j];
                    }
                    C[i * n + j] = sum;
                }
            }

            Console.WriteLine("A:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write($"{matA[i, j],5}");
                Console.WriteLine();
            }

            Console.WriteLine("\nB:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write($"{matB[i, j],5}");
                Console.WriteLine();
            }

            Console.WriteLine("\nC:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write($"{C[i * n + j],5}");
                Console.WriteLine();
            }
        }
    }
}