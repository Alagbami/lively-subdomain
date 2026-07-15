using System.Collections.Generic;
using Rotex.Lively.Web.Client.ViewModels;

namespace Rotex.Lively.Web.Client.DummyData
{
    public static class CreatorTabsData
    {
        // ═══════════════════════════════════════════════════════════════════
        public static CreatorFansViewModel GetFans()
        {
            return new CreatorFansViewModel
            {
                TopFans = new List<TopFan>
                {
                    new() { Rank=1, Name="Joshua Oluwagbemi",  Gifts=234, Tips=20_000m, EngagementPercent=95, TotalSupport=100_000m },
                    new() { Rank=2, Name="Odetola Opeyemi",    Gifts=220, Tips=20_000m, EngagementPercent=88, TotalSupport=80_000m  },
                    new() { Rank=3, Name="Pious Gold",         Gifts=100, Tips=15_000m, EngagementPercent=70, TotalSupport=80_000m  },
                    new() { Rank=4, Name="Toriola Gbemisola",  Gifts=80,  Tips=15_000m, EngagementPercent=68, TotalSupport=79_000m  },
                    new() { Rank=5, Name="Olalekan Quadril",   Gifts=80,  Tips=15_000m, EngagementPercent=68, TotalSupport=79_000m  },
                    new() { Rank=6, Name="Toriola Gbemisola",  Gifts=80,  Tips=10_000m, EngagementPercent=65, TotalSupport=79_000m  }
                },
                FansThisWeek = 384,
                FansThisWeekTrend = "+15.5% from last week",
                FansThisMonth = 1_245,
                FansThisMonthTrend = "+8% vs last month",
                AllTimeFans = 12_845
            };
        }

        // ═══════════════════════════════════════════════════════════════════
        public static CreatorEarningsViewModel GetEarnings()
        {
            return new CreatorEarningsViewModel
            {
                ThisMonth = 100_000m,
                LastMonth = 40_000m,
                Pending = 55_000m,
                TotalPaidOut = 20_000m,

                Sources = new List<RevenueSource>
                {
                    new() {
                        Name="Virtual Gifts",
                        Description="Fans send virtual gifts during live shows",
                        Amount=150_000m, Percent=15,
                        ColorKey="pink", IconClass="bi bi-gift"
                    },
                    new() {
                        Name="Cash Tips",
                        Description="Direct cash tips from viewers",
                        Amount=1_400_000m, Percent=85,
                        ColorKey="green", IconClass="bi bi-cash-stack"
                    },
                    new() {
                        Name="Ticket Sales",
                        Description="Revenue from paid show tickets",
                        Amount=400_000m, Percent=40,
                        ColorKey="purple", IconClass="bi bi-ticket-perforated"
                    }
                },

                ReadyForPayout = 240_567m
            };
        }

        // ═══════════════════════════════════════════════════════════════════
        public static CreatorAnalyticsViewModel GetAnalytics()
        {
            return new CreatorAnalyticsViewModel
            {
                Engagement = new List<EngagementMetric>
                {
                    new() { Name="Engagement Rate",   Value="82%",    BarPercent=82, ColorKey="pink"   },
                    new() { Name="Gift Rate",         Value="15.8%",  BarPercent=16, ColorKey="purple" },
                    new() { Name="Avg. Watch Time",   Value="52 min", BarPercent=70, ColorKey="blue"   },
                    new() { Name="Return Viewers",    Value="72%",    BarPercent=72, ColorKey="purple" }
                },
                Growth = new List<GrowthInsight>
                {
                    new() { Title="New Followers",  Description="This week vs last week",      Value="+384", ColorKey="green"  },
                    new() { Title="Show Views",     Description="Compared to last month",      Value="+28%", ColorKey="blue"   },
                    new() { Title="Revenue Growth", Description="Month over month",            Value="+18%", ColorKey="purple" },
                    new() { Title="Best Show Time", Description="Peak viewer activity",        Value="7-9 PM", ColorKey="yellow" }
                }
            };
        }
    }
}