﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class Users
    {
        public Users(string userName, string privateName, string permission, string password ,int userId)
        {
            this.UserName = userName;
            this.UserId = userId;
            this.PrivateName = privateName;
            this.Permission = permission;
            this.Password = password;
        }
         
        public Users(string userName,string password)
        {
            this.UserName = userName;
            this.Password = password;
        }
        public Users(string userName)
        {
            this.UserName = userName;
        }

        //public Users(string permission)
        //{
        //    this.Permission = permission;
        //}

        public Users(int userId)
        {
            this.UserId = userId;
        }

        public Users()
        { }

        public Users(string userName, string privateName, string permission, string password)
        {
            // TODO: Complete member initialization
            this.UserName = userName;
            this.PrivateName = privateName;
            this.Permission = permission;
            this.Password = password;
        }

        public Users(string userName, string password,string permission)
        {
            // TODO: Complete member initialization
            this.UserName = userName;
            this.Password = password;
            this.Permission = permission;
        }

        public string PrivateName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Permission { get; set; }
        public int UserId { get; set; }
    }
}
