using Set.Core;

namespace Set.Forms.ViewModels
{
    public interface IPlayerNameViewModel
    {
        string InputName { get; set; }
        void SetInfo(Score score, Time time);
    }
}
