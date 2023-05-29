using Microsoft.AspNetCore.Mvc;
using PersonalWebsite.Shared.Posts;

namespace PersonalWebsite.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumsController : ControllerBase
    {
        static private readonly AlbumListItemVm[] _albums;

        static AlbumsController()
        {
            _albums = new AlbumListItemVm[]
            {
                new AlbumListItemVm()
                {
                    Id = Guid.NewGuid(),
                    Title = "Alpaca farm",
                    CreatedAt= DateTime.Now,
                    MediaUrl = "/images/alpaca.jpg",
                },
                new AlbumListItemVm()
                {
                    Id = Guid.NewGuid(),
                    Title = "Forest",
                    CreatedAt= DateTime.Now.AddYears(-1),
                    MediaUrl = "/images/other.jpg",
                },
                new AlbumListItemVm()
                {
                    Id = Guid.NewGuid(),
                    Title = "Alpaca farm",
                    CreatedAt= DateTime.Now,
                    MediaUrl = "/images/alpaca.jpg",
                }
            };
        }

        public Task<IEnumerable<AlbumListItemVm>> GetAlbums() => Task.FromResult((IEnumerable<AlbumListItemVm>)_albums);
    }
}
