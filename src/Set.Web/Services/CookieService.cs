using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace Set.Web.Services
{
    public class CookieService
    {
        public const string PlayerNameCookie = "Set.PlayerName";
        public const int DefaultDuration = 30;
        public const string DefaultPlayerName = "Player 1";

        private readonly IJSRuntime jsRuntime;

        public CookieService(IJSRuntime jsRuntime)
        {
            this.jsRuntime = jsRuntime;
        }

        public async Task CreateCookie(string name, string value, int days = 30)
        {
            await jsRuntime.InvokeAsync<string>("methods.CreateCookie", name, value, days);
        }

        public async Task<string> RetrieveCookie(string name)
        {
            string result = await jsRuntime.InvokeAsync<string>("methods.GetCookieValue", name);
            return result ?? DefaultPlayerName;
        }
    }
}
