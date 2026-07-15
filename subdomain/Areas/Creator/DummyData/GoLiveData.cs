using System;
using System.Collections.Generic;
using Rotex.Lively.Web.Client.ViewModels;

namespace Rotex.Lively.Web.Client.DummyData
{
    public static class GoLiveData
    {
        public static GoLiveViewModel Get(string? showId = null)
        {
            return new GoLiveViewModel
            {
                ShowId = showId ?? "live-1",
                ShowTitle = "First bank - End of the year party",
                Category = "Music & Performance",
                StreamUrl = string.Empty,
                PosterUrl = "/images/shows/live-poster.jpg",
                StartedAt = DateTime.UtcNow.AddMinutes(-2.5),

                CurrentViewers = 14,
                PeakViewers = 50,
                TotalGifts = 3,
                TipsAmount = 140m,
                CoinsAmount = 6_000m,
                Currency = "$",

                // ── Chat ──
                ChatMessages = new List<ChatMessage>
                {
                    new() { UserInitial="T", UserName="Tomilola",  Avatar="#a855f7", Type="Message", Text="" },
                    new() { UserInitial="E", UserName="Esther",    Avatar="#a855f7", Type="Gift",    GiftLabel="Sent Snortle", GiftEmoji="🐷" },
                    new() { UserInitial="A", UserName="Adedeji",   Avatar="#a855f7", Type="Message", Text="" },
                    new() { UserInitial="E", UserName="Esther",    Avatar="#a855f7", Type="Gift",    GiftLabel="Sent Crown",   GiftEmoji="👑" },
                    new() { UserInitial="A", UserName="Adedeji",   Avatar="#a855f7", Type="Message", Text="" },
                    new() { UserInitial="A", UserName="Adeagbo",   Avatar="#a855f7", Type="Tip",     Text="Tipped",            TipAmount=1_000m },
                    new() { UserInitial="A", UserName="Adedeji",   Avatar="#a855f7", Type="Message", Text="🥰" },
                    new() { UserInitial="A", UserName="Adeagbo",   Avatar="#a855f7", Type="Tip",     Text="Tipped",            TipAmount=1_000m },
                    new() { UserInitial="A", UserName="Adedeji",   Avatar="#a855f7", Type="Message", Text="" },
                    new() { UserInitial="E", UserName="Esther",    Avatar="#a855f7", Type="Gift",    GiftLabel="Sent Heart",   GiftEmoji="❤️" },
                    new() { UserInitial="A", UserName="Adeagbo",   Avatar="#a855f7", Type="Message", Text="You're so amazing 🔥" },
                    new() { UserInitial="A", UserName="Adeagbo",   Avatar="#a855f7", Type="Message", Text="I love your talent 😍" },
                    new() { UserInitial="E", UserName="Emmanuel",  Avatar="#a855f7", Type="Tip",     Text="Tipped",            TipAmount=4_000m }
                },

                // ── Viewers ──
                Viewers = new List<Viewer>
                {
                    new() { Id="v1", Initial="E", Name="Esther",      FullName="Esther James", Avatar="#a855f7", IsActive=true,  IsStarred=true,  WatchingFor="Watching · 20 min ago" },
                    new() { Id="v2", Initial="J", Name="Jude Watkins",                          Avatar="#a855f7", IsActive=true,  IsStarred=true,  WatchingFor="Watching · 25 min ago" },
                    new() { Id="v3", Initial="A", Name="Adeagbo",                               Avatar="#a855f7", IsActive=true,  IsStarred=true,  WatchingFor="Watching · 25 min ago" },
                    new() { Id="v4", Initial="F", Name="Fred James",                            Avatar="#a855f7", IsActive=true,  IsStarred=false, WatchingFor="Watching · 25 min ago" },
                    new() { Id="v5", Initial="A", Name="Adedeji",                               Avatar="#a855f7", IsActive=false, IsStarred=false, WatchingFor="Watching · 25 min ago" },
                    new() { Id="v6", Initial="T", Name="Tomilola",                              Avatar="#a855f7", IsActive=false, IsStarred=false, WatchingFor="Watching · 25 min ago" }
                },

                // ── Guest tab ──
                GuestRequests = new List<GuestRequest>
                {
                    new() { Id="g1", Initial="E", Name="Esther",  Avatar="#a855f7", WatchingFor="Watching · 20 min ago" },
                    new() { Id="g2", Initial="A", Name="Adedeji", Avatar="#a855f7", WatchingFor="Watching · 25 min ago" },
                    new() { Id="g3", Initial="A", Name="Adedeji", Avatar="#a855f7", WatchingFor="Watching · 25 min ago" }
                },
                InvitedGuests = new List<InvitedGuest>
                {
                    new() { Id="ig1", Initial="A", Name="Adedeji", Avatar="#a855f7" }
                },
                InviteableViewers = new List<Viewer>
                {
                    new() { Id="iv1", Initial="A", Name="Adedeji", Avatar="#a855f7", WatchingFor="Watching · 25 min ago" },
                    new() { Id="iv2", Initial="A", Name="Adedeji", Avatar="#a855f7", WatchingFor="Watching · 25 min ago" }
                },

                // ── Stats ──
                Stats = new StatsData
                {
                    TotalEarnings = 838m,
                    GiftCount = 3,
                    CoinValue = 200,
                    TipAmount = 838m,
                    TopGifters = new List<TopGifter>
                    {
                        new() { Rank=1, Initial="E", Name="Esther",  Avatar="#a855f7", GiftCount=6, CoinTotal=200 },
                        new() { Rank=2, Initial="A", Name="Adedeji", Avatar="#a855f7", GiftCount=6, CoinTotal=160 },
                        new() { Rank=3, Initial="A", Name="Adeagbo", Avatar="#a855f7", GiftCount=5, CoinTotal=120 },
                        new() { Rank=4, Initial="A", Name="Adeagbo", Avatar="#a855f7", GiftCount=5, CoinTotal=120 },
                        new() { Rank=5, Initial="A", Name="Adeagbo", Avatar="#a855f7", GiftCount=5, CoinTotal=120 }
                    },

                    CurrentViewers = 14,
                    PeakViewers = 50,
                    CurrentVsPeakBar = 28,

                    TotalGifts = 126,
                    GiftsPerMinute = 3.6m,

                    LiveDuration = "02:31",
                    EngagementRatePercent = 19.9m,
                    TotalInteractions = 518
                }
            };
        }
    }
}