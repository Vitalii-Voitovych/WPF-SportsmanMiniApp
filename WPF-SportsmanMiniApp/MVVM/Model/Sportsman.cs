using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_SportsmanMiniApp.MVVM.Model
{
    public class Sportsman
    {
        public string FullName { get; set; }
        public DateTime Birthday { get; set; }
        public string Sport { get; set; }
        public int YearsInSport { get; set; }
    }
}
