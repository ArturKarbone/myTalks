[Fact]
public void Should_not_throw_when_there_are_rules_provided()
{
    new Calculator()
        .AddRule(new WeekendRule())
        .IsBusinessDay(DateTime.Parse("15-09-2018"));
}