[Fact]
public void Should_work_correctly_when_one_rule_treats_date_as_non_business_one()
{
    var calculator = new Calculator();

    var rule = new Mock<IRule>(MockBehavior.Strict);
    //Use strict to fail invocations
    rule.Setup(x => x.IsBusinessDay(DateTime.Parse("16-09-2018"))).Returns(false);

    calculator.AddRule(rule.Object);
    Assert.False(calculator.IsBusinessDay(DateTime.Parse("17-09-2018")));
}