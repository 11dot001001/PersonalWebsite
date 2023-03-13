using PersonalWebsite.Shared.Media;

namespace PersonalWebsite.Shared.Posts
{
    public class PostVm
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public IEnumerable<MediaContent> MediaContents { get; set; }
    }
}
