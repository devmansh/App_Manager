using System.ComponentModel.DataAnnotations;

public class AppRecord
{
    [Key]
    public int Id { get; set; } // Primary key for EF

    [Required]
    public string AppId { get; set; }

    [Required]
    public string AppName { get; set; }

    public string PlanAppId { get; set; }

    [Required]
    public string AppTech { get; set; }

    public string Version { get; set; }

    public DateTime TechOutOfSupport { get; set; }
}
