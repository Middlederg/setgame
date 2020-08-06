using System.Collections.Generic;

namespace Set.Core.ViewModels
{
    public interface IPlayersViewModel : IWindowViewModel
    {
        IEnumerable<Player> Players { get; set; }
        Player SelectedPlayer { get; }
    }
}
