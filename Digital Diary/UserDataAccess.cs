using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Diary
{
    class UserDataAccess
    {

        DataAccess dataAccess;
        public UserDataAccess()
        {
            this.dataAccess = new DataAccess();
        }

        public bool LoginValidation(string username, string password)
        {
            string sql = "SELECT * FROM Users WHERE UserName='" + username + "' AND Password='" + password + "'";
            SqlDataReader reader = dataAccess.GetData(sql);
            if (reader.Read())
            {
                return true;
            }
            return false;
        }

        public int AddNewUser(UserEntities user)
        {
            
            string sql = "INSERT INTO Users(Name,UserName,Password,Email,DateOfBirth,Gender) VALUES('"+user.Name+"','"+user.UserName+"','"+user.Password+"','"+user.Email+"','"+user.DateOfBirth+"','"+user.Gender+"')";

            return this.dataAccess.ExecuteQuery(sql);
        }
    }
}
