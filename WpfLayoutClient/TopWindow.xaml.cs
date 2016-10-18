using System.Windows;

namespace WpfLayoutClient
{
    public partial class TopWindow : Window
    {
        public TopWindow()
        {
            InitializeComponent();
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
