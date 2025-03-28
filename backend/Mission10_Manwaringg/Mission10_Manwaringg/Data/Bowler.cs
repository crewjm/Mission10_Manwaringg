using System.ComponentModel.DataAnnotations;

public class Bowler
//specifics on id's and whether or not strings required
{
    [Key]
    public int BowlerId { get; set; }

    [Required]
    public string BowlerFirstName { get; set; } = string.Empty;

    [Required]
    public string BowlerLastName { get; set; } = string.Empty;

    public string? BowlerMiddleInit { get; set; }

    [Required]
    public int TeamID { get; set; }

    public string? BowlerAddress { get; set; }

    public string? BowlerCity { get; set; }

    public string? BowlerState { get; set; }

    public string? BowlerZip { get; set; }
    
    public string? BowlerPhoneNumber { get; set; }
    
    public Team? Team { get; set; }
}

//team class
public class Team
{
    [Key]
    public int TeamID { get; set; }

    public string TeamName { get; set; } = string.Empty;
    
    public List<Bowler> Bowlers { get; set; } = new();
}