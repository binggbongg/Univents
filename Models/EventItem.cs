namespace Univents.Models;

public class EventItem
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Org { get; set; } = string.Empty;
    public string Date { get; set; } = string.Empty;
    public string Time { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public int Attending { get; set; }
    public string Color { get; set; } = "#c5e61c";
    public string Image { get; set; } = string.Empty;

    // "Upcoming" (default) or "Completed". Drives whether the event's
    // review page unlocks the "write a review" form.
    public string Status { get; set; } = "Upcoming";
}
