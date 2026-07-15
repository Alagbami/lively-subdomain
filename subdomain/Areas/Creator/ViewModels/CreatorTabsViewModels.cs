using System;
using System.Collections.Generic;

namespace Rotex.Lively.Web.Client.ViewModels
{
    // ═══════════════════════════════════════════════════════════════════════
    //  FANS TAB
    // ═══════════════════════════════════════════════════════════════════════
    public class CreatorFansViewModel
    {
        public List<TopFan> TopFans { get; set; } = new();

        // Bottom stat strip
        public int FansThisWeek { get; set; }
        public string FansThisWeekTrend { get; set; } = string.Empty;
        public int FansThisMonth { get; set; }
        public string FansThisMonthTrend { get; set; } = string.Empty;
        public int AllTimeFans { get; set; }
    }

    public class TopFan
    {
        public int Rank { get; set; }
        public string Name { get; set; } = string.Empty;
        public string AvatarUrl { get; set; } = string.Empty;   // empty = grey placeholder
        public int Gifts { get; set; }
        public decimal Tips { get; set; }
        public int EngagementPercent { get; set; }
        public decimal TotalSupport { get; set; }
    }

    // ═══════════════════════════════════════════════════════════════════════
    //  EARNINGS TAB
    // ═══════════════════════════════════════════════════════════════════════
    public class CreatorEarningsViewModel
    {
        public decimal ThisMonth { get; set; }
        public decimal LastMonth { get; set; }
        public decimal Pending { get; set; }
        public decimal TotalPaidOut { get; set; }

        public List<RevenueSource> Sources { get; set; } = new();

        public decimal ReadyForPayout { get; set; }
    }

    public class RevenueSource
    {
        public string Name { get; set; } = string.Empty;        // "Virtual Gifts", "Cash Tips", "Ticket Sales"
        public string Description { get; set; } = string.Empty; // e.g. "Fans send virtual gifts during live shows"
        public decimal Amount { get; set; }
        public int Percent { get; set; }                        // 0–100, used for the progress bar fill
        public string ColorKey { get; set; } = "pink";          // pink | green | purple
        public string IconClass { get; set; } = string.Empty;   // e.g. "bi bi-gift"
    }

    // ═══════════════════════════════════════════════════════════════════════
    //  ANALYTICS TAB
    // ═══════════════════════════════════════════════════════════════════════
    public class CreatorAnalyticsViewModel
    {
        public List<EngagementMetric> Engagement { get; set; } = new();
        public List<GrowthInsight> Growth { get; set; } = new();
    }

    public class EngagementMetric
    {
        public string Name { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;       // "82%", "52 min", etc.
        public int BarPercent { get; set; }                     // 0-100
        public string ColorKey { get; set; } = "pink";          // pink | purple | blue | green
    }

    public class GrowthInsight
    {
        public string Title { get; set; } = string.Empty;       // "New Followers"
        public string Description { get; set; } = string.Empty; // "This week vs last week"
        public string Value { get; set; } = string.Empty;       // "+384", "+28%"
        public string ColorKey { get; set; } = "green";         // green | blue | purple | yellow
    }
}