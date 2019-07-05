[Theory]
[InlineData("13-09-2018")]
[InlineData("14-09-2018")]
public void Should_treat_as_business_days(string date)
{
    Assert.True(_rule.IsBusinessDay(DateTime.Parse(date)));
}

[Theory]
[InlineData("15-09-2018")]
[InlineData("16-09-2018")]
public void Should_treat_as_non_business_days(string date)
{
    Assert.False(_rule.IsBusinessDay(DateTime.Parse(date)));
}