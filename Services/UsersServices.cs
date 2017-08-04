﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using DataAccessLayer;

namespace Services
{
    public class UsersServices
    {
        private static UsersServices instance;
        public static UsersServices Instance
        {
            get { return instance ?? (instance = new UsersServices()); }
        }

        public void InsertUser( string userName, string privateName, string permission, string password)
        {
            UsersPersister.Instance.InsertUser(userName, privateName, permission, password);
        }
         
        public void UpdateUser(string userName, string privateName, string permission, string password)
        {
            UsersPersister.Instance.UpdateUser(userName, privateName, permission, password);
        }

        public IEnumerable<Entities.Users> GetAllUsers()
        {
            return UsersPersister.Instance.GetAllUsers();
        }

        //public List<Entities.Users> CheckUserName(string userName)
        //{
        //    return UsersPersister.Instance.CheckUserName(userName).ToList();
        //}

        public void DeleteUser(int userId)
        {
            UsersPersister.Instance.DeleteUser(userId);
        }

        public List<Entities.Users> Login(string userName, string password)
        {
            return UsersPersister.Instance.Login(userName,password).ToList();
        }

        public void CheckConnection()
        {
            try
            {
                UsersPersister.Instance.CheckConnection();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string GetPermission(string userName, string password)
        {
            string permission = null;
           var user =  UsersPersister.Instance.GetAllUsers();
           foreach (var item in user)
           {
               if (userName == item.UserName && password == item.Password)
               {
                  permission = item.Permission;
                  break;
               }
           }
             return permission;
        }

        public List<Tuple<string,int>> GetAllToDropDown()
        {
            var user = UsersPersister.Instance.GetAllUsers();
            var list = new List<Tuple<string,int>>();
            foreach (var item in user)
            {
                list.Add(new Tuple<string, int>(item.UserName, item.UserId));
            }
            return list;
        }

        public bool CheckUserName(string userName)
        {
            var user = UsersPersister.Instance.GetAllUsers();
            foreach (var item in user)
            {
                if (userName == item.UserName) return false;
            }
            return true;
        }

        public bool CheckUserId(int userId)
        {
            var user = UsersPersister.Instance.GetAllUsers();
            foreach (var item in user)
            {
                if (userId == item.UserId) return false;
            }
            return true;
        }
    }
}
