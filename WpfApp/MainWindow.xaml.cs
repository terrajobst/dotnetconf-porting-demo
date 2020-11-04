using System.Windows;

using ClassLibrary;

namespace WpfApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            TextBox.Text = NorthwindDb.GetData();
        }
    }
}
