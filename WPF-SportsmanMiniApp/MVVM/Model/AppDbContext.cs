using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_SportsmanMiniApp.MVVM.Model
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("AppDbConnection") { }

        public virtual DbSet<Sportsman> Sportsmen { get; set; } 
    }
}
