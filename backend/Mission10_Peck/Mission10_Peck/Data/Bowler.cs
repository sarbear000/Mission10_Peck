using System.ComponentModel.DataAnnotations;

namespace Mission10_Peck.Data;

public class Bowler
{
    [Key]
    public int BowlerId { get; set; }
    [Required]
    public string BowlerFirstName { get; set; }
 
    public string? BowlerMiddleInit { get; set; }
    [Required]
    public string BowlerLastName { get; set; }
    [Required]
    public string BowlerAddress { get; set; }
    [Required]
    public string BowlerCity { get; set; }
    [Required]
    public string BowlerState { get; set; }
    [Required]
    public string BowlerZip { get; set; }
    [Required]
    public string BowlerPhoneNumber { get; set; }
    [Required]
    public int TeamId { get; set; }
  
    public Team Team { get; set; }
    
}