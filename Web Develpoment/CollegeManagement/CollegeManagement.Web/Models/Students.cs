namespace CollegeManagement.Web.Models;
public class Student
{
    public int RollNo { get; set; }
    public string Name { get; set; } =string.Empty; //public pachadi ? or = string.Empty any one will work
    public string? Major { get; set; }
    public string? Contact { get; set; }
    public string? Semester { get; set; }
}
