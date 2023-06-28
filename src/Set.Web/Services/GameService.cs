using Blazored.LocalStorage;

namespace Set.Web.Services;

public class GameService
{
    private readonly ILocalStorageService localStorageService;

    public GameService(ILocalStorageService localStorageService)
    {
        this.localStorageService = localStorageService;
    }

    public async Task<GameOptionsModel> GetOptions()
    {
        var options = await localStorageService.GetItemAsync<GameOptionsModel>(nameof(GameOptionsModel));
        if (options is null)
        {
            return new GameOptionsModel();
        }
        return options;
    }

    public async Task SaveOptions(GameOptionsModel options)
    {
        await localStorageService.SetItemAsync(nameof(GameOptionsModel), options);
    }

    public async Task<PlayerModel> GetPlayer()
    {
        var name = await localStorageService.GetItemAsync<PlayerModel>(nameof(PlayerModel));
        if (name is null)
        {
            return new PlayerModel();
        }
        return name;
    }

    public async Task SavePlayer(PlayerModel player)
    {
        await localStorageService.SetItemAsync<PlayerModel>(nameof(PlayerModel), player);
    }
}
