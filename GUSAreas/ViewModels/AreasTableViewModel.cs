using Caliburn.Micro;
using GUSAreas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUSAreas.ViewModels
{
    public class AreasTableViewModel : Screen
    {
        public BindableCollection<AreaModel> Areas { get; set; } = new BindableCollection<AreaModel>();

        public async Task GetAreasAsync()
        {
            DataAccess dataAccess = new DataAccess();
            Areas = new BindableCollection<AreaModel>(await dataAccess.GetAreasData());
            NotifyOfPropertyChange(nameof(Areas));
        }
    }
}
