[Fact]
public void Should_work_correctly_when_two_rules_treat_date_differently()
{
    var firstRule = new Mock<IRule>(MockBehavior.Strict);
    firstRule.Setup(x => x.IsBusinessDay(DateTime.Parse("15-09-2018"))).Returns(false);

    var secondRule = new Mock<IRule>(MockBehavior.Strict);
    secondRule.Setup(x => x.IsBusinessDay(DateTime.Parse("15-09-2018"))).Returns(true);

    var calculator = new Calculator()
        .AddRule(firstRule.Object)
        .AddRule(secondRule.Object);

    Assert.False(calculator.IsBusinessDay(DateTime.Parse("15-09-2018")));
}