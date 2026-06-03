using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBATIN.model
{
    public class User
    {
        private int id_user;
        private string username;
        private string password;
        private string role;

        // Constructor Kosong
        public User() { }

        // Constructor dengan Parameter
        public User(int id_user, string username, string password, string role)
        {
            this.id_user = id_user;
            this.username = username;
            this.password = password;
            this.role = role;
        }

        // Getter & Setter Properti
        public int IdUser
        {
            get { return id_user; }
            set { id_user = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Role
        {
            get { return role; }
            set { role = value; }
        }
    }
}