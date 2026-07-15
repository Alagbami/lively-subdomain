using System;
using System.Collections.Generic;
using Rotex.Lively.Web.Client.ViewModels;

namespace Rotex.Lively.Web.Client.DummyData
{
    public static class CreatorShowsData
    {
        public static CreatorShowsViewModel Get()
        {
            return new CreatorShowsViewModel
            {
                Shows = new List<CreatorShow>
                {
                    // ── Past Shows (3) ──
                    new()
                    {
                        Id = "s-1",
                        Title = "Afrobeat Music Session",
                        Category = "Music Show",
                        ThumbnailUrl = "/images/shows/afrobeat-music.jpg",
                        Status = ShowStatus.Past,
                        IsPaid = true,
                        AiredAt = DateTime.Now.AddDays(-2),
                        Viewers = 3_847,
                        Duration = TimeSpan.FromMinutes(105),
                        Gifts = 45,
                        Earned = 450_000m
                    },
                    new()
                    {
                        Id = "s-2",
                        Title = "African Comedy Night Live",
                        Category = "Comedy Show",
                        ThumbnailUrl = "/images/shows/comedy-night.jpg",
                        Status = ShowStatus.Past,
                        IsPaid = false,
                        AiredAt = DateTime.Now.AddDays(-3),
                        Viewers = 3_847,
                        Duration = TimeSpan.FromMinutes(105),
                        Gifts = 45,
                        Earned = 100_000m
                    },
                    new()
                    {
                        Id = "s-3",
                        Title = "African Comedy Night Live",
                        Category = "Comedy Show",
                        ThumbnailUrl = "/images/shows/comedy-night-2.jpg",
                        Status = ShowStatus.Past,
                        IsPaid = false,
                        AiredAt = DateTime.Now.AddDays(-5),
                        Viewers = 3_847,
                        Duration = TimeSpan.FromMinutes(105),
                        Gifts = 45,
                        Earned = 50_000m
                    },

                    // ── Upcoming Shows (4) ──
                    new()
                    {
                        Id = "s-4",
                        Title = "Afrobeat Music Session",
                        Category = "Music Show",
                        ThumbnailUrl = "/images/shows/afrobeat-upcoming.jpg",
                        Status = ShowStatus.Upcoming,
                        IsPaid = false,
                        ScheduledAt = DateTime.Today.AddHours(18),
                        ExpectedFans = 2_000
                    },
                    new()
                    {
                        Id = "s-5",
                        Title = "Detty December Concert",
                        Category = "Music Show",
                        ThumbnailUrl = "/images/shows/detty-december.jpg",
                        Status = ShowStatus.Upcoming,
                        IsPaid = true,
                        ScheduledAt = DateTime.Today.AddHours(18),
                        ExpectedFans = 2_000,
                        TicketPrice = 2_000m,
                        TicketsSold = 1_200,
                        TicketCapacity = 2_000
                    },
                    new()
                    {
                        Id = "s-6",
                        Title = "Afrobeat Music Session",
                        Category = "Music Show",
                        ThumbnailUrl = "/images/shows/afrobeat-2.jpg",
                        Status = ShowStatus.Upcoming,
                        IsPaid = true,
                        ScheduledAt = DateTime.Today.AddHours(18),
                        ExpectedFans = 2_000,
                        TicketPrice = 2_000m,
                        TicketsSold = 1_200,
                        TicketCapacity = 2_000
                    },
                    new()
                    {
                        Id = "s-7",
                        Title = "Detty December Concert",
                        Category = "Music Show",
                        ThumbnailUrl = "/images/shows/detty-december-2.jpg",
                        Status = ShowStatus.Upcoming,
                        IsPaid = false,
                        ScheduledAt = DateTime.Today.AddHours(18),
                        ExpectedFans = 2_000
                    }
                }
            };
        }
    }
}