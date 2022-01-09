using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_SportsmanMiniApp.Core;
using WPF_SportsmanMiniApp.MVVM.Model;

namespace WPF_SportsmanMiniApp.MVVM.ViewModel
{
    public class SpostsmanViewModel : ObservableObject
    {
        private int index = 0;
        public IList<Sportsman> Sportsmen { get; set; } = new ObservableCollection<Sportsman>();
        private Sportsman currentSportsman;
        public Sportsman CurrentSportsman
        {
            get => currentSportsman;
            set
            {
                currentSportsman = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand PrevBtnCommand { get; set; }
        public RelayCommand NextBtnCommand { get; set; }

        public SpostsmanViewModel()
        {
            Sportsmen.Add(new Sportsman()
            {
                FullName = "Vitalii Voitovych",
                Birthday = DateTime.Parse("13/06/2003"),
                Sport = "Football",
                YearsInSport = 3
            });
            Sportsmen.Add(new Sportsman()
            {
                FullName = "Kachmar Roman",
                Birthday = DateTime.Parse("07/11/2002"),
                Sport = "Volleyball",
                YearsInSport = 3
            });
            Sportsmen.Add(new Sportsman()
            {
                FullName = "Gubich Nazar",
                Birthday = DateTime.Parse("01/10/2002"),
                Sport = "Football",
                YearsInSport = 4
            });
            PrevBtnCommand = new RelayCommand((o) =>
            {
                if (index > 0)
                {
                    CurrentSportsman = Sportsmen[--index];
                }
            });
            NextBtnCommand = new RelayCommand((o) =>
            {
                if (index < Sportsmen.Count - 1)
                {
                    CurrentSportsman = Sportsmen[++index];
                }
            });
            CurrentSportsman = Sportsmen[0];
        }
    }
}
