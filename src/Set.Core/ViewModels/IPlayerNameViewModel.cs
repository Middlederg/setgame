namespace Set.Core.ViewModels
{
    public interface IPlayerNameViewModel : IWindowViewModel
    {
        string InputName { get; set; }
        void SetInfo(Score score, Time time);
    }
}
