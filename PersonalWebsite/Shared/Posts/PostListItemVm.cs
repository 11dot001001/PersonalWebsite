using PersonalWebsite.Shared.Media;

namespace PersonalWebsite.Shared.Posts
{
    public class PostListItemVm
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public MediaContent MediaContent { get; set; }
    }
}
