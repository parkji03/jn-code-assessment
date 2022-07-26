using MatchBrackets.Services;

public class Program
{
    public static void Main(string[] args)
    {
        var matchBracketsService = new MatchBracketsService();
        
        try
        {
            Console.WriteLine(matchBracketsService.IsMatching(args[0]));
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}