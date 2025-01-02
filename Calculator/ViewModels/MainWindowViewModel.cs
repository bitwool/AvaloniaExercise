using CommunityToolkit.Mvvm.ComponentModel;

namespace Calculator.ViewModels;

public partial class MainWindowViewModel : ObservableObject
{
    public BasicCalculatorViewModel Calculator { get; }

    public MainWindowViewModel()
    {
        Calculator = new BasicCalculatorViewModel();
    }
}
