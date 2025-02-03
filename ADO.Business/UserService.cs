using ADO.DataAccess;
using Azure;
using System.Collections.Generic;
using System.Data;
using System.Net;
namespace ADO.Business
{
    public class UserService
    {
        DbContext dbContext;
      
        public UserService()
        {
            dbContext = new DbContext();
        }
        public DataTable GetUsers()
        {
            string CMD_Text = "Select * from Users";
            return dbContext.ExcuteQuery(CMD_Text);

        }
        public DataTable searchUsers(string username, string password)
        {
            string CMD_Text = $"Select * from Users where UserName='{username}' and Password='{password}' ";
            return dbContext.ExcuteQuery(CMD_Text);

        }
        public int RegisterUsers(string name,string password,string email,int age,string address,string role)
        {
            string CMD_Text = " insert into Users(Username, Password, Email, Age, Address, Role)values" +
                $"('{name}', '{password}', '{email}', {age}, '{address}', '{role}')";
            return dbContext.ExcuteNonQuery(CMD_Text);
        }
        public DataTable GetProductsForUser()
        {
            string cmd_txt = "select p.productid, p.productname,p.price,c.categoryname from products p inner join categories c on c.CategoryId=p.CategoryId";
            return dbContext.ExcuteQuery(cmd_txt);
        }
        public DataTable GetFavoritesForUser(int uid)
        {
            string cmd_txt = $"select p.productid ,p.productname,p.price from products p inner join  favorites f on f.PId=P.ProductId where uid={uid} ";
            return dbContext.ExcuteQuery(cmd_txt);
        }
        public int AddFavorite(int UID,int PID)
        {
            string CMD_Text = $" insert into Favorites(UID, PID) Values({UID},{PID})";
            return dbContext.ExcuteNonQuery(CMD_Text);

        }
        public int RemoveFavorite(int UID, int PID)
        {
            string CMD_Text = $"DELETE TOP (1) FROM Favorites WHERE PId = {PID} AND UId = {UID}";
            return dbContext.ExcuteNonQuery(CMD_Text);
        }

    }
}
