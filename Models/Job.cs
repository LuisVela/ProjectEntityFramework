using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectEF.Models;

public class Job
{
    [Key]
    public Guid TaskId { get; set; }

    [ForeignKey("CtegoryId")]
    public Guid CategoryId { get; set; }

    [Required]
    [MaxLength(200)]
    public string Tittle { get; set; }

    public string Description { get; set; }

    public Priority TaskPriority { get; set; }

    public DateTime CreationDate { get; set; }

    public virtual Category Category { get; set; }

    [NotMapped]
    public string Resumen { get; set; }
}

public enum Priority
{
    Short,
    Half,
    High
}