namespace JobSite.Data.Entities;

public class EmployeeEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Linkedin_Profile { get; set; }
    public string GitHub_Profile { get; set; }
    public int Photo_Id { get; set; }
    public int Resume_file { get; set; }
    public int EmployeeProfile_Id { get; set; }
}