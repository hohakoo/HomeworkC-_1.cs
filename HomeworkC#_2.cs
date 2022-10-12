void circumference_and_square_of_circle(int radius)
{
    double PI = 3.14;
    Console.WriteLine($"Circle radius = {radius}, diameter = {radius*2}:");
    double circumference = 2 * PI * radius;
    Console.WriteLine($"C = {circumference}");
    double square = PI * (Math.Pow(radius, 2));
    Console.WriteLine($"S = {square}");
}
circumference_and_square_of_circle(3);