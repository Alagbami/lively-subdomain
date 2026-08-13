namespace YourNamespace.Areas.Legal.Models
{
    public class LegalClause
    {
        public string Number { get; set; } = string.Empty;
        public string Text { get; set; } = string.Empty;
        public List<LegalSubClause> SubClauses { get; set; } = new();
    }
}