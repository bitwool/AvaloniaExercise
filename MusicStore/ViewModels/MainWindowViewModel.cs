using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MusicStore.Services;

namespace MusicStore.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [RelayCommand]
    private void BuyMusic()
    {
        Debug.WriteLine("BuyMusic");
        this.OpenMusicStoreWindow();
    }
}