﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CollegeManagement.Web.Models;
public class Student
{
    public int Id { get; set; }

    [DisplayName("Roll Number")]
    public int RollNo { get; set; }

    [Required(ErrorMessage = "We need your name."), ]
    [MinLength(2, ErrorMessage = "At least 2 letters please.")]
    [RegularExpression(@"[A-Za-z]+", ErrorMessage = "Only alpahbets and space are allowed.")]
    public string? Name { get; set; }
    public string? Address { get; set; }
    public string? Gender { get; set; }

    [DisplayName("Date Of Birth")]
    public DateTime? Dob { get; set; }

    public string? Contact { get; set; }
    public string? Email { get; set; }
    public string? Major { get; set; }
    public string? Semester { get; set; }

}


///*=string.Empty;*/ //public pachadi ? or = string.Empty any one will work