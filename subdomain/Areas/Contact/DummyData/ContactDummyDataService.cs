using Rotex.Lively.Web.Client.Areas.Contact.Models;
using System.Collections.Generic;

namespace Rotex.Lively.Web.Client.Areas.Contact.DummyData
{
    public static class ContactDummyDataService
    {
        public static List<ContactRequestType> GetRequestTypes()
        {
            return new List<ContactRequestType>
            {
                new ContactRequestType { Id = 1, Name = "Submit a DSA Report" },
                new ContactRequestType { Id = 2, Name = "Trust & Safety Approval" }
            };
        }

        public static List<string> GetRegions()
        {
            return new List<string> { "Africa", "Europe", "North America", "South America", "Asia", "Oceania" };
        }

        public static List<string> GetConfirmationOptions()
        {
            return new List<string> { "Yes", "No" };
        }

        public static List<string> GetHelpOptions()
        {
            return new List<string>
            {
                "Seller Performance Rate",
                "Policy Violation/Notification",
                "Account Access",
                "Others"
            };
        }

        public static List<string> GetCountries()
        {
            return new List<string>
            {
                "Afghanistan", "Aland Islands", "Albania", "Algeria", "American Samoa", "Andorra", "Angola", "Anguilla", "Antarctica", "Antigua and Barbuda", "Argentina", "Armenia", "Aruba", "Australia", "Austria", "Azerbaijan", "Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bermuda", "Bhutan", "Bolivia", "Bonaire, Sint Eustatius and Saba", "Bosnia and Herzegovina", "Botswana", "Bouvet Island", "Brazil", "British Indian Ocean Territory"
            };
        }

        public static List<string> GetAppealOptions()
        {
            return new List<string> { "Yes", "No" };
        }
    }
}
