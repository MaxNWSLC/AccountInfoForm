using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginPage
{
    class AccountInfo
    {
        private string name;
        private int    age;
        private string username;
        private string password;
        private string adress;
        private string gender;
        private string theme;

        public AccountInfo(string name, int age, string username, string password, string adress, string gender, string theme)
        {
            this.name = name;
            this.age = age;
            this.username = username;
            this.password = password;
            this.adress = adress;
            this.gender = gender;
            this.theme = theme;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Adress { get => adress; set => adress = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Theme { get => theme; set => theme = value; }
    }
}
