using ADO.Business;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ADO_Proj_Presentation
{
    public partial class User : Form
    {
        UserService userService;
        public int userid;
        string pname;
        decimal price = 0;
        int PID;

        public User(int userId)
        {
            InitializeComponent();
            userService = new UserService();
            this.userid = userId;
           
        }

        private void User_Load(object sender, EventArgs e)
        {
           
            DataTable products = userService.GetProductsForUser();
            DGV_Products.DataSource = products;
            DataTable fav = userService.GetFavoritesForUser(userid);
            DGV_User.DataSource = fav;

          
            DGV_Products.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_User.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

           
            DGV_Products.RowPostPaint += DGV_Products_RowPostPaint;
            DGV_User.RowPostPaint += DGV_User_RowPostPaint;
        }

       
        private void DGV_Products_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv != null)
            {
                dgv.Rows[e.RowIndex].HeaderCell.Value = "+";
            }
        }

    
        private void DGV_User_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv != null)
            {
                dgv.Rows[e.RowIndex].HeaderCell.Value = "-";
            }
        }

        private void ShowProd_Btn_Click(object sender, EventArgs e)
        {
            DataTable products = userService.GetProductsForUser();
            DGV_Products.DataSource = products;
        }

        private void ShowFav_Btn_Click(object sender, EventArgs e)
        {
            DataTable fav = userService.GetFavoritesForUser(userid);
            DGV_User.DataSource = fav;
        }

        private void DGV_User_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow selectedRow = DGV_User.Rows[e.RowIndex];

               
                PID = Convert.ToInt32(selectedRow.Cells["ProductId"].Value);
                pname = selectedRow.Cells["ProductName"].Value.ToString();
                price = Convert.ToDecimal(selectedRow.Cells["Price"].Value);

              
                userService.RemoveFavorite(userid, PID);

          
                DGV_User.DataSource = userService.GetFavoritesForUser(userid);
            }
        }

        private void DGV_Products_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow selectedRow = DGV_Products.Rows[e.RowIndex];

               
                PID = Convert.ToInt32(selectedRow.Cells["ProductId"].Value);
                pname = selectedRow.Cells["ProductName"].Value.ToString();
                price = Convert.ToDecimal(selectedRow.Cells["Price"].Value);

              
                userService.AddFavorite(userid, PID);

                
                DGV_User.DataSource = userService.GetFavoritesForUser(userid);

                selectedRow.HeaderCell.Value = "✓";
            }
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
