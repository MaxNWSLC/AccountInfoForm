using System;
using System.Windows.Forms;

namespace LoginPage
{
    public partial class Form1 : Form
    {
        private bool wrongPass = false;
        private bool userFound = false;
        public bool UserFound { get => userFound; set => userFound = value; }

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
                        UserFound = true;
                        break;
                    }
                    else
                    {
                        Form3 errorForm = new(1);
                        errorForm.Show();
                        wrongPass = true;
                        break;
                    }
                }
            }
            if (!userFound && !wrongPass)
            {
                Form3 errorForm = new(0);
                errorForm.Show();
            }
        }

        static readonly AccountClass account1 = new("Tom", 39, "BigBro", "come2me", "25 Hawaii", "Male", "Default");
        static readonly AccountClass account2 = new("Tanya", 35, "BigSis", "memeGirl4", "12 Urugai", "Female", "Dark");
        static readonly AccountClass account3 = new("Admin", 34, "test", "test", "002 testing street", "Male", "Orange");
        static readonly AccountClass account4 = new("Hugho", 36, "Hulk", "come2me", "25 Hawaii", "Male", "Dark");
        static readonly AccountClass account5 = new("Jaklin", 37, "Blondy", "ImPreattty", "52 HireAndTher", "Female", "Light");
        readonly AccountClass[] accsArray = new AccountClass[] { account1, account2, account3, account4, account5 };

        private void ShowMeStuff(int index)
        {
            nameTextBox.Text = accsArray[index].Name;
            ageTextBox.Text = accsArray[index].Age.ToString();
            usernameTextBox.Text = accsArray[index].Username;
            passwordTextBox.Text = accsArray[index].Password;
            adressTextBox.Text = accsArray[index].Adress;
            themeTextBox.Text = accsArray[index].Theme;
            genderTextBox.Text = accsArray[index].Gender;
        }
    }
}
