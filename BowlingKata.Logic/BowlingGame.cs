namespace BowlingKata.Logic;

public class BowlingGame
{
    public static int Game(string line)
    {
        if (line[0] == '-')
        {
            return 0;
        }
        if (line[0] == '2')
        {
            return 2;
        }

        return 1;
    }
}
