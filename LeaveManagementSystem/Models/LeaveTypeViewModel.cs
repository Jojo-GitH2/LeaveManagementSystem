using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagementSystem.Models;

public class LeaveTypeViewModel
{
    public int Id { get; set; }
    [Column(TypeName = "nvarchar(150)")]
    public string Name { get; set; }
    public int NumberOfDays { get; set; }

}
