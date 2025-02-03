using ADO.Business;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ADO_Proj_Presentation
{

    public partial class Register : Form
    {
        UserService userService;
        public Register()
        {
            InitializeComponent();
            userService = new UserService();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable Registered_Users = userService.GetUsers();
            DGV_Registred.DataSource = Registered_Users;


        }
        public event EventHandler RegistrationSuccessful;//FOR NAVIGATION
        private void Register_Btn_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in DGV_Registred.Rows)
            {
                if (row.Cells["UserName"].Value != null && row.Cells["UserName"].Value.ToString() == UserName_TXT.Text)
                {
                    MessageBox.Show("Username already exists.");
                    return; // Exit the method to prevent inserting the user
                }
                if (row.Cells["Email"].Value != null && row.Cells["Email"].Value.ToString() == Email_TXT.Text)
                {
                    MessageBox.Show("Email already exists.");
                    return; // Exit the method to prevent inserting the user
                }
            }
            int RowsAffected = userService.RegisterUsers(UserName_TXT.Text, Password_TXT.Text, Email_TXT.Text, (int)Up_Age.Value, Address_TXT.Text, CB_Role.Text);
            if (RowsAffected > 0)
            {
                MessageBox.Show("User Registered");
                DataTable Registred_Users = userService.GetUsers();
                DGV_Registred.DataSource = Registred_Users;
                RegistrationSuccessful?.Invoke(this, EventArgs.Empty);

                this.Hide();

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Back_Btn_Click(object sender, EventArgs e)
        {
            RegistrationSuccessful.Invoke(this, EventArgs.Empty);
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
