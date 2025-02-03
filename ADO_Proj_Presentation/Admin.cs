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
    public partial class Admin : Form
    {
        AdminService adminService;
        public Admin()
        {
            InitializeComponent();
            adminService = new AdminService();
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            cb_categoryid.Visible = false;
            numericUpDown1.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            Cb_role.Visible = false;
            textBox3.Visible = false;
            numericUpDown2.Visible = false;
            textBox4.Visible = false;

        }

        private void LogOut_Btn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.Show();
        }

        private void GetUser_Btn_Click(object sender, EventArgs e)
        {
            FormHelper.ClearTextBoxes(this);
            DataTable UsersWithoutAdmin = adminService.GetUsers();
            DGV_AdminOp.DataSource = UsersWithoutAdmin;
            Add_Btn.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = false;
            label1.Text = "user id";
            label2.Text = "user name";
            label3.Text = "Password";
            label4.Text = "email";
            label5.Text = "age";
            label6.Text = "address";
            label7.Text = "role";
            numericUpDown1.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            numericUpDown2.Visible = true;
            Cb_role.Visible = true;
            textBox4.Visible = true;
            cb_categoryid.Visible = false;
        }

        private void GetCategory_Btn_Click(object sender, EventArgs e)
        {
            FormHelper.ClearTextBoxes(this);
            DataTable category = adminService.GetCategory();
            DGV_AdminOp.DataSource = category;
            Add_Btn.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;

            label1.Text = "category id";
            label2.Text = "category name";
            numericUpDown1.Visible = true;
            textBox1.Visible = true;
            textBox3.Visible = false;
            Cb_role.Visible = false;
            numericUpDown2.Visible = false;
            textBox4.Visible = false;
            textBox2.Visible = false;
            cb_categoryid.Visible = false;
        }

        private void GetProducts_Btn_Click(object sender, EventArgs e)
        {
            FormHelper.ClearTextBoxes(this);

            DataTable categories = adminService.GetCategory();
            DataTable products = adminService.GetProducts();
            DGV_AdminOp.DataSource = products;
            Add_Btn.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = true;
            label1.Text = "product id";
            label2.Text = "product name";
            label3.Text = "price";
            label8.Text = "category id";
            numericUpDown1.Visible = true;
            textBox1.Visible = true;
            numericUpDown2.Visible = false;
            textBox2.Visible = true;
            cb_categoryid.Visible = true;
            cb_categoryid.DataSource = categories;
            cb_categoryid.DisplayMember = "categoryname";
            cb_categoryid.ValueMember = "categoryid";
            adminService.category = false;
          
        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {

            int rowsaffected;

            #region incase category
            if (adminService.category)
            {

                rowsaffected = adminService.AddCategories(textBox1.Text.ToString());
                if (rowsaffected > 0)
                {
                    DataTable categories = adminService.GetCategory();

                    DGV_AdminOp.DataSource = categories;
                    MessageBox.Show("category Added successfully");

                }
                else
                {
                    MessageBox.Show("couldnt add category :(");
                }



            }
            #endregion
            #region incase Product
            else if (adminService.product)

            {
                rowsaffected = adminService.AddProducts(textBox1.Text, decimal.Parse(textBox2.Text), (int)cb_categoryid.SelectedValue);
                if (rowsaffected > 0)
                {
                    DataTable products = adminService.GetProducts();
                    DGV_AdminOp.DataSource = products;
                    MessageBox.Show("product added successfully");

                }
                else
                {
                    MessageBox.Show("product couldnt be added ");
                }
            }
            #endregion
        }

        private void Update_Btn_Click(object sender, EventArgs e)
        {
            int rowsaffected;


            #region incase user
            if (adminService.User)
            {


                rowsaffected = adminService.UpdateUser((int)numericUpDown1.Value,
                    textBox1.Text, textBox2.Text,
                    textBox3.Text, (int)numericUpDown2.Value,
                    textBox4.Text,
                    Cb_role.Text.ToString());
                if (rowsaffected > 0)
                {
                    DataTable userswithoutadmins = adminService.GetUsers();


                    DGV_AdminOp.DataSource = userswithoutadmins;
                    MessageBox.Show("User Updated successfully");

                }
            }

            #endregion
            #region incase category
            else if (adminService.category)
            {




                rowsaffected = adminService.UpdateCategories((int)numericUpDown1.Value, textBox1.Text);
                if (rowsaffected > 0)
                {
                    DataTable categories = adminService.GetCategory();
                    DGV_AdminOp.DataSource = categories;
                    MessageBox.Show("category Updated successfully");

                }
            }
            #endregion
            #region in case product
            else if (adminService.product)
            {
             

                rowsaffected = adminService.UpdateProduct((int)numericUpDown1.Value, textBox1.Text, decimal.Parse(textBox2.Text), (int)cb_categoryid.SelectedValue);
                if (rowsaffected > 0)
                {
                    DataTable products = adminService.GetProducts();
                    DGV_AdminOp.DataSource = products;
                    MessageBox.Show("product Updated successfully");

                }
                else  
                {
              
                    MessageBox.Show("product couldnt be Updated");

                }

            }
            #endregion


        }

        private void DGV_AdminOp_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.RowIndex > -1)
            {
                DataGridViewRow selectedRow = DGV_AdminOp.Rows[e.RowIndex];
                if (adminService.User)
                {
                    numericUpDown1.Value = (int)selectedRow.Cells["UserId"].Value;
                    textBox1.Text = selectedRow.Cells["username"].Value.ToString();
                    textBox2.Text = selectedRow.Cells["password"].Value.ToString();
                    textBox3.Text = selectedRow.Cells["email"].Value.ToString();
                    numericUpDown2.Value = (int)selectedRow.Cells["age"].Value;
                    textBox4.Text = selectedRow.Cells["address"].Value.ToString();
                    Cb_role.Text = selectedRow.Cells["role"].Value.ToString();
                    Cb_role.SelectedValue = selectedRow.Cells["role"].Value.ToString();
                }
                else if (adminService.category)
                {
                    numericUpDown1.Value = (int)selectedRow.Cells["categoryid"].Value;
                    textBox1.Text = selectedRow.Cells["categoryname"].Value.ToString();


                }
                else if (adminService.product)
                {

                    numericUpDown1.Value = Convert.ToInt32(selectedRow.Cells["productid"].Value);
                    textBox1.Text = selectedRow.Cells["productname"].Value.ToString();
                    textBox2.Text = selectedRow.Cells["price"].Value.ToString();

                    cb_categoryid.SelectedValue = Convert.ToInt32(selectedRow.Cells["categoryid"].Value);
                   



                }

            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            int rowsaffected;


            #region incase user
            if (adminService.User)
            {


                rowsaffected = adminService.DeleteUsers((int)numericUpDown1.Value);
                if (rowsaffected > 0)
                {
                    DataTable userswithoutadmins = adminService.GetUsers();


                    DGV_AdminOp.DataSource = userswithoutadmins;
                    MessageBox.Show("User Deleted successfully");

                }
            }

            #endregion
            #region incase category
            else if (adminService.category)
            {




                rowsaffected = adminService.DeleteCategories((int)numericUpDown1.Value);
                if (rowsaffected > 0)
                {
                    DataTable categories = adminService.GetCategory();
                    DGV_AdminOp.DataSource = categories;
                    MessageBox.Show("category deleted successfully");

                }
            }
            #endregion
            #region in case product
            else if (adminService.product)
            {


                rowsaffected = adminService.DeleteProducts((int)numericUpDown1.Value);
                if (rowsaffected > 0)
                {
                    DataTable products = adminService.GetProducts();
                    DGV_AdminOp.DataSource = products;
                    MessageBox.Show("product deleted successfully");

                }
                else
                {

                    MessageBox.Show("product couldnt be deleted");

                }

            }
#endregion
        }

    }
}