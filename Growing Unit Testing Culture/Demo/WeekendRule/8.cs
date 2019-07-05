public static IEnumerable<object[]> SampleDaysAndExpectedResults()
{
    yield return new object[] { true, DateTime.Parse("14-09-2018") };
    yield return new object[] { true, DateTime.Parse("13-09-2018") };
    yield return new object[] { !true, DateTime.Parse("15-09-2018") };
}

[Theory]
[MemberData(nameof(SampleDaysAndExpectedResults))]
public void Should_calculate_business_days_2(bool expectedBusinessDay, DateTime date)
{
    _output.WriteLine($"Should_calculate_business_days_2 {date}");

    Assert.Equal(expectedBusinessDay, _rule.IsBusinessDay(date));
}