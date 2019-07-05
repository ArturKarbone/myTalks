[Fact]
public void Should_throw_when_there_are_no_rules_provided()
{
    var calculator = new Calculator();
    Assert.Throws<Calculator.NoRulesException>(() => calculator.IsBusinessDay(DateTime.Parse("15-09-2018")));
}