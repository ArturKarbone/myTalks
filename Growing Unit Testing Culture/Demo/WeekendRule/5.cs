[Fact]
public void Should_calculate_correctly_for_weekend_rules()
{
    Assert.True(_rule.IsBusinessDay(DateTime.Parse("14-09-2018")));
}