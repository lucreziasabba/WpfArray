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
using LibreriaArray;

namespace WpfArray
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Stampa_Click(object sender, RoutedEventArgs e)
        {
            int n = int.Parse(txtLunghezza.Text);
            int[] array = new int[n];
            ClasseArray.RiempiArray(array);
            txtArray.Text = "";
            for (int i = 0; i < array.Length; i++)
            {
                txtArray.Text += array[i] + " ";
            }
        }
    }
}
