using System;
using System.Windows.Forms;

namespace LoginPage
{
    public partial class Form2 : Form
    {
        public string username;
        public string password;
        public Form2()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            username = usernameTextBox.Text;
            password = passwordTextBox.Text;

            Form1 check = new(username, password);
            if (check.UserFound)
            {
                check.Show();
            }
        }
    }
}
