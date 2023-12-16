namespace Snake.Services;

public class CursorPoint
{
    public static void SetCursorPont(List<int> telje)
    {
        for (int i = 0; i < telje.Count(); i++)

        {

            Console.SetCursorPosition(telje[i], telje[i + 1]);

            Console.Write("■");

        }
    }
}