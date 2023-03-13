using PersonalWebsite.Shared.Media;

namespace PersonalWebsite.Server.Models
{
    public class Post
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public IEnumerable<MediaContent> MediaContents { get; set; }
    }
}
