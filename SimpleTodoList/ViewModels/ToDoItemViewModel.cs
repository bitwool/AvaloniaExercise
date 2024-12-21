using CommunityToolkit.Mvvm.ComponentModel;
using SimpleTodoList.Models;

namespace SimpleTodoList.ViewModels;

public partial class ToDoItemViewModel : ViewModelBase
{
    [ObservableProperty] private bool _isChecked;

    [ObservableProperty] private string? _content;

    public ToDoItemViewModel()
    {
    }

    public ToDoItemViewModel(ToDoItem item)
    {
        // Init the properties with the given values
        IsChecked = item.IsChecked;
        Content = item.Content;
    }

    public ToDoItem GetToDoItem()
    {
        return new ToDoItem()
        {
            IsChecked = this.IsChecked,
            Content = this.Content
        };
    }
}