namespace Snake.Services;

public class GameLogic
{
    public static void ControlLogic(string movement, Pixel hoofd)
    {
        ConsoleKeyInfo info = Console.ReadKey();

        //Game Logic

        switch (info.Key)

        {

            case ConsoleKey.UpArrow:

                movement = "UP";

                break;

            case ConsoleKey.DownArrow:

                movement = "DOWN";

                break;

            case ConsoleKey.LeftArrow:

                movement = "LEFT";

                break;

            case ConsoleKey.RightArrow:

                movement = "RIGHT";

                break;
        }
        
        if (movement == "UP")

            hoofd.yPos--;

        if (movement == "DOWN")

            hoofd.yPos++;

        if (movement == "LEFT")

            hoofd.xPos--;

        if (movement == "RIGHT")

            hoofd.xPos++;
    }
}