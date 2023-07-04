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

namespace Wpf_Framework
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String Nama_Mahasiswa = TB_Nama.Text;
            String Program_Studi = TB_Prodi.Text;

            MessageBox.Show("Nama :  "+Nama_Mahasiswa+ "\n" +
                "Program Studi : " +Program_Studi);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TB_Nama.Text = "";
            TB_Prodi.Text = "";
        }
    }
}
