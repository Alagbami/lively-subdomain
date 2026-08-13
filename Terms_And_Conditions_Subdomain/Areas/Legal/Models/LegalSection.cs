namespace YourNamespace.Areas.Legal.Models
{
    public class LegalSection
    {
        public int SectionNumber { get; set; }
        public string Title { get; set; } = string.Empty;
        public string NavLabel { get; set; } = string.Empty;
        public string AnchorId { get; set; } = string.Empty;
        public List<LegalClause> Clauses { get; set; } = new();
    }
}