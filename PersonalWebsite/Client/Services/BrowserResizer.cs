using Microsoft.JSInterop;

namespace PersonalWebsite.Client.Services
{
    public class BrowserResizer
    {
        private readonly IJSRuntime _js;

        public BrowserResizer(IJSRuntime js) => _js = js;

        public async Task<BrowserDimension> GetDimensions()
        {
            return await _js.InvokeAsync<BrowserDimension>("getDimensions");
        }
    }

    public class BrowserDimension
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
