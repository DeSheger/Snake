using Snake;
using Snake.Services;

class Program

{

    static void Main()

    {

        Console.WindowHeight = 16;

        Console.WindowWidth = 32;

        int screenwidth = Console.WindowWidth;

        int screenheight = Console.WindowHeight;

        Random randomnummer = new Random();

        Pixel hoofd = new Pixel();

        hoofd.xPos = screenwidth / 2;

        hoofd.yPos = screenheight / 2;

        hoofd.schermKleur = ConsoleColor.Red;

        string movement = "RIGHT";

        List<int> telje = new List<int>();

        int score = 0;

        hoofd.xPos = screenwidth / 2;

        hoofd.yPos = screenheight / 2;

        hoofd.schermKleur = ConsoleColor.Red;



        List<int> teljePositie = new List<int>();



        teljePositie.Add(hoofd.xPos);

        teljePositie.Add(hoofd.yPos);



        DateTime tijd = DateTime.Now;

        string obstacle = "*";

        int obstacleXpos = randomnummer.Next(1, screenwidth);

        int obstacleYpos = randomnummer.Next(1, screenheight);

        while (true)

        {

            Window.GenerateWidnows(obstacleXpos, obstacleYpos, obstacle, 
                hoofd, screenwidth, screenheight, score);

            CursorPoint.SetCursorPont(telje);

            // Draw Snake
            DrawSnake.DrawSnakeOnScreen(hoofd);

            // Game Logic
            GameLogic.ControlLogic(movement, hoofd);
            
            HitObstacle.HitObstacleFunction(hoofd, obstacleXpos, obstacleYpos, randomnummer, 
                screenwidth, screenheight, score,teljePositie,telje);

            Thread.Sleep(50);

        }

    }

}