using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace KAutoHelperDemo.ViewModels.Examples;
public partial class ClickMeOutputViewModel : ObservableObject
{
    private int count = 0;

    [ObservableProperty]
    private string _clickMeText = "Click Me";

    [RelayCommand]
    private void Click()
    {
        count++;
        ClickMeText = $"Click Me {count}";
    }
}
