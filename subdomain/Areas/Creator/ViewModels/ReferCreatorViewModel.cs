using System.Collections.Generic;

namespace Rotex.Lively.Web.Client.ViewModels
{
    public class ReferCreatorViewModel
    {
        // ── Stats strip ──
        public int ReferredCount { get; set; }
        public int ActiveCount { get; set; }
        public decimal EarnedAmount { get; set; }
        public decimal PendingAmount { get; set; }
        public string Currency { get; set; } = "$";

        // ── Referral link ──
        public string ReferralUrl { get; set; } = string.Empty;

        // ── How it works steps ──
        public List<ReferralStep> Steps { get; set; } = new();

        // ── Program terms ──
        public List<string> ProgramTerms { get; set; } = new();
    }

    public class ReferralStep
    {
        public int Number { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}