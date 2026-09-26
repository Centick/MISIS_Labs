namespace ConsoleApp1
{
    internal class Task5
    {
        public static void Run()
        {
            Console.Write("Введите количество значений r (n): ");
            int n = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("1) Квадрат со стороной r");
                Console.WriteLine("2) Круг радиусом r");
                Console.WriteLine("3) Равносторонний треугольник со стороной r");
                Console.WriteLine("--------------------------------------");
                int choice = int.Parse(Console.ReadLine()!);

                Console.WriteLine("Введите r: ");
                double r = double.Parse(Console.ReadLine()); 
                double area = 0;

                switch (choice)
                {
                    case 1:
                        area = r * r;
                        Console.WriteLine($" --------- Площадь круга: {area:f4} ---------" );
                        break; 

                    case 2:
                        area = Math.PI * r * r; 
                        Console.WriteLine($" --------- Площадь квадрата: {area:f4} --------- ");
                        break; 

                    case 3:
                        area = (Math.Sqrt(3) / 4.0) * r * r; 
                        Console.WriteLine($" --------- Площадь равностороннего треугольника: {area:f4} --------- "); 
                        break; 

                    default:
                        Console.WriteLine("Ошибка"); 
                        return;
                }
            }
        }
    }
}