using System.Windows.Forms;

using ClassLibrary;

namespace WindowsFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            textBox1.Text = NorthwindDb.GetData();
        }
    }
}
