namespace ConsoleApp1
{
    static class Task2
    {
        public static void Run()
        {
            int n = int.Parse(Console.ReadLine());

            int minSwimTime = 10_000_000;
            int mMin = 0, mSec = 0, mMsec = 0;
            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(':');
                int min = int.Parse(values[0]);
                int sec = int.Parse(values[1]);
                int msec = int.Parse(values[2]);


                int swimTime = min * 60 * 100 + sec * 100 + msec;
                if (swimTime < minSwimTime)
                {
                    minSwimTime = swimTime;
                    mMin = min;
                    mSec = sec;
                    mMsec = msec;
                }
            }
            Console.WriteLine($"{mMin}:{mSec}:{mMsec}");
        }
    }
}
