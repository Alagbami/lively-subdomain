using System;
using System.Collections.Generic;
using Rotex.Lively.Web.Client.ViewModels;

namespace Rotex.Lively.Web.Client.DummyData
{
    public static class CreatorHubData
    {
        public static CreatorHubViewModel Get()
        {
            return new CreatorHubViewModel
            {
                CreatorName = "Lively Creator",
                Stats = new CreatorStats
                {
                    TotalEarnings = 180_700m,
                    TotalEarningsTrend = "+12.5% from last month",
                    TotalEarningsIsPositive = true,
                    TotalTicketsSold = 20_000,
                    TotalTicketsTrend = "-12.5% from last month",
                    TotalTicketsIsPositive = false,
                    TotalViews = 6_345,
                    TotalViewsTrend = "+12% this month",
                    TotalViewsIsPositive = true,
                    TotalFans = "2.3k",
                    TotalFansTrend = "+18% this month",
                    TotalFansIsPositive = true,
                    TotalTipsReceived = 20_000m,
                    TotalTipsTrend = "+12.5% from last month",
                    TotalTipsIsPositive = true,
                    TotalGiftsReceived = 200,
                    TotalGiftsTrend = "+18% this month",
                    TotalGiftsIsPositive = true
                },
                RecentShows = new List<RecentShow>
                {
                    new RecentShow
                    {
                        Id = "show-1",
                        Title = "African Comedy Night Live",
                        ThumbnailUrl = "/images/shows/african-comedy-night.jpg",
                        Category = "Comedy Show",
                        TicketsSoldLabel = "156 tickets sold",
                        AiredAt = DateTime.Now.AddHours(-2),
                        Duration = TimeSpan.FromMinutes(105),
                        Views = 3_847,
                        Gifts = 234,
                        Tips = 20_000m,
                        Price = 40_000m
                    },
                    new RecentShow
                    {
                        Id = "show-2",
                        Title = "Comedy Gyrate Night",
                        ThumbnailUrl = "/images/shows/comedy-gyrate-1.jpg",
                        Category = "Comedy Show",
                        TicketsSoldLabel = "Ticket Booked",
                        AiredAt = DateTime.Now.AddHours(-24),
                        Duration = TimeSpan.FromMinutes(105),
                        Views = 3_847,
                        Gifts = 234,
                        Tips = 20_000m,
                        Price = null
                    },
                    new RecentShow
                    {
                        Id = "show-3",
                        Title = "Comedy Gyrate Night",
                        ThumbnailUrl = "/images/shows/comedy-gyrate-2.jpg",
                        Category = "Comedy Show",
                        TicketsSoldLabel = "Ticket Booked",
                        AiredAt = DateTime.Now.AddDays(-1),
                        Duration = TimeSpan.FromMinutes(105),
                        Views = 3_847,
                        Gifts = 234,
                        Tips = 20_000m,
                        Price = null
                    }
                },
                UpcomingShows = new List<UpcomingShow>
                {
                    new UpcomingShow
                    {
                        Id = "up-1",
                        Title = "Cooking with Chef Ama",
                        ThumbnailUrl = "/images/shows/cooking-with-chef-ama.jpg",
                        Category = "Comedy Show",
                        ScheduledAt = DateTime.Today.AddHours(18),   // Today 6:00 PM → triggers "Go Live" btn
                        ExpectedViewers = 2_000,
                        PricePerTicket = 40_000m,
                        TicketsSold = 156,
                        SavedCount = 1_000
                    },
                    new UpcomingShow
                    {
                        Id = "up-2",
                        Title = "Weekend Talent Show",
                        ThumbnailUrl = "/images/shows/weekend-talent-show.jpg",
                        Category = "Variety Show",
                        ScheduledAt = DateTime.Today.AddDays(1).AddHours(14),  // Tomorrow 2:00 PM → stays in default state
                        ExpectedViewers = 1_400,
                        PricePerTicket = null,
                        TicketsSold = 0,
                        SavedCount = 1_000
                    }
                },
                Performance = new CreatorPerformance
                {
                    EngagementRatePercent = 80,
                    AverageViewers = 234,
                    AverageViewersTrend = "+12.5% from last month",
                    AverageViewersIsPositive = true,
                    AverageWatchTimeMinutes = 52,
                    AverageWatchTimeNote = "Per show"
                }
            };
        }
    }
}