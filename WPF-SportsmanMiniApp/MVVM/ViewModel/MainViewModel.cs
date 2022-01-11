using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_SportsmanMiniApp.Core;
using WPF_SportsmanMiniApp.MVVM.Model;

namespace WPF_SportsmanMiniApp.MVVM.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        private object _currentView;
        public RelayCommand HomeCommand { get; set; }
        public RelayCommand ContactCommand { get; set; }
        public RelayCommand SportsmanCommand { get; }
        public HomeViewModel HomeVM { get; set; }
        public SpostsmanViewModel SpostsmanVM { get; set; }
        public ContactViewModel ContactVM { get; set; }
        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            SpostsmanVM = new SpostsmanViewModel();
            ContactVM = new ContactViewModel();
            CurrentView = HomeVM;
            HomeCommand = new RelayCommand((o) =>
            {
                CurrentView = HomeVM;
            });
            ContactCommand = new RelayCommand((o) =>
            {
                CurrentView = ContactVM;
            });
            SportsmanCommand = new RelayCommand((o) =>
            {
                CurrentView = SpostsmanVM;
            });
        }
    }
}
