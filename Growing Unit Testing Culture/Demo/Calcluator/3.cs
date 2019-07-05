[Fact]
public void Should_work_correctly_when_one_rule_treats_date_as_business_one()
{
    var rule = new Mock<IRule>(MockBehavior.Strict);
    rule.Setup(x => x.IsBusinessDay(DateTime.Parse("15-09-2018"))).Returns(true);

    var calculator = new Calculator()
        .AddRule(rule.Object);

    Assert.True(calculator.IsBusinessDay(DateTime.Parse("15-09-2018")));
}