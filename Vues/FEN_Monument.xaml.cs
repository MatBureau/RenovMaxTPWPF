using RenovMaxTP.DAL;
using RenovMaxTP.Modele;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace RenovMaxTP.Vues
{
    /// <summary>
    /// Logique d'interaction pour FEN_Monument.xaml
    /// </summary>
    public partial class FEN_Monument : Window
    {
        public ObservableCollection<Monument> Monuments { get; set; }
        public FEN_Monument()
        {
            InitializeComponent();
            DataContext = this;
            Monuments = new ObservableCollection<Monument>();
        }

        private void BTN_SelectAndBind_Click(object sender, RoutedEventArgs e)
        {
            var monuments = MonumentService.SelectMonument();
            Monuments.Clear();
            foreach (var monument in monuments)
            {
                Monuments.Add(monument);
            }
        }

        private void BTN_AjouterMonument_Click(object sender, RoutedEventArgs e)
        {
            Monument mon = new Monument();
            mon.Budget = int.Parse(TBX_BudgetMonument.Text);
            mon.Nom = TBX_NomMonument.Text;

            mon = MonumentService.AddNewMonument(mon);
            Monuments.Add(mon);
        }

        private void BTN_SansFacture_Click(object sender, RoutedEventArgs e)
        {
            var monuments = MonumentService.SelectFactureLess();
            Monuments.Clear();
            foreach (var monument in monuments)
            {
                Monuments.Add(monument);
            }
        }

        private void BTN_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }
    }
}
