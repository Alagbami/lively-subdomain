using Microsoft.AspNetCore.Mvc;
using YourNamespace.Areas.Legal.DummyData;

namespace YourNamespace.Areas.Legal.Controllers
{
    [Area("Legal")]
    public class LegalController : Controller
    {
        public IActionResult TermsAndConditions()
        {
            var model = LegalDummyDataService.GetTermsAndConditions();
            return View(model);
        }

        public IActionResult PrivacyPolicy()
        {
            var model = LegalDummyDataService.GetPrivacyPolicy();
            return View(model);
        }

        public IActionResult DownloadPdf(string document)
        {
            // TODO: Backend to implement actual PDF retrieval logic here.
            // 'document' will be either "terms" or "privacy"
            // Example future implementation:
            // var pdfBytes = _pdfService.GetDocument(document);
            // return File(pdfBytes, "application/pdf", $"{document}.pdf");

            // Placeholder until backend is ready
            return NotFound("PDF not yet available.");
        }
    }
}