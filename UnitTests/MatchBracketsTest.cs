using MatchBrackets.Services;

namespace UnitTests;

public class Tests
{
    private MatchBracketsService _matchBracketsService;
    
    [SetUp]
    public void Setup()
    {
        _matchBracketsService = new MatchBracketsService();
    }

    [TestCase("{}")]
    [TestCase("")]
    [TestCase("{abc...xyz}")]
    [TestCase("aaaaaaaaaaaaaaaaaaaaaa{aaaaaaaaaaaaaaaaaaaaaa}aaaaaaaaaaaaaaaaaaaaaa")]
    [TestCase("{a{{{{{{{{{a}}}a}}a}}a}}a}a")]
    [TestCase("aaaaaaaaaaaaaa")]
    public void IsMatching_Success(string arg)
    {
        var isMatching = _matchBracketsService.IsMatching(arg);
        Assert.IsTrue(isMatching);
    }

    [TestCase("}{")]
    [TestCase("{{}")]
    [TestCase("{aaaaaaaaaaaaaaaaaaaaaa}}")]
    [TestCase("aaaaaaaaaaaaaaaaaaaaaa}")]
    [TestCase("{aaaaaaaaaaaaaaaaaaaaaa")]
    [TestCase("aaaaaaaaaaaaaaaa{aaaaaaaaaaaaaaaaaaaaaa")]
    [TestCase("aaaaaaaaaaaaaaaaaaaaaa}aaaaaaaaaaaaaaaaaaaaaa")]
    public void isMatching_Fail(string arg)
    {
        var isMatching = _matchBracketsService.IsMatching(arg);
        Assert.IsFalse(isMatching);
    }

    [TestCase(null)]
    public void isMatching_ThrowError(string arg)
    {
        Assert.Throws<Exception>(() => _matchBracketsService.IsMatching(arg));
    }
}