namespace UFC_API.Models;

public class Fighter
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Nickname { get; set; } = null!;
    public int Age { get; set; }
    public float Weight { get; set; }
    public int Rank { get; set; }
}