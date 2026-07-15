using Rotex.Lively.Web.Client.ViewModels;
using System;
using System.Collections.Generic;

namespace Rotex.Lively.Web.Client.ViewModels
{
    public class CreatorHubViewModel
    {
        public string CreatorName { get; set; } = string.Empty;
        public CreatorStats Stats { get; set; } = new();
        public List<RecentShow> RecentShows { get; set; } = new();
        public List<UpcomingShow> UpcomingShows { get; set; } = new();
        public CreatorPerformance Performance { get; set; } = new();
        public CreatorShowsViewModel ShowsTab { get; set; } = new();
        public CreatorFansViewModel FansTab { get; set; } = new();
        public CreatorEarningsViewModel EarningsTab { get; set; } = new();
        public CreatorAnalyticsViewModel AnalyticsTab { get; set; } = new();
    }

    public class CreatorStats
    {
        public decimal TotalEarnings { get; set; }
        public string TotalEarningsTrend { get; set; } = string.Empty;
        public bool TotalEarningsIsPositive { get; set; }
        public int TotalTicketsSold { get; set; }
        public string TotalTicketsTrend { get; set; } = string.Empty;
        public bool TotalTicketsIsPositive { get; set; }
        public int TotalViews { get; set; }
        public string TotalViewsTrend { get; set; } = string.Empty;
        public bool TotalViewsIsPositive { get; set; }
        public string TotalFans { get; set; } = string.Empty;
        public string TotalFansTrend { get; set; } = string.Empty;
        public bool TotalFansIsPositive { get; set; }
        public decimal TotalTipsReceived { get; set; }
        public string TotalTipsTrend { get; set; } = string.Empty;
        public bool TotalTipsIsPositive { get; set; }
        public int TotalGiftsReceived { get; set; }
        public string TotalGiftsTrend { get; set; } = string.Empty;
        public bool TotalGiftsIsPositive { get; set; }
    }

    public class RecentShow
    {
        public string Id { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string ThumbnailUrl { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string TicketsSoldLabel { get; set; } = string.Empty;
        public DateTime AiredAt { get; set; }
        public TimeSpan Duration { get; set; }
        public int Views { get; set; }
        public int Gifts { get; set; }
        public decimal Tips { get; set; }
        public decimal? Price { get; set; }
    }

    public class UpcomingShow
    {
        public string Id { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string ThumbnailUrl { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public DateTime ScheduledAt { get; set; }
        public int ExpectedViewers { get; set; }
        public decimal? PricePerTicket { get; set; }
        public int TicketsSold { get; set; }
        public int SavedCount { get; set; }
    }

    public class CreatorPerformance
    {
        public int EngagementRatePercent { get; set; }
        public int AverageViewers { get; set; }
        public string AverageViewersTrend { get; set; } = string.Empty;
        public bool AverageViewersIsPositive { get; set; }
        public int AverageWatchTimeMinutes { get; set; }
        public string AverageWatchTimeNote { get; set; } = string.Empty;
    }
}