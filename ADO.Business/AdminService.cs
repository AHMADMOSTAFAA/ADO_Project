using ADO.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.Business
{
    public class AdminService
    {
        DbContext dbContext;
       public bool User = false;
       public bool category = false;
      public  bool product = false;
        public AdminService()
        {
            dbContext = new DbContext();
            
        }
        public DataTable GetUsers()
        {
            User = true;
            category = false;
            product = false;
            string CMD_TXT = "select * from Users where Role= 'User'";
            return dbContext.ExcuteQuery(CMD_TXT);
        }
        public DataTable GetCategory()
        {
            User = false;
            category = true;
            product = false;
            string CMD_TXT = "select * from Categories";
            return dbContext.ExcuteQuery(CMD_TXT);
        }
        public DataTable GetProducts()
        {
            User = false;
            category = false;
            product = true;
            string CMD_TXT = "select * from products";
            return dbContext.ExcuteQuery(CMD_TXT);
        }


        #region Delete Functions

        public int DeleteUsers(int id)
        {
            string CMD_TXT = $"delete from Users where UserId={id}";
            return dbContext.ExcuteNonQuery(CMD_TXT);
        }

        public int DeleteProducts(int id)
        {
            string CMD_TXT = $"delete from Products where ProductId={id}";
            return dbContext.ExcuteNonQuery(CMD_TXT);
        }

        public int DeleteCategories(int id)
        {
            string CMD_TXT = $"delete from Categories where CategoryId={id}";
            return dbContext.ExcuteNonQuery(CMD_TXT);
        }

        #endregion
        #region Update 

        public int UpdateCategories(int id, string Cat_Name)
        {
            string CMD_TXT = $"update Categories set CategoryName='{Cat_Name}' where categoryId={id} ";
            return dbContext.ExcuteNonQuery(CMD_TXT);
        }

        public int UpdateProduct(int id, string name,decimal price ,int cat_id)
        {
            string CMD_TXT = $"Update Products Set ProductName='{name}', Price={price}  ,categoryid={cat_id} where productid={id}";
            return dbContext.ExcuteNonQuery(CMD_TXT);
        }

        public int UpdateUser(int id, string name, string password, string email,int age, string address,string role)
        {
            string CMD_TXT = $"Update Users Set UserName='{name}', Password='{password}',email='{email}'," +
                $"age={age},address='{address}',role='{role}' where userid={id}";
            return dbContext.ExcuteNonQuery(CMD_TXT);
        }


        #endregion
        #region Add
        public int AddCategories(string name)
        {
            string CMD_TXT = $"insert into categories(categoryname) values  ('{name}')";
       return dbContext.ExcuteNonQuery(CMD_TXT);
        }
        public int AddProducts(string name,decimal price,int categoryid)
        {
            string CMD_TXT = $"insert into Products(productname,price,categoryid) values ('{name}',{price},{categoryid})";
            return dbContext.ExcuteNonQuery(CMD_TXT);
        }
        #endregion
    }
}
