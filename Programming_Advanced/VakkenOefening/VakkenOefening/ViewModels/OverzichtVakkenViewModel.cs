using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VakkenOefening.ViewModels
{
    public partial class OverzichtVakkenViewModel : BaseViewModel
    {
        private VakRepository _repo;

        [ObservableProperty]
        private ObservableCollection<Vak> vakken;

        public OverzichtVakkenViewModel(VakRepository Repo)
        {
            Title = "Vakken";
            _repo = Repo;
        }

        [RelayCommand]
        public void ToonWerknemers()
        {
            Vakken = new ObservableCollection<Vak>(_repo.GetVakken());
        }
    }
}