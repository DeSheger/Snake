namespace Snake.Services;

public class DrawSnake
{
    public static void DrawSnakeOnScreen(Pixel hoofd)
    {
        Console.SetCursorPosition(hoofd.xPos, hoofd.yPos);

        Console.Write("■");

        Console.SetCursorPosition(hoofd.xPos, hoofd.yPos);

        Console.Write("■");

        Console.SetCursorPosition(hoofd.xPos, hoofd.yPos);

        Console.Write("■");

        Console.SetCursorPosition(hoofd.xPos, hoofd.yPos);

        Console.Write("■");
    }
}