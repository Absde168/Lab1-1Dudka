Console.Write("Введите x: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите t: ");
double t = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите c: ");
double c = Convert.ToDouble(Console.ReadLine());
double L = Math.Pow(1 / Math.Tan(c), 2) + ((2 * Math.Pow(x, 2) + 5) / Math.Sqrt(c + t));
Console.WriteLine($"L = {L:F2}");