using System.Diagnostics;
using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Calculator.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    private object _currentView;

    public object CurrentView
    {
        get => _currentView;
        set => SetProperty(ref _currentView, value);
    }


    public MainWindowViewModel()
    {
        CurrentView = new BasicViewModel(this);
    }

    [RelayCommand]
    private void SwitchView(string viewName)
    {
        Debug.WriteLine("viewName" + viewName);
        if (viewName == "Basic")
        {
            CurrentView = new BasicViewModel(this);
        }
        else if (viewName == "Scientific")
        {
            CurrentView = new ScientificViewModel(this);
        }
    }
}
