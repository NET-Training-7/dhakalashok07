﻿using System.ComponentModel.DataAnnotations;

namespace CollegeManagement.Web.Models;
public class Student
{
    [Key]
    public int Id { get; set; }
    public int RollNo { get; set; }
    public string? Name { get; set; } /*=string.Empty;*/ //public pachadi ? or = string.Empty any one will work

    public string?Address { get; set; }
    public string? Gender { get; set; }
    public DateTime? Dob { get; set; }
    public string? Contact { get; set; }
    public string? Email { get; set; }
    public string? Major { get; set; }
    public string? Semester { get; set; }
}

