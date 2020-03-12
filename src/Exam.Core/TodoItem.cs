using System;

public class TodoItem{
    
    private IClock clock; 

    public TodoItem(DateTime date, string message, IClock clock)
    {
        this.message = message;
        this.date = date;
        this.clock = clock;
    }

    private DateTime date;
    private string message;

    public TimeSpan Age { get => clock.Now().Subtract(date);}


    public override string ToString(){
        return $"[{Age.ToString("dd")}] {message}]";
    }


}