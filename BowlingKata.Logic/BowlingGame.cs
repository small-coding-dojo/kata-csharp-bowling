namespace BowlingKata.Logic;

public class BowlingGame
{
    public static int Game(string line)
    {
        if (line[0] == '-')
        {
            return 0;
        }
        
        return int.Parse(line[0].ToString());
    }
}
