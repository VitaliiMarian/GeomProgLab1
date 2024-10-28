using System;
using System.Reflection;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Створення об'єкта прогресії 
            GeometricProgression gp = new GeometricProgression();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Натисніть " + "Enter" + ", щоб ввести початкові данні для геометричної прогресії...\n");
            Console.ResetColor();

            while (Console.ReadKey(true).Key != ConsoleKey.Enter)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Натисніть саме Enter!");
                Console.ResetColor();
            }
            gp.Input(); // Введення першого члена і знаменника
            gp.Output(); // Виведення першого члена і знаменника

            Console.Write("Введіть кількість членів прогресії, які потрібно вивести: ");
            int n = Convert.ToInt32(Console.ReadLine());

            gp.PrintProgression(n); // Виведення перших n членів прогресії
            


            Console.Write("\nВведіть кількість членів прогресії для обчислення їх суми: ");
            int sumCount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Сума перших {sumCount} членів прогресії: " + gp.Sum(sumCount) + "\n"); // Обчислення суми

            
            Console.WriteLine("Введіть індекс шуканого члена прогресії (номер)");
            int index = int.Parse(Console.ReadLine());
            
            // Виведення конкретного члена прогресії за індексом
            Console.WriteLine($"Член прогресії з індексом {index}: {gp[index]}");
           
        }
    }
}