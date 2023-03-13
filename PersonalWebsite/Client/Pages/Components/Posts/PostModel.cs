using Microsoft.AspNetCore.Components;

namespace PersonalWebsite.Client.Pages.Components.Posts
{
    public class PostModel : ComponentBase
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
    }

    public interface IActivePostProvider
    {
        public PostModel Post { get; set; }
        public event EventHandler StateChanged;
        void SetActivePost(Guid id);
        void DisableActivePost();
    }
    public class ActivePostProvider : IActivePostProvider
    {
        private PostModel _postModel;

        public event EventHandler StateChanged;

        public PostModel? Post
        {
            get
            {
                Console.WriteLine("get invoked");
                return _postModel;
            }
            set
            {
                Console.WriteLine("set invoked");
                _postModel = value;
            }
        }

        public void SetActivePost(Guid id)
        {
            StateChanged?.Invoke(this, new EventArgs());
            Console.WriteLine("selected id: " + id);
            Post = new PostModel() { Id = id };
        }

        public void DisableActivePost()
        {
            StateChanged?.Invoke(this, new EventArgs());
            Post = default;
        }
    }
}
