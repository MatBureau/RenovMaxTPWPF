using RenovMaxTP.Utils;
using RenovMaxTP.Vues;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RenovMaxTP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            try
            {
                var dbConnector = new DBConnector();
                DBConnector.Connection.Open();
                MessageBox.Show("Etat de la connexion à la bdd : " + DBConnector.Connection.State.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BTN_Monument_Click(object sender, RoutedEventArgs e)
        {
            FEN_Monument fen_mo = new FEN_Monument();
            fen_mo.Show();
            //this.WindowState = WindowState.Minimized; 
        }

        private void BTN_Close_Click(object sender, RoutedEventArgs e)
        {
            DBConnector.Connection.Close();
            this.Close();
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }
    }
}
