namespace Mission10_Peck.Data;

public class Team
{
    public int TeamId { get; set; }
    public string TeamName { get; set; }

    public List<Bowler> Bowlers { get; set; }
}