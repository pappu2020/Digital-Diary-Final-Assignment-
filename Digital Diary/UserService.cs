using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Diary
{
    class UserService
    {

        UserDataAccess userDataAccess;
        public UserService()
        {
            userDataAccess = new UserDataAccess();
        }

        public bool LoginValidation(string username, string password)
        {
            return userDataAccess.LoginValidation(username, password);
        }

        public int AddNewUser(string name, string username, string password, string email,string dateOfBirth,string gender  )
        {

            UserEntities user = new UserEntities()
            {
                Name = name,
                UserName = username,
                Password = password,
                Email = email,
                DateOfBirth = dateOfBirth,
                Gender = gender,

            };
            userDataAccess = new UserDataAccess();
            return this.userDataAccess.AddNewUser(user);
        }
    }
}
