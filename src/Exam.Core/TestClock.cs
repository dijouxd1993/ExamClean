using System;

public class TestClock : IClock
{
    private DateTime date;

    public TestClock(DateTime date)
    {
        this.date = date;
    }
    public DateTime Now()
    {
        throw new NotImplementedException();
    }
}