using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DBFirstDemo.Models;

public partial class Student
{
    [Required]
    public int Roll { get; set; }
    [Required]
    public string? StuName { get; set; }
    [Required]
    public string? StuGender { get; set; }
    [Required]
    public DateOnly? StuDob { get; set; }
    [Required]
    [Length(13,13)]
    public string? StuPhne { get; set; }
}
