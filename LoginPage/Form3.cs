using System.Windows.Forms;

namespace LoginPage
{
    public partial class Form3 : Form
    {
        public Form3(int errorType)
        {
            InitializeComponent();
            if (errorType == 1)
            {
                label1.Text = "Check your Password";
            }
            else
            {
                label1.Text = "Check your Username";
            }
        }
    }
}
