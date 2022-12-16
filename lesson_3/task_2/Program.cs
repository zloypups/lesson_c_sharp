
Console.Clear();
Console.Write("Введите координату X первой точки: ");
Double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y первой точки: ");
Double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z первой точки: ");
Double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату X Второй точки: ");
Double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y Второй точки: ");
Double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z Второй точки: ");
Double z2 = Convert.ToDouble(Console.ReadLine());

double dist = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
Console.WriteLine(Math.Round(dist, 2));