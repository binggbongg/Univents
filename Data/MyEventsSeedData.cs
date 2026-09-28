using Univents.Models;

namespace Univents.Data;

public static class MyEventsSeedData
{
    // Temporary placeholder data for events the current user has attended.
    // All entries are marked Completed so their linked review page unlocks
    // the "write a review" form (see EventReviews.razor's isCompleted check).
    public static readonly List<EventItem> MyEvents = new()
    {
        new EventItem { Id = 101, Title = "Winter Welcome Mixer", Org = "Student Union", Date = "Jan 18", Time = "5:00 PM", Category = "Social", Attending = 268, Color = "#c5e61c", Status = "Completed", Image = "https://images.unsplash.com/photo-1511578314322-379afb476865?w=400&h=220&fit=crop&auto=format" },
        new EventItem { Id = 102, Title = "AI & Ethics Panel", Org = "CS Society", Date = "Feb 6", Time = "4:00 PM", Category = "Tech", Attending = 142, Color = "#4fc3f7", Status = "Completed", Image = "https://images.unsplash.com/photo-1591453089816-0fbb971b454c?w=400&h=220&fit=crop&auto=format" },
        new EventItem { Id = 103, Title = "Career Fair: Spring Edition", Org = "Career Center", Date = "Feb 21", Time = "10:00 AM", Category = "Career", Attending = 356, Color = "#ce93d8", Status = "Completed", Image = "https://images.unsplash.com/photo-1521737711867-e3b97375f902?w=400&h=220&fit=crop&auto=format" },
    };
}
