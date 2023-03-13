using Microsoft.AspNetCore.Mvc;
using PersonalWebsite.Server.Models;
using PersonalWebsite.Shared.Media;
using PersonalWebsite.Shared.Posts;

namespace PersonalWebsite.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostsController : ControllerBase
    {

        static private readonly List<Post> _posts = new();

        static PostsController()
        {
            const int postsCount = 15;

            var images = new MediaContent[]
            {
                new() 
                {
                    Url = "/images/other.jpg",
                    Orientation = MediaOrientation.Horizontal,
                },
                new() 
                {
                    Url = "/images/IMG_2687.JPG",
                    Orientation = MediaOrientation.Vertical 
                },
                new() 
                {
                    Url = "/images/IMG_1231_fullSize.jpeg",
                    Orientation = MediaOrientation.Horizontal 
                },
                new() 
                {
                    Url = "/images/IMG_7347.jpg",
                    Orientation = MediaOrientation.Vertical 
                },
                new()
                {
                    Url = "/images/IMG_2684.jpg",
                    Orientation = MediaOrientation.Horizontal
                },
                new()
                {
                    Url = "/images/IMG_5182.jpg",
                    Orientation = MediaOrientation.Vertical
                },
                new()
                {
                    Url = "/images/IMG_5199.jpg",
                    Orientation = MediaOrientation.Vertical
                },
                new()
                {
                    Url = "/images/IMG_5207.jpg",
                    Orientation = MediaOrientation.Vertical
                },
                new()
                {
                    Url = "/images/IMG_5233.jpg",
                    Orientation = MediaOrientation.Vertical
                },
                new()
                {
                    Url = "/images/IMG_5344.jpg",
                    Orientation = MediaOrientation.Vertical
                },
                new()
                {
                    Url = "/images/IMG_5418.jpg",
                    Orientation = MediaOrientation.Vertical
                },
                new()
                {
                    Url = "/images/IMG_5527.jpg",
                    Orientation = MediaOrientation.Vertical
                },
                new()
                {
                    Url = "/images/IMG_5950.jpg",
                    Orientation = MediaOrientation.Vertical
                },
                new()
                {
                    Url = "/images/IMG_6067.jpg",
                    Orientation = MediaOrientation.Vertical
                },
                new()
                {
                    Url = "/images/IMG_6182.jpg",
                    Orientation = MediaOrientation.Vertical
                },
            };

            for (int i = 0; i != postsCount; i++)
            {
                _posts.Add(new()
                {
                    Id = Guid.NewGuid(),
                    Title = "Пост 1",
                    Description = "Lorem Ipsum - это текст-\"рыба\", часто используемый в печати и вэб-дизайне. Lorem Ipsum является стандартной \"рыбой\" для текстов на латинице с начала XVI века. В то время некий безымянный печатник создал большую коллекцию размеров и форм шрифтов, используя Lorem Ipsum для распечатки образцов. Lorem Ipsum не только успешно пережил без заметных изменений пять веков, но и перешагнул в электронный дизайн. Его популяризации в новое время послужили публикация листов Letraset с образцами Lorem Ipsum в 60-х годах и, в более недавнее время, программы электронной вёрстки типа Aldus PageMaker, в шаблонах которых используется Lorem Ipsum.",
                    MediaContents = new[] { images[i % images.Length] },
                    CreatedAt = DateTime.Now
                });
            }
            _posts[0].MediaContents = images;
        }

        [HttpGet]
        public IEnumerable<PostListItemVm> GetPosts()
        {
            return _posts.Select(x => new PostListItemVm
            {
                Id = x.Id,
                Title = x.Title,
                MediaContent = x.MediaContents.First()
            });
        }

        [HttpGet("{id}")]
        public PostVm GetPost(Guid id)
        {
            var post = _posts.FirstOrDefault(x => x.Id == id);

            if (post == default)
                return default;

            return new PostVm
            {
                Title = post.Title,
                Description = post.Description,
                CreatedAt = post.CreatedAt,
                MediaContents = post.MediaContents,
            };
        }
    }
}
