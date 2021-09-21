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
        public Form3 errorForm = new();
        private bool userFound = false;
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(string username, string password)
        {
            InitializeComponent();
            for (int i = 0; i < accsArray.Length; i++)
            {
                if (username == accsArray[i].Username)
                {
                    if (password == accsArray[i].Password)
                    {
                        ShowMeStuff(i);
                        userFound = true;
                        break;
                    }
                    else
                    {
                        errorForm.Show();
                        this.Close();
                        break;
                    }
                }
            }
            if (!userFound)
            {
                errorForm.Show();
                this.Close();
            }

        }

        static readonly AccountInfo account1 = new("Tom", 39, "BigBro", "come2me", "25 Hawaii", "Male", "Default");
        static readonly AccountInfo account2 = new("Tanya", 35, "BigSis", "memeGirl4", "12 Urugai", "Female", "Dark");
        static readonly AccountInfo account3 = new("Admin", 34, "test", "test", "002 testing street", "Male", "Orange");
        static readonly AccountInfo account4 = new("Hugho", 36, "Hulk", "come2me", "25 Hawaii", "Male", "Dark");
        static readonly AccountInfo account5 = new("Jaklin", 37, "Blondy", "ImPreattty", "52 HireAndTher", "Female", "Light");

        AccountInfo[] accsArray = new AccountInfo[] { account1, account2, account3, account4, account5 };

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            Form2 objUI = new();
            objUI.Show();
        }
        private void ShowMeStuff(int index)
        {
            nameTextBox.Text = accsArray[index].Name;
            ageTextBox.Text = accsArray[index].Age.ToString();
            usernameTextBox.Text = accsArray[index].Username;
            passwordTextBox.Text = accsArray[index].Password;
            adressTextBox.Text = accsArray[index].Adress;
            themeTextBox.Text = accsArray[index].Theme;
            genderTextBox.Text = accsArray[index].Gender;
            searchBtn.Visible = false;
        }
    }
}
