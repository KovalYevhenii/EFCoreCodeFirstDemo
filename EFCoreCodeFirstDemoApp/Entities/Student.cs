using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreCodeFirstDemoApp.Entities;
internal class Student
{
    public int StudentId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateTime? DateOfBirth { get; set; }

    [Column(TypeName ="decimal(18, 4)")]
    public decimal Hight { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal Weight { get; set; }
    public virtual Standard? Standard { get; set; }
}
