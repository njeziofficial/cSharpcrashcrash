using System.ComponentModel.DataAnnotations;

namespace CrashCourseWeb.Models;

public class Student
{
    public Guid Id { get; set; }
    [StringLength(200)]
    public string? FirstName { get; set; }
    [StringLength(200)]
    public string? LastName { get; set; }
    [StringLength(20)]
    public string? Tel { get; set; }
    [StringLength(200)]
    public string? Email { get; set; }
    [StringLength(200)]
    public string? Username { get; set; }
    [StringLength(200)]
    public string? Password { get; set; }
}
