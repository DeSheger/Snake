namespace Snake.Services;

public class Window
{
    public static void GenerateWidnows(
        int obstacleXpos, 
        int obstacleYpos, 
        string obstacle, 
        Pixel hoofd, 
        int screenwidth,
        int screenheight,
        int score)
    {
        Console.Clear();

        //Draw Obstacle

        Console.ForegroundColor = ConsoleColor.Cyan;

        Console.SetCursorPosition(obstacleXpos, obstacleYpos);

        Console.Write(obstacle);



        Console.ForegroundColor = ConsoleColor.Green;

        Console.SetCursorPosition(hoofd.xPos, hoofd.yPos);

        Console.Write("■");



        Console.ForegroundColor = ConsoleColor.White;

        for (int i = 0; i < screenwidth; i++)

        {

            Console.SetCursorPosition(i, 0);

            Console.Write("■");

        }

        for (int i = 0; i < screenwidth; i++)

        {

            Console.SetCursorPosition(i, screenheight - 1);

            Console.Write("■");

        }

        for (int i = 0; i < screenheight; i++)

        {

            Console.SetCursorPosition(0, i);

            Console.Write("■");

        }

        for (int i = 0; i < screenheight; i++)

        {

            Console.SetCursorPosition(screenwidth - 1, i);

            Console.Write("■");

        }

        Console.WriteLine("Score: " + score);

        Console.ForegroundColor = ConsoleColor.White;

        Console.Write("H");
    }
}