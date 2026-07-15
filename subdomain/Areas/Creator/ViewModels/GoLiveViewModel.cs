using System;
using System.Collections.Generic;

namespace Rotex.Lively.Web.Client.ViewModels
{
    public class GoLiveViewModel
    {
        // ── Stream meta ──
        public string ShowId { get; set; } = string.Empty;
        public string ShowTitle { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string StreamUrl { get; set; } = string.Empty;       // <video> source
        public string PosterUrl { get; set; } = string.Empty;       // fallback poster image
        public DateTime StartedAt { get; set; }                     // for timer

        // ── Top bar data ──
        public int CurrentViewers { get; set; }
        public int PeakViewers { get; set; }
        public int TotalGifts { get; set; }
        public decimal TipsAmount { get; set; }
        public string Currency { get; set; } = "$";
        public decimal CoinsAmount { get; set; }                    // shown in top-right

        // ── Tab data ──
        public List<ChatMessage> ChatMessages { get; set; } = new();
        public List<Viewer> Viewers { get; set; } = new();
        public List<GuestRequest> GuestRequests { get; set; } = new();
        public List<InvitedGuest> InvitedGuests { get; set; } = new();
        public List<Viewer> InviteableViewers { get; set; } = new();
        public StatsData Stats { get; set; } = new();
    }

    // ── Chat ──────────────────────────────────────────────────────────────────
    public class ChatMessage
    {
        public string UserInitial { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string Avatar { get; set; } = string.Empty;          // avatar bg color hex
        public string Type { get; set; } = "Message";               // Message | Gift | Tip
        public string Text { get; set; } = string.Empty;
        public string GiftLabel { get; set; } = string.Empty;       // e.g. "Sent Snortle"
        public string GiftEmoji { get; set; } = string.Empty;       // e.g. "🐷"
        public decimal? TipAmount { get; set; }                     // for Tip messages
    }

    // ── Viewers ───────────────────────────────────────────────────────────────
    public class Viewer
    {
        public string Id { get; set; } = string.Empty;
        public string Initial { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;        // for popover
        public string Avatar { get; set; } = string.Empty;          // hex color
        public bool IsActive { get; set; } = true;
        public bool IsStarred { get; set; }
        public string WatchingFor { get; set; } = string.Empty;     // "20 min ago"
    }

    // ── Guest tab ─────────────────────────────────────────────────────────────
    public class GuestRequest
    {
        public string Id { get; set; } = string.Empty;
        public string Initial { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Avatar { get; set; } = string.Empty;
        public string WatchingFor { get; set; } = string.Empty;
    }

    public class InvitedGuest
    {
        public string Id { get; set; } = string.Empty;
        public string Initial { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Avatar { get; set; } = string.Empty;
    }

    // ── Stats ─────────────────────────────────────────────────────────────────
    public class StatsData
    {
        public decimal TotalEarnings { get; set; }
        public int GiftCount { get; set; }
        public int CoinValue { get; set; }
        public decimal TipAmount { get; set; }
        public List<TopGifter> TopGifters { get; set; } = new();

        public int CurrentViewers { get; set; }
        public int PeakViewers { get; set; }
        public int CurrentVsPeakBar { get; set; }                   // 0-100 progress %

        public int TotalGifts { get; set; }
        public decimal GiftsPerMinute { get; set; }

        public string LiveDuration { get; set; } = "00:00";
        public decimal EngagementRatePercent { get; set; }
        public int TotalInteractions { get; set; }
    }

    public class TopGifter
    {
        public int Rank { get; set; }                               // 1, 2, 3, 4, 5
        public string Initial { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Avatar { get; set; } = string.Empty;
        public int GiftCount { get; set; }
        public int CoinTotal { get; set; }
    }
}