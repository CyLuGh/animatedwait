using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace Demo
{
    public class DemoViewModel : ReactiveObject
    {
        [Reactive] public bool ShowHourglass { get; set; } = true;
    }
}
