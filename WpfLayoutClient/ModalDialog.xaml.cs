using System.Windows;

namespace WpfLayoutClient
{
    public partial class ModalDialog : Window
    {
        public ModalDialog()
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

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }


    }
}
