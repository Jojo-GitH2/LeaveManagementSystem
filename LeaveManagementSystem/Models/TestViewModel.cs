using System;

namespace LeaveManagementSystem.Models;

public class TestViewModel
{
    public required string Name { get; set; }
    public int Age { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string? Address { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    
}
