using ADO.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_Proj_Presentation
{
    public partial class Login : Form
    {
        UserService userService;
        string username;
        string password;
        public Login()
        {
            InitializeComponent();
            userService = new UserService();
           
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        private void Login_Btn_Click(object sender, EventArgs e)
        {
            username = UserName_TXT.Text.ToString();
            password = Password_TXT.Text.ToString();
            DataTable Registered_Users = userService.searchUsers(username, password);
         
            if (Registered_Users.Rows.Count > 0) {
                MessageBox.Show($"Welcome back {username}");
               
                string role = Registered_Users.Rows[0]["Role"].ToString();
                if(role == "Admin")
                {

                    Admin admin = new Admin();
                    admin.Show();
                    this.Close();

                }
                else
                {
                    int userId = (int)Registered_Users.Rows[0]["userid"];
                    User user = new User(userId);

                    user.Show();

                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }

        }

    }
}
