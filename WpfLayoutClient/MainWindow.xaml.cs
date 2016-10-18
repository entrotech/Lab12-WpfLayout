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

namespace WpfLayoutClient
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

        private void CanvasButton_Click(object sender, RoutedEventArgs e)
        {
            CanvasWindow win = new CanvasWindow();
            win.Owner = this;
            win.Show();
        }

        private void WrapPanelButton_Click(object sender, RoutedEventArgs e)
        {
            var win = new WrapPanelWindow();
            win.Owner = this;
            win.Show();
        }

        private void DockPanelButton_Click(object sender, RoutedEventArgs e)
        {
            var win = new DockPanelWindow();
            win.Owner = this;
            win.Show();
        }

        private void GridPanelButton_Click(object sender, RoutedEventArgs e)
        {
            var win = new GridWindow();
            win.Owner = this;
            win.Show();
        }

        private void NewTopWindow_Click(object sender, RoutedEventArgs e)
        {
            var w = new TopWindow();
            w.Show();
        }

        private void NewDialog_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new ModalDialog();
            if (dlg.ShowDialog() == true)
            {
                MessageBox.Show("Dialog returned true.");
            }
            else
            {
                MessageBox.Show("Dialog returned false.");
            }
        }
    }
}
