using Egyuttesek.Datas;
using Egyuttesek.Models;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace Egyuttesek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        Read read = new Read();
        
        public MainWindow()
        {
            InitializeComponent();
            var list = read.ReadAlbumok();
            datagridview.ItemsSource = list;
        }

        private void lhagomb_Click(object sender, RoutedEventArgs e)
        {
         
        }

        private void tszgomb_Click(object sender, RoutedEventArgs e)
        {
            var kijeloltAlbum = datagridview.SelectedItem as Albumok;

            if (kijeloltAlbum != null)
            {
                string egyuttesNeve = kijeloltAlbum.egyuttes;

                int tagokSzama = read.GetTagokSzama(egyuttesNeve);

                MessageBox.Show($"A(z) {egyuttesNeve} együttes tagjainak száma: {tagokSzama} fő.");
            }
        }
        private void kilepesGomb_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
