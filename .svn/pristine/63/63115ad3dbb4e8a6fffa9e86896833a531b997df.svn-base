using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using EntityFrameworkDAL;
using Server;
using SystemCustomers.DBUtils;


namespace DataAccessLayer
{
    public class UsersPersister 
    {
        #region Singleton
        private UsersPersister()
        {
        }
        private static UsersPersister instance;
        public static UsersPersister Instance
        {
            get { return instance ?? (instance = new UsersPersister()); }
        }
        #endregion Singleton

        private static UserLogin ConvertUsers(Users service)
        {
            return new UserLogin
                       {
                           UserName = service.UserName,
                           FirstName = service.PrivateName,
                           Password=service.Password,
                           idUserLogin =service.UserId,
                           VPermission = service.Permission
                       };
        }

        public void InsertUser(string userName, string privateName, string permission, string password)
        {
            var user = new Users( userName,  privateName,  permission,  password);
            UsersDataServices.Instance.InsertUser(ConvertUsers(user));
        }
         
        public IEnumerable<Users> GetAllUsers()
        {
            var user = UsersDataServices.Instance.ViewingUsers();
            return user.Select(users => new Users(users.UserName, users.FirstName, users.VPermission, users.Password, users.idUserLogin)).ToList();
        }

        public void UpdateUser(string userName, string privateName, string permission, string password)
        {
            var user = new Users(userName, privateName, permission, password);
            UsersDataServices.Instance.UpdateUser(ConvertUsers(user));
        }

        public void DeleteUser(int userId)
        {
            var user = new Users(userId);
            UsersDataServices.Instance.DeleteUser(ConvertUsers(user));
        }

        public IEnumerable<Users> CheckUserName(string userName)
        {
            var user = new Users(userName);
           var userNameLogin = UsersDataServices.Instance.CheckUserName(ConvertUsers(user)).ToList();
           return userNameLogin.Select(users => new Users(users.UserName));
           // return user.Select(us => new Users(us.UserName)).ToString();
        }

        public IEnumerable<Users> Login(string userName, string password)
        {
            var user = new Users(userName,password);
            var userNameLogin = UsersDataServices.Instance.Login(ConvertUsers(user));
            return userNameLogin.Select(users => new Users(users.UserName,users.Password,users.VPermission)).ToList();
        }

        public void CheckConnection()
        {
            try
            {
                UsersDataServices.Instance.CheckConnection();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
