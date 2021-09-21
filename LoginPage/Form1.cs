using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static AccountInfo account1 = new AccountInfo("Tom", 39, "BigBro", "come2me", "25 Hawaii", "Male");
        static AccountInfo account2 = new AccountInfo("Tanya", 35, "BigSis", "memeGirl4", "12 Urugai", "Female");
        static AccountInfo account3 = new AccountInfo("Hugho", 36, "Hulk", "come2me", "25 Hawaii", "Male");
        static AccountInfo account4 = new AccountInfo("Jaklin", 37, "Blondy", "ImPreattty", "52 HireAndTher", "Female");

        AccountInfo[] accsArray = new AccountInfo[] { account1, account2, account3, account4 };
        int arrayIndex = 0;

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (arrayIndex == accsArray.Length - 1) 
            {
                arrayIndex = 0;
            }
            else
            {
            arrayIndex++;
            }
            showMeStuff();
        }
        private void showMeStuff()
        {
            nameTextBox.Text = accsArray[arrayIndex].Name;
            ageTextBox.Text = accsArray[arrayIndex].Age.ToString();
        }
    }
}
