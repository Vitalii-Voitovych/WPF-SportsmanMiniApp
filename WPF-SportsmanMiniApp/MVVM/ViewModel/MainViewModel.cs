using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPF_SportsmanMiniApp.Core;
using WPF_SportsmanMiniApp.MVVM.Model;

namespace WPF_SportsmanMiniApp.MVVM.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        private object _currentView;
        public RelayCommand HomeCommand { get; }
        public RelayCommand SportsmanCommand { get; }
        public RelayCommand CloseCommand { get; }
        public RelayCommand MinimizeCommand { get; }
        public HomeViewModel HomeVM { get;  }
        public SpostsmanViewModel SpostsmanVM { get; set; }
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
            Task.Run(() =>
            {
                SpostsmanVM = new SpostsmanViewModel();
            });
            CurrentView = HomeVM;
            HomeCommand = new RelayCommand((o) =>
            {
                CurrentView = HomeVM;
            });
            SportsmanCommand = new RelayCommand((o) =>
            {
                CurrentView = SpostsmanVM;
            });
            CloseCommand = new RelayCommand((o) =>
            {
                if (o is Window window)
                {
                    window.Close();
                }
            });
            MinimizeCommand = new RelayCommand((o) =>
            {
                if (o is Window window)
                {
                    window.WindowState = WindowState.Minimized;
                }
            });
        }
    }
}
