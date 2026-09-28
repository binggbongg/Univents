using Univents.Models;

namespace Univents.Data;

public static class EventReviewSeedData
{
    public static readonly List<string> SortOptions = new()
    {
        "Most recent",
        "Highest rated",
        "Most helpful",
    };

    // Demo reviews, keyed by EventId so any event card on the Welcome page can
    // link through to a populated comments & ratings page (falls back to an
    // empty list for events that don't have seeded reviews yet).
    public static readonly List<ReviewItem> Reviews = new()
    {
        new ReviewItem { Id = 1, EventId = 1, Name = "Ava Mitchell", Avatar = "AM", AvatarColor = "#92dafa", Date = "2 days ago", Rating = 5, Title = "Genuinely well organized", Text = "The line moved fast, the volunteers were friendly, and there was clearly a lot of planning behind the scenes. Easily the best campus event I've been to this year.", Helpful = 18, Verified = true },
        new ReviewItem { Id = 2, EventId = 1, Name = "Jonah Lee", Avatar = "JL", AvatarColor = "#f3a0a6", Date = "1 week ago", Rating = 4, Title = "Fun, just a bit crowded", Text = "Great vibe and the food stalls were a highlight. Parking near the quad got busy around midday, but everything on the inside ran smoothly.", Helpful = 9, Verified = true },
        new ReviewItem { Id = 3, EventId = 1, Name = "Sofia Patel", Avatar = "SP", AvatarColor = "#d2a5e5", Date = "3 weeks ago", Rating = 5, Title = "Loved the performances", Text = "The student bands were a nice surprise and the whole afternoon felt well paced. Would definitely come back next semester.", Helpful = 6, Verified = false },

        // Winter Welcome Mixer (My Events placeholder, EventId 101)
        new ReviewItem { Id = 4, EventId = 101, Name = "Marcus Diaz", Avatar = "MD", AvatarColor = "#a5d6a7", Date = "5 weeks ago", Rating = 4, Title = "Great way to start the semester", Text = "Good energy, easy to meet people from other departments. Snacks ran out fast but the games made up for it.", Helpful = 4, Verified = true },
    };

    public static List<ReviewItem> GetReviewsForEvent(int eventId) =>
        Reviews.Where(r => r.EventId == eventId).ToList();

    // Rating breakdown (score -> percentage) used to render the summary bars.
    public static List<(int Score, int Percent)> GetRatingBreakdown(List<ReviewItem> reviews)
    {
        var buckets = new[] { 5, 4, 3, 2, 1 };
        var total = reviews.Count;

        return buckets.Select(score =>
        {
            var count = reviews.Count(r => r.Rating == score);
            var percent = total == 0 ? 0 : (int)Math.Round(count * 100.0 / total);
            return (score, percent);
        }).ToList();
    }
}
