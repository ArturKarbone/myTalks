
[Theory]
[InlineData(false, "15-09-2018")]
[InlineData(false, "16-09-2018")]
[InlineData(true, "14-09-2018")]
public void Should_calculate_business_days(bool expectedBusinessDay, string date)
{
    Assert.Equal(expectedBusinessDay, _rule.IsBusinessDay(DateTime.Parse(date)));
}