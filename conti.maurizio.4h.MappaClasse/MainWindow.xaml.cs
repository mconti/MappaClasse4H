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

using conti.maurizio._4h.MappaClasse.Models;

namespace conti.maurizio._4h.MappaClasse
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btn10.Tag = new Utente { Nome = "Maurizio", Inventario = "inv1234", Foto = "foto1.jpg" };
            btn11.Tag = new Utente { Nome = "Giovanni", Inventario = "inv5678", Foto = "foto2.jpg" };
            btn12.Tag = new Utente { Nome = "Daniele", Inventario = "inv91011", Foto = "foto3.jpg" };

        }

        private void OnClick(object sender, RoutedEventArgs e)
        {
            if (sender != null)
            {
                Button b = sender as Button;
                if (b != null)
                {
                    if (b.Tag != null)
                    {
                        Utente u = b.Tag as Utente;
                        MessageBox.Show($"Hello {u.Nome} {u.Inventario} {u.Foto}");
                    }
                    else
                    {
                        MessageBox.Show($"qui Tag era null... ");
                    }
                }
            }
            else
            {
                MessageBox.Show($"qui sender era null... ");
            }
        }
    }
}
