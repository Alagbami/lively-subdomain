using Rotex.Lively.Web.Client.Areas.Contact.Models;
using System.Collections.Generic;

namespace Rotex.Lively.Web.Client.Areas.Contact.ViewModels
{
    public class ContactViewModel
    {
        public List<ContactRequestType> RequestTypes { get; set; }
        public int? SelectedRequestTypeId { get; set; }

        // Generic / Shared Fields
        public string EmailAddress { get; set; }
        public string Username { get; set; }
        public string UserId { get; set; }
        public string IssueDescription { get; set; }
        public string AdditionalDetails { get; set; }

        // DSA Report Specific Fields
        public string Region { get; set; }
        public List<string> Regions { get; set; }
        public string IsIllegalContent { get; set; }
        public List<string> ConfirmationOptions { get; set; }

        // Trust & Safety Fields
        public string HelpOption { get; set; }
        public List<string> HelpOptions { get; set; }
        public string Country { get; set; }
        public List<string> Countries { get; set; }
        public string AccountHealthIssueName { get; set; }
        public string OrderIdsToReview { get; set; }
        public string IsAppealing { get; set; }
        public List<string> AppealOptions { get; set; }
        public string BriefDescription { get; set; } // Specific to T&S if different from IssueDescription
    }
}
