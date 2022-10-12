void perimeter_and_square(int length, int width)
{
    Console.WriteLine($"Rectangle length = {length}, width = {width}:");
    int perimeter = length * 2 + width * 2;
    Console.WriteLine($"P = {perimeter}");
    int square = length * width;
    Console.WriteLine($"S = {square}");
}
perimeter_and_square(1, 2);
