
using System.Collections.Generic;
using Rotex.Lively.Web.Client.ViewModels;

namespace Rotex.Lively.Web.Client.DummyData
{
    public static class CreatorAnalyticsPageData
    {
        public static CreatorAnalyticsPageViewModel Get()
        {
            return new CreatorAnalyticsPageViewModel
            {
                DateRange = "Last 7 days",

                // ── OVERVIEW ──────────────────────────────────────────────────
                Overview = new AnalyticsOverview
                {
                    TotalEarnings = 12_458m,
                    EarningsTrend = "+18%",
                    EarningsUp = true,
                    LiveViews = "48.2K",
                    ViewsTrend = "+12%",
                    ViewsUp = true,
                    NewFans = 1_247,
                    FansTrend = "+6%",
                    FansUp = true,
                    TipsGifts = 8_920m,
                    TipsGiftsTrend = "+13%",
                    TipsGiftsUp = true,
                    AvgWatchTime = "42m 18s",
                    WatchTimeTrend = "-5%",
                    WatchTimeUp = false,
                    InsightMessage = "Friday evenings have the highest engagement rates for your content.",

                    ChartDates = new List<string> { "Dec 23", "Dec 24", "Dec 25", "Dec 26", "Dec 27", "Dec 28", "Dec 29" },
                    ChartEarningsValues = new List<decimal> { 800, 1400, 1900, 2500, 1400, 2200, 2800 },
                    ChartViewsValues = new List<int> { 2800, 4200, 7500, 6200, 1800, 6500, 10000 }
                },

                // ── SHOWS ─────────────────────────────────────────────────────
                Shows = new AnalyticsShows
                {
                    Rows = new List<ShowRow>
                    {
                        new() { Id="r1", Title="Holiday Gift Haul & Styling Tips", ThumbnailUrl="/images/shows/holiday-haul.jpg",
                                Date="Dec 29, 2025", Views=8_200, AvgWatchTime="45m 1s", Tips=1_240m, Gifts=1_240m, TotalEarnings=2_480m },
                        new() { Id="r2", Title="Holiday Gift Haul & Styling Tips", ThumbnailUrl="/images/shows/holiday-haul.jpg",
                                Date="Dec 29, 2025", Views=8_200, AvgWatchTime="45m 1s", Tips=1_240m, Gifts=1_240m, TotalEarnings=2_480m },
                        new() { Id="r3", Title="Holiday Gift Haul & Styling Tips", ThumbnailUrl="/images/shows/holiday-haul.jpg",
                                Date="Dec 29, 2025", Views=8_200, AvgWatchTime="45m 1s", Tips=1_240m, Gifts=1_240m, TotalEarnings=2_480m },
                        new() { Id="r4", Title="Holiday Gift Haul & Styling Tips", ThumbnailUrl="/images/shows/holiday-haul.jpg",
                                Date="Dec 29, 2025", Views=8_200, AvgWatchTime="45m 1s", Tips=1_240m, Gifts=1_240m, TotalEarnings=2_480m }
                    }
                },

                // ── FANS ──────────────────────────────────────────────────────
                Fans = new AnalyticsFans
                {
                    NewFansPercent = 62,
                    ReturningFansPercent = 50,
                    FollowerGrowth = 1_247,
                    GrowthTrend = "+18% from last period",
                    GrowthUp = true,
                    CountriesWatching = 28,

                    TopCountries = new List<CountryReach>
                    {
                        new() { Country="Nigeria",        BarPercent=90 },
                        new() { Country="United States",  BarPercent=55 },
                        new() { Country="United Kingdom", BarPercent=42 },
                        new() { Country="Ghana",          BarPercent=28 }
                    },

                    RevenueByCurrency = new List<CurrencyRevenue>
                    {
                        new() { CurrencyCode="USD", Amount=5_603.10m, Percent=45, ColorKey="blue"   },
                        new() { CurrencyCode="NGN", Amount=4_560.30m, Percent=35, ColorKey="purple" },
                        new() { CurrencyCode="GBP", Amount=2_494.60m, Percent=20, ColorKey="green"  }
                    }
                },

                // ── EARNINGS ──────────────────────────────────────────────────
                Earnings = new AnalyticsEarnings
                {
                    TotalEarnings = 12_458m,
                    EarningsPeriod = "Last 7 days",
                    AvgPerShow = 2_492m,
                    ShowCount = 5,
                    TopCurrency = "USD",
                    CurrencyPct = 45,

                    PieSlices = new List<RevenueSourceSlice>
                    {
                        new() { Label="Tip",          Amount=4_850m, Percent=45, ColorKey="blue"   },
                        new() { Label="Gifts",         Amount=4_070m, Percent=35, ColorKey="purple" },
                        new() { Label="Ticket Sales",  Amount=2_138m, Percent=20, ColorKey="green"  }
                    },

                    CurrencyRows = new List<MultiCurrencyRow>
                    {
                        new() { Code="USD", OriginalAmount="$5,603.10",  UsdAmount="$5,603.10",  Percent=45, ColorKey="pink"   },
                        new() { Code="NGN", OriginalAmount="₦400,000",   UsdAmount="$274.46",    Percent=35, ColorKey="purple" },
                        new() { Code="GBP", OriginalAmount="£2,494.60",  UsdAmount="$3,359.23",  Percent=20, ColorKey="blue"   }
                    }
                }
            };
        }
    }
}