namespace Univents.Models;

public class ReviewItem
{
    public int Id { get; set; }
    public int EventId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Avatar { get; set; } = string.Empty;
    public string AvatarColor { get; set; } = "#c5e61c";
    public string Date { get; set; } = string.Empty;
    public int Rating { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Text { get; set; } = string.Empty;
    public int Helpful { get; set; }
    public bool Verified { get; set; }
}
