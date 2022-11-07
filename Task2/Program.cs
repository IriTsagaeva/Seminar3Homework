double Distance (int xa, int ya, int za, int xb, int yb, int zb)
{
    double distance = Math.Sqrt(Math.Pow(xb-xa,2)+Math.Pow(yb-ya,2)+Math.Pow(zb-za,2));
    return Math.Round(distance,2);
}


Console.WriteLine("Пожалуйста, введите координаты точки А");
bool x1_text = Int32.TryParse(Console.ReadLine(), out int x1);
bool y1_text = Int32.TryParse(Console.ReadLine(), out int y1);
bool z1_text = Int32.TryParse(Console.ReadLine(), out int z1);
Console.WriteLine("Пожалуйста, введите координаты точки В");
bool x2_text = Int32.TryParse(Console.ReadLine(), out int x2);
bool y2_text = Int32.TryParse(Console.ReadLine(), out int y2);
bool z2_text = Int32.TryParse(Console.ReadLine(), out int z2);

if (x1_text && y1_text && z1_text && x2_text && y2_text && z2_text)
{
    double distance = Distance (x1, y1, z1, x2, y2, z2);
    Console.WriteLine ($"Расстояние между точками равно {distance}");
}
else
{
    Console.WriteLine ("Введены некорректные координаты");
}