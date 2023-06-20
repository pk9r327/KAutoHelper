using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace KAutoHelperDemo.ViewModels.Examples;
public partial class MouseClickExampleViewModel : ObservableObject
{
    [ObservableProperty]
    private int clickX = 0;

    [ObservableProperty]
    private int clickY = 0;

    [ObservableProperty]
    private KAutoHelper.EMouseKey mouseKey = KAutoHelper.EMouseKey.LEFT;

    [RelayCommand]
    private void Click()
    {
        KAutoHelper.AutoControl.MouseClick(ClickX, ClickY, MouseKey);
    }
}
