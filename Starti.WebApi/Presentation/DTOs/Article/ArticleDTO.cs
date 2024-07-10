namespace Starti.WebApi.Presentation.Presenters.DTOs.Article
{
    public class ArticleDTO
    {
        public string? id { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public string author { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}
