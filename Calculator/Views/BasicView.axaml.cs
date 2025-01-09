using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Calculator.Views;

public partial class BasicView : UserControl
{
    public BasicView()
    {
        InitializeComponent();
    }

    private void ShowMenu(object? sender, RoutedEventArgs e)
    {
        if (this.FindControl<Button>("ShowMenuButton") is Button button)
        {
            button.ContextMenu.Open(button);
        }
    }
}
