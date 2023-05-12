using GUSAreas.Models;
using GUSAreas.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GUSAreas.Views
{
    /// <summary>
    /// Logika interakcji dla klasy AreasTableView.xaml
    /// </summary>
    public partial class AreasTableView : Window
    {
        public AreasTableView()
        {
            InitializeComponent();
        }
        private async void WindowLoaded(object sender, RoutedEventArgs e)
        {
            await ((AreasTableViewModel)DataContext).GetAreasAsync();
        }
    }
}
