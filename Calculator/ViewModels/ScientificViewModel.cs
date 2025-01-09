using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Calculator.ViewModels;

public partial class ScientificViewModel : ViewModelBase
{
    [ObservableProperty] private string _display = "0";


    private readonly MainWindowViewModel _mainWindowViewModel;

    public ScientificViewModel(MainWindowViewModel mainWindowViewModel)
    {
        _mainWindowViewModel = mainWindowViewModel;
        SwitchViewCommand = mainWindowViewModel.SwitchViewCommand;
    }
    public IRelayCommand<string> SwitchViewCommand { get; set; }

    private double _lastNumber = 0;
    private string _currentOperator = "";
    private bool _newNumber = true;

    [RelayCommand]
    private void Number(string number)
    {
        if (_newNumber)
        {
            Display = number;
            _newNumber = false;
        }
        else
        {
            Display = Display == "0" ? number : Display + number;
        }
    }

    [RelayCommand]
    private void Del()
    {
        if (Display.Length == 1)
        {
            Display = "0";
        }
        else
        {
            Display = Display.Remove(Display.Length - 1);
        }
    }

    [RelayCommand]
    private void Dot()
    {
        if (!_newNumber && !Display.Contains("."))
        {
            Display += ".";
        }
    }

    [RelayCommand]
    private void Operator(string op)
    {
        _lastNumber = double.Parse(Display);
        _currentOperator = op;
        _newNumber = true;
    }

    [RelayCommand]
    private void Clear()
    {
        Display = "0";
        _lastNumber = 0;
        _currentOperator = "";
        _newNumber = true;
    }

    [RelayCommand]
    private void Equal()
    {
        if (string.IsNullOrEmpty(_currentOperator)) return;

        double currentNumber = double.Parse(Display);
        double result = _currentOperator switch
        {
            "+" => _lastNumber + currentNumber,
            "-" => _lastNumber - currentNumber,
            "X" => _lastNumber * currentNumber,
            "÷" => _lastNumber / currentNumber,
            "%" => _lastNumber % currentNumber,
            _ => currentNumber
        };

        Display = result.ToString();
        _currentOperator = "";
        _newNumber = true;
    }
}
