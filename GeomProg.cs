using System;

namespace ConsoleApp2
{
    public class GeometricProgression
    {

        private double b = 1;  // Перший член прогресії
        private double q = 1;  // Знаменник прогресії

        // Індексатор для отримання i-го члена прогресії
        public double this[int i]
        {
            get
            {
                if (i < 1) throw new ArgumentOutOfRangeException("Індекс повинен бути більший або рівний 1.");
                return b * Math.Pow(q, i - 1);
            }
        }
        // Метод для обчислення суми перших n членів прогресії
        public double Sum(int n)
        {
            if (n <= 0) throw new ArgumentOutOfRangeException("Кількість членів повинна бути більшою за 0.");

            if (q == 1)
            {
                return b * n; // Якщо знаменник 1, всі члени однакові
            }

            return b * (1 - Math.Pow(q, n)) / (1 - q);
        }
        // Метод для виведення інформації про прогресію
        public void PrintProgression(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Член {i}: {this[i]}");
            }
        }

        // Метод для введення значень першого члена та знаменника
        public void Input()
        {
            Console.Write("\nВведіть перший член прогресії: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введіть знаменник прогресії: ");
            q = Convert.ToDouble(Console.ReadLine());
        }
        public void Input(double firstMember, double denominator)
        {
            b = firstMember;
            q = denominator;
        }

        // Метод для виведення першого члена та знаменника
        public void Output()
        {
            Console.WriteLine($"\nПерший член прогресії: {b}");
            Console.WriteLine($"Знаменник прогресії: {q}\n");
        }

    }
}