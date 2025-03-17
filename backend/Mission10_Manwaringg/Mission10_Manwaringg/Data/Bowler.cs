using System.ComponentModel.DataAnnotations;

public class Bowler
{
    [Key]
    public int BowlerId { get; set; }

    [Required]
    public string BowlerFirstName { get; set; } = string.Empty;

    [Required]
    public string BowlerLastName { get; set; } = string.Empty;

    public string? BowlerMiddleName { get; set; }

    [Required]
    public int TeamID { get; set; }

    public string? BowlerAddress { get; set; }

    public string? BowlerCity { get; set; }

    public string? BowlerState { get; set; }

    public string? BowlerZip { get; set; }
    
    public Team? Team { get; set; }
}

public class Team
{
    [Key]
    public int TeamID { get; set; }

    public string TeamName { get; set; } = string.Empty;
    
    public List<Bowler> Bowlers { get; set; } = new();
}