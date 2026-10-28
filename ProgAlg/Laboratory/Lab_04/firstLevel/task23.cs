namespace Lab_04_firstLevel
{
    static class Task23
    {
        public static void Run()
        {
            int[,] G = new int[5, 7];
            Random rnd = new Random();

            for (int i = 0; i < 5; i++){
                for (int j = 0; j < 6; j++){
                    G[i, j] = rnd.Next(10, 100);
                }
            }

            
            for (int i = 0; i < 5; i++)
            {   
                int maxIdx = 0;
                for (int j = 1; j < 6; j++){
                    if (G[i, j] > G[i, maxIdx])
                    {
                        maxIdx = j;
                    }
                }

                for (int j = 6; j > maxIdx + 1; j--)
                {
                   G[i, j] = G[i, j - 1]; 
                }
                    

                G[i, maxIdx + 1] = G[i, maxIdx];
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                    Console.Write($"{G[i, j],4}");
                Console.WriteLine();
            }
        }
   }
}
