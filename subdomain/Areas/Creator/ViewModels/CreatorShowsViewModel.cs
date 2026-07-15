using System;
using System.Collections.Generic;

namespace Rotex.Lively.Web.Client.ViewModels
{
    /// <summary>
    /// Used by the "Shows" tab in the Creator Hub.
    /// Combines past and upcoming shows into one filterable list.
    /// </summary>
    public class CreatorShowsViewModel
    {
        public List<CreatorShow> Shows { get; set; } = new();

        // Cached counts so the filter pills don't have to recompute on every render
        public int AllCount => Shows.Count;
        public int UpcomingCount => Shows.FindAll(s => s.Status == ShowStatus.Upcoming).Count;
        public int PastCount => Shows.FindAll(s => s.Status == ShowStatus.Past).Count;
        public int PaidCount => Shows.FindAll(s => s.IsPaid).Count;
        public int FreeCount => Shows.FindAll(s => !s.IsPaid).Count;
    }

    public enum ShowStatus
    {
        Past,
        Upcoming
    }

    public class CreatorShow
    {
        public string Id { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string ThumbnailUrl { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;            // "Music Show" | "Comedy Show"
        public ShowStatus Status { get; set; }
        public bool IsPaid { get; set; }                                // false = Free
        public DateTime ScheduledAt { get; set; }                       // for upcoming
        public DateTime? AiredAt { get; set; }                          // for past

        // Stats — past shows
        public int Viewers { get; set; }
        public TimeSpan Duration { get; set; }
        public int Gifts { get; set; }
        public decimal Earned { get; set; }

        // Stats — upcoming
        public int ExpectedFans { get; set; }
        public decimal? TicketPrice { get; set; }
        public int TicketsSold { get; set; }
        public int TicketCapacity { get; set; }

        // Convenience for filter classes
        public string FilterClasses
        {
            get
            {
                var classes = new List<string> { "show-card" };
                classes.Add(Status == ShowStatus.Past ? "is-past" : "is-upcoming");
                classes.Add(IsPaid ? "is-paid" : "is-free");
                return string.Join(" ", classes);
            }
        }
    }
}