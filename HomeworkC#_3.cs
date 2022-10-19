void ShowTriangle()
    {
        Console.Write("Height: ");
        int height = int.Parse(Console.ReadLine());
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }
    }
ShowTriangle();