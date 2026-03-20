using System;

public class Entry
{
    public string Date;
    public string Prompt;
    public string Response;

    public Entry(string prompt, string response)
    {
        Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
        Prompt = prompt;
        Response = response;
    }

    public override string ToString()
    {
        return $"{Date} | {Prompt} | {Response}";
    }
}
