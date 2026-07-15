using System.Collections.Generic;
using Rotex.Lively.Web.Client.ViewModels;

namespace Rotex.Lively.Web.Client.DummyData
{
    public static class ReferCreatorData
    {
        public static ReferCreatorViewModel Get()
        {
            return new ReferCreatorViewModel
            {
                ReferredCount = 12,
                ActiveCount = 8,
                EarnedAmount = 1_400m,
                PendingAmount = 400m,
                Currency = "$",
                ReferralUrl = "www.LivelyAfrica.com/lawrence",

                Steps = new List<ReferralStep>
                {
                    new() { Number=1, Title="Share your link",
                            Description="Send your unique referral link to other creators" },
                    new() { Number=2, Title="They sign up",
                            Description="New creator joins using your link and completes their profile setup" },
                    new() { Number=3, Title="They go live",
                            Description="Creator completes their first live show (minimum 30 minutes)" },
                    new() { Number=4, Title="You earn $200",
                            Description="Bonus is added to your account within 7 days" }
                },

                ProgramTerms = new List<string>
                {
                    "Referral bonus paid after referred creator completes first live show",
                    "Referred creator must be new to Lively (no existing account)",
                    "Minimum 30-minute live show duration required",
                    "Payment processed within 7 business days",
                    "Subject to fraud prevention review"
                }
            };
        }
    }
}