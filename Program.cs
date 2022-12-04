Console.Clear();

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// int NatureNumber(string ending)
// {
//     bool check = false;
//     int count = 0;
//     int number = 0;
//     string? symbol = String.Empty;
//     while (check == false)
//     {
//         symbol = Console.ReadLine();
//         if (symbol == ending)
//             check = true;
//         else
//         {
//             number = Convert.ToInt32(symbol);
//             if (number > 0) count++;
//         }
//     }
//     return count;
// }
// Console.WriteLine("Введи числа");
// Console.WriteLine("Для подтверждения введите 'q'");
// string end = "q";
// int count = NatureNumber(end);
// Console.WriteLine($"Количество чисел больше нуля: {count}");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// string IntersectionOfStraightLines(double k1, double b1, double k2, double b2)
//         {
//             string result;
//             if (k1 == k2 && b1 == b2)
//             {
//                 result = "Прямые совпадают -  пересекаются на бесконечном множестве точек";
//             }
//             else if (k1 == k2 && b1 != b2)
//             {
//                 result = "Прямые параллельны друг другу -  не пересекаются";
//             }
//             else
//             {
//                 double x = (b2 - b1) / (k1 - k2);
//                 double y = (k1 * x + b1);
//                 result = $"Пересекаются в точке с координатами x = {x} и y = {y}";
//             }
//             return result;
//         }
//         Console.WriteLine("y=k1*X+b1");
//         Console.WriteLine("y=k2*X+b2");
//         Console.WriteLine("Введи коэффициенты: k1, b1, k2, b2");
//         double k1 = Convert.ToInt32(Console.ReadLine());
//         double b1 = Convert.ToInt32(Console.ReadLine());
//         double k2 = Convert.ToInt32(Console.ReadLine());
//         double b2 = Convert.ToInt32(Console.ReadLine());
//         string result = IntersectionOfStraightLines(k1, b1, k2, b2);
//         Console.WriteLine(result);