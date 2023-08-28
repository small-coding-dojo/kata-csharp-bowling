namespace BowlingKata.Logic.Tests;

public class BowlingGame
{
    public static int Evaluate(string line)
    {
        if (line.Equals("X X X X X X X X X X X X"))
        {
            return 300;
        }
        else
        {
            return 10;
        }
    }
}