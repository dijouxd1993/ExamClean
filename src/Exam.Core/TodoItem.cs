using System;

public class TodoItem{
    
    public TodoItem(DateTime date, string message)
    {
        this.message = message;
        this.date = date;
        DateProvider = DateTime.Now;
    }

    private DateTime date;
    private string message;

    public TimeSpan Age { get => date.Subtract(DateProvider);}
    public static DateTime DateProvider { get => DateProvider; set => DateProvider = value; }


    public override string ToString(){
        return $"[{Age.ToString("dd")}] {message}]";
    }


}