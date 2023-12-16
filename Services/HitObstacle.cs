namespace Snake.Services;

public class HitObstacle
{
    public static void HitObstacleFunction(Pixel hoofd, int obstacleXpos, 
        int obstacleYpos, Random randomnummer, int screenwidth, int screenheight, 
        int score, List<int> teljePositie, List<int> telje)
    {
        //Hindernis treffen

        if (hoofd.xPos == obstacleXpos || hoofd.yPos == obstacleYpos)

        {

            score++;

            obstacleXpos = randomnummer.Next(1, screenwidth);

            obstacleYpos = randomnummer.Next(1, screenheight);

        }

        teljePositie.Insert(0, hoofd.xPos);

        teljePositie.Insert(1, hoofd.yPos);

        teljePositie.RemoveAt(teljePositie.Count - 1);

        teljePositie.RemoveAt(teljePositie.Count - 1);

        //Kollision mit Wände oder mit sich selbst

        if (hoofd.xPos == 0 || hoofd.xPos == screenwidth - 1 || hoofd.yPos == 0 || hoofd.yPos == screenheight - 1)

        {

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;

            Console.SetCursorPosition(screenwidth / 5, screenheight / 2);

            Console.WriteLine("Game Over");

            Console.SetCursorPosition(screenwidth / 5, screenheight / 2 + 1);

            Console.WriteLine("Dein Score ist: " + score);

            Console.SetCursorPosition(screenwidth / 5, screenheight / 2 + 2);

            Environment.Exit(0);

        }

        for (int i = 0; i < telje.Count(); i += 2)

        {

            if (hoofd.xPos == telje[i] && hoofd.yPos == telje[i + 1])

            {

                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Red;

                Console.SetCursorPosition(screenwidth / 5, screenheight / 2);

                //???

                Console.SetCursorPosition(screenwidth / 5, screenheight / 2 + 1);

                Console.WriteLine("Your Score is: " + score);

                Console.SetCursorPosition(screenwidth / 5, screenheight / 2 + 2);

                Environment.Exit(0);

            }

        }
    }
}