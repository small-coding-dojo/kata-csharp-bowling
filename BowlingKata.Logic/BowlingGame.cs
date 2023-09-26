namespace BowlingKata.Logic;

public class BowlingGame
{
    public static int Game(string line)
    {
        var firstThrow = line[0];
        var secondThrow = line[1];

        if (firstThrow == '-')
        {
            return ThrowToPoints(secondThrow);
        }

        return ThrowToPoints(firstThrow);
    }

    private static int ThrowToPoints(char pinsAsChar)
    {
        if (pinsAsChar == '-')
        {
            return 0;
        }
        return int.Parse(pinsAsChar.ToString());
    }
}