using System;
using System.Collections.Generic;

class Resume
{
    public Resume() { }
    public string Title { get; set; }
    public ContactInfo ContactInfo {get;set;}
    public IList<WorkExperience> WorkExperiences { get; set; }
    public List<string> TechnicalSkills { get; set; }
    public IList<Degree> Education { get; set; }

    public void Close()
    {
        center(Title);
        lIne();
        center(ContactInfo.Name);
        center(ContactInfo.Phone);
        center(ContactInfo.Email);
        center(ContactInfo.Website.AbsoluteUri);
        center(ContactInfo.LinkedIn.AbsoluteUri);
        center(ContactInfo.Twitter.AbsoluteUri);
        Console.ReadLine();

        foreach (var work in WorkExperiences)
        {
            clear();
            write(work.Title);
            lIne();
            write("Company: " + work.CompanyName);
            write("Years :" + work.From.ToShortDateString() + " - " + work.To.ToShortDateString());
            foreach(var duty in work.Duties)
                indent(duty);
            Console.ReadLine();
        }
        clear();
        write("Technical Skills:");
        TechnicalSkills.ForEach(x => indent(x + ", "));
        Console.ReadLine();
        clear();
        foreach (var degree in Education)
        {
            write(degree.School);
            indent(degree.Type +  " " + degree.Year);
        }
        Console.ReadLine();
    }

    public static void write(string text)
    {
        Console.WriteLine(text);
    }

    public static void clear()
    {
        Console.Clear();
    }

    private static void center(String text)
    {
        Console.Write(new string(' ', (Console.WindowWidth - text.Length) / 2));
        write(text);
    }

    private static void lIne(int LineCount = 1)
    {
        for (int i = 1; i <= LineCount; i++)
            write("");
    }

    private static void indent(String text, int indentcount = 1)
    {
        for (int i = 1; i <= indentcount; i++)
            Console.Write(new string(' ', 3));
        write(text);
    }
}

class ContactInfo
{
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public Uri Website { get; set; }
    public Uri LinkedIn { get; set; }
    public Uri Twitter { get; set; }
}

class WorkExperience
{
    public string CompanyName { get; set; }
    public string ContratingCompany { get; set; }
    public DateTime From { get; set; }
    public DateTime To { get; set; }
    public string Title { get; set; }
    public IList<string> Duties { get; set; }
}

class Degree
{
    public string School { get; set; }
    public string Type { get; set; }
    public string Year { get; set; }
}