using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace Calculator.Views;

public partial class ScientificView : UserControl
{
    public ScientificView()
    {
        InitializeComponent();
    }

    private void ShowMenu(object sender, RoutedEventArgs e)
    {
        if (this.FindControl<Button>("ShowMenuButton") is Button button)
        {
            button.ContextMenu.Open(button);
        }
    }
}

