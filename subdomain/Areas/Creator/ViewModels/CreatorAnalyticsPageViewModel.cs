using System;
using System.Collections.Generic;

namespace Rotex.Lively.Web.Client.ViewModels
{
    // ═══════════════════════════════════════════════════════════════════════
    //  Page root
    // ═══════════════════════════════════════════════════════════════════════
    public class CreatorAnalyticsPageViewModel
    {
        public string DateRange { get; set; } = "Last 7 days";
        public AnalyticsOverview Overview { get; set; } = new();
        public AnalyticsShows Shows { get; set; } = new();
        public AnalyticsFans Fans { get; set; } = new();
        public AnalyticsEarnings Earnings { get; set; } = new();
    }

    // ═══════════════════════════════════════════════════════════════════════
    //  OVERVIEW TAB
    // ═══════════════════════════════════════════════════════════════════════
    public class AnalyticsOverview
    {
        public decimal TotalEarnings { get; set; }
        public string EarningsTrend { get; set; } = string.Empty;
        public bool EarningsUp { get; set; }

        public string LiveViews { get; set; } = string.Empty;
        public string ViewsTrend { get; set; } = string.Empty;
        public bool ViewsUp { get; set; }

        public int NewFans { get; set; }
        public string FansTrend { get; set; } = string.Empty;
        public bool FansUp { get; set; }

        public decimal TipsGifts { get; set; }
        public string TipsGiftsTrend { get; set; } = string.Empty;
        public bool TipsGiftsUp { get; set; }

        public string AvgWatchTime { get; set; } = string.Empty;
        public string WatchTimeTrend { get; set; } = string.Empty;
        public bool WatchTimeUp { get; set; }

        public string InsightMessage { get; set; } = string.Empty;

        // Chart data — dates + parallel values for Earnings and Views
        public List<string> ChartDates { get; set; } = new();
        public List<decimal> ChartEarningsValues { get; set; } = new();
        public List<int> ChartViewsValues { get; set; } = new();
    }

    // ═══════════════════════════════════════════════════════════════════════
    //  SHOWS TAB
    // ═══════════════════════════════════════════════════════════════════════
    public class AnalyticsShows
    {
        public List<ShowRow> Rows { get; set; } = new();
    }

    public class ShowRow
    {
        public string Id { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string ThumbnailUrl { get; set; } = string.Empty;
        public string Date { get; set; } = string.Empty;
        public int Views { get; set; }
        public string AvgWatchTime { get; set; } = string.Empty;
        public decimal Tips { get; set; }
        public decimal Gifts { get; set; }
        public decimal TotalEarnings { get; set; }
    }

    // ═══════════════════════════════════════════════════════════════════════
    //  FANS TAB
    // ═══════════════════════════════════════════════════════════════════════
    public class AnalyticsFans
    {
        public int NewFansPercent { get; set; }
        public int ReturningFansPercent { get; set; }

        public int FollowerGrowth { get; set; }
        public string GrowthTrend { get; set; } = string.Empty;
        public bool GrowthUp { get; set; }

        public int CountriesWatching { get; set; }

        public List<CountryReach> TopCountries { get; set; } = new();
        public List<CurrencyRevenue> RevenueByCurrency { get; set; } = new();
    }

    public class CountryReach
    {
        public string Country { get; set; } = string.Empty;
        public int BarPercent { get; set; }              // 0-100 relative to max
    }

    public class CurrencyRevenue
    {
        public string CurrencyCode { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public int Percent { get; set; }
        public string ColorKey { get; set; } = "blue"; // blue | purple | green
    }

    // ═══════════════════════════════════════════════════════════════════════
    //  EARNINGS TAB
    // ═══════════════════════════════════════════════════════════════════════
    public class AnalyticsEarnings
    {
        public decimal TotalEarnings { get; set; }
        public string EarningsPeriod { get; set; } = string.Empty;
        public decimal AvgPerShow { get; set; }
        public int ShowCount { get; set; }
        public string TopCurrency { get; set; } = string.Empty;
        public int CurrencyPct { get; set; }

        public List<RevenueSourceSlice> PieSlices { get; set; } = new();
        public List<MultiCurrencyRow> CurrencyRows { get; set; } = new();
    }

    public class RevenueSourceSlice
    {
        public string Label { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public int Percent { get; set; }  // 0-100
        public string ColorKey { get; set; } = "blue"; // blue | purple | green
    }

    public class MultiCurrencyRow
    {
        public string Code { get; set; } = string.Empty;
        public string OriginalAmount { get; set; } = string.Empty;
        public string UsdAmount { get; set; } = string.Empty;
        public int Percent { get; set; }
        public string ColorKey { get; set; } = "pink";
    }
}