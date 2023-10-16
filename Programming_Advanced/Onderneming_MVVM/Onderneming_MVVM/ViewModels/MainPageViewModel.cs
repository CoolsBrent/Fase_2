using System;
using Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Onderneming_MVVM.Data;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;

namespace Onderneming_MVVM.ViewModels
{
    public partial class MainPageViewModel : BaseViewModel
    {
        private WerknemerRepository _repo;

        [ObservableProperty]
        private ObservableCollection<Werknemer> werknemers;

        public MainPageViewModel(WerknemerRepository Repo)
        {
            Title = "Werknemers";
            _repo = Repo;
        }

        [RelayCommand]
        public void ToonWerknemers()
        {
            Werknemers = new ObservableCollection<Werknemer>(_repo.GetWerknemers());
        }
    }
}