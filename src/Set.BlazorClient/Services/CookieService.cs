using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace Set.BlazorClient.Services
{
    public class CookieService
    {
        public const string PlayerNameCookie = "Set.PlayerName";

        private readonly IJSRuntime jsRuntime;

        public CookieService(IJSRuntime jsRuntime)
        {
            this.jsRuntime = jsRuntime;
        }

        public async void CreateCookie(string name, string value, int days)
        {
            await jsRuntime.InvokeAsync<string>("methods.CreateCookie", name, value, days);
        }

        public async Task<string> RetrieveCookie(string name)
        {
            string result = await jsRuntime.InvokeAsync<string>("methods.GetCookieValue", name);
            return result ?? "Player 1";
        }
    }
}
