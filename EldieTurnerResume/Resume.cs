using System;
using System.Collections.Generic;

public class Resume
{
    public Resume() { }
    public string Title { get; set; }
    public ContactInfo ContactInfo {get;set;}
    public IList<WorkExperience> WorkExperiences { get; set; }
    public IList<string> TechnicalSkills { get; set; }
    public IList<Degree> Education { get; set; }

    public void End()
    {
        //going ot rethink what this will actuall ydo.
    }
}

public class ContactInfo
{
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public Uri Website { get; set; }
    public Uri LinkedIn { get; set; }
    public Uri Twitter { get; set; }
}

public class WorkExperience
{
    public string CompanyName { get; set; }
    public string ContractingCompany { get; set; }
    public DateTime From { get; set; }
    public DateTime To { get; set; }
    public string Title { get; set; }
    public IList<string> Duties { get; set; }
}

public class Degree
{
    public string School { get; set; }
    public string Type { get; set; }
    public DateTime Year { get; set; }
}

public static class ExtensionMethods
{
    public static DateTime Parse(this string date)
    {
        return DateTime.Parse(date);
    }
}