using System;
using System.Collections.Generic;

public class Entry
{
    public string Prompt;
    public string Response;
    public DateTime Date;

    public Entry(string prompt, string response)
    {
        Prompt = prompt;
        Response = response;
        Date = DateTime.Now;
    }

    public override string ToString()
    {
        return $"{Date.ToShortDateString()} - {Prompt}\n{Response}";
    }
}
