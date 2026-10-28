using System.Xml.Schema;

namespace Lab_04_firstLevel
{
    static class Task24
    {
        public static void Run()
        {
            double[,] L = new double[6, 5];
            Random rnd = new Random();
            
            for (int i = 0; i < 6; i++){
                for (int j = 0; j < 5; j++){
                    L[i, j] = rnd.Next(-50, 50);
                }
            }          
            
            for (int i = 0; i < 6; i++) {
                
                int maxIdx = 0;
                for (int j = 0; j < 5; j++) {
                    if (L[i, j] > L[i, maxIdx]) {
                        maxIdx = j;
                    }
                }

                int n = 0;
                double sm = 0;
                for (int j = maxIdx + 1; j < 5; j++) {
                    if (L[i, j] > 0) {
                        sm += L[i, j];
                        n++;
                    }
                }

                double sred = 0;
                if (sm != 0) sred = sm / n;
                for (int j = 0; j < maxIdx; j++) {
                    if (L[i, j] < 0) {
                        L[i, j] = sred;
                    }
                }
            }

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{L[i, j], 6}");
                }
                Console.WriteLine();
            }
        }
   }
}
