public class WeekendRuleTests
{
    private readonly WeekendRule _rule;
    private readonly ITestOutputHelper _output;
    public WeekendRuleTests(ITestOutputHelper output)
    {
        _rule = new WeekendRule();
        _output = output;
    }
}