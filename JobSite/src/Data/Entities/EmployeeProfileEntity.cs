namespace JobSite.Data.Entities;

public class EmployeeProfileEntity
{
    public string Position { get; set; }
    public int Salary  { get; set; }
    public int ExperienceYears { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public string[] Skills { get; set; }
    public string Category { get; set; }
    public int EnglishLevel { get; set; }
    public int WorkingType { get; set; }
    public string[] ExcludeCategory { get; set; }
    public int CompanyType { get; set; }
    public string  Type { get; set; }
}