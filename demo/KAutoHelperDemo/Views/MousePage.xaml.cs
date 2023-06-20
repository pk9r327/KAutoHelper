using KAutoHelperDemo.ViewModels;
using KAutoHelperDemo.ViewModels.Examples;
using Microsoft.UI.Xaml.Controls;

namespace KAutoHelperDemo.Views;

public sealed partial class MousePage : Page
{
    public MouseViewModel ViewModel
    {
        get;
    }

    public MouseClickExampleViewModel MouseClickExampleViewModel
    {
        get;
    }

    public ClickMeOutputViewModel ClickMeOutputViewModel
    {
        get;
    }

    public MousePage()
    {
        ViewModel = App.GetService<MouseViewModel>();
        MouseClickExampleViewModel = App.GetService<MouseClickExampleViewModel>();
        ClickMeOutputViewModel = App.GetService<ClickMeOutputViewModel>();
        InitializeComponent();
    }

    private void FontIcon_DropCompleted(Microsoft.UI.Xaml.UIElement sender, Microsoft.UI.Xaml.DropCompletedEventArgs args)
    {
        KAutoHelper.AutoControl.GetCursorPos(out var pos);
        MouseClickExampleViewModel.ClickX = pos.X;
        MouseClickExampleViewModel.ClickY = pos.Y;
    }

    private void ControlExample_DragOver(object sender, Microsoft.UI.Xaml.DragEventArgs e)
    {
        e.DragUIOverride.IsGlyphVisible = false;

        //lag
        //KAutoHelper.AutoControl.GetCursorPos(out var pos);
        //MouseClickExampleViewModel.ClickX = pos.X;
        //MouseClickExampleViewModel.ClickY = pos.Y;
    }
}
