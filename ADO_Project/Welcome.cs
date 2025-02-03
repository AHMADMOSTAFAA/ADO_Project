using ADO_Proj_Presentation;
namespace ADO_Project
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void GoTo_Register_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.RegistrationSuccessful += OnRegistrationSuccessful;
            register.Show();
            this.Hide();

        }
        public void OnRegistrationSuccessful(object sender, EventArgs e)
        {
            // Show the WelcomeForm when registration is successful
            this.Show();
        }


        private void Login_Btn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }
    }
}
