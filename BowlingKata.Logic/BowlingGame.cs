namespace BowlingKata.Logic;

public class BowlingGame
{
    public static int Game(string line)
    {
        var secondThrow = line[1];
        if (secondThrow == '1')
        {
            return ThrowToPoints(secondThrow);
        }

        var firstThrow = line[0];
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