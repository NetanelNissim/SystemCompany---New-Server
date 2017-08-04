﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class Companies
    {
        public Companies(string companyName, string contactName, string mobilePhone, string email, string phone,
            string fax, string companynumber, string address, string city, string zip, string postalNum,
            string paymentTerms)
        {
            this.companyName = companyName;
            this.contactName = contactName;
            this.mobilePhone = mobilePhone;
            this.email = email;
            this.Phone = phone;
            this.FAX = fax;
            this.companynumber = companynumber;
            this.address = address;
            this.city = city;
            this.ZIP = zip;
            this.PostalNum = postalNum;
            this.paymentTerms = paymentTerms;
        }

        public Companies(string companyName, string contactName, string mobilePhone, string email, string phone,
           string fax, string companynumber, string address, string city, string zip, string postalNum,
           string paymentTerms, int idCompany)
        {
            this.companyName = companyName;
            this.contactName = contactName;
            this.mobilePhone = mobilePhone;
            this.email = email;
            this.Phone = phone;
            this.FAX = fax;
            this.companynumber = companynumber;
            this.address = address;
            this.city = city;
            this.ZIP = zip;
            this.PostalNum = postalNum;
            this.paymentTerms = paymentTerms;
            this.idCompany = idCompany;
        }

        public Companies()
        { 
        
        }

        public Companies(int idCompany)
        {
            this.idCompany = idCompany;
        }

        public Companies(string companyNumber)
        {
            // TODO: Complete member initialization
            this.companynumber = companyNumber;
        }

            public string companyName { get; set; }
            public string contactName { get; set; }
            public string mobilePhone { get; set; }
            public string email { get; set; }
            public string Phone { get; set; }
            public string FAX { get; set; }
            public string companynumber { get; set; }
            public string address { get; set; }
            public string city { get; set; }
            public string ZIP { get; set; }
            public string PostalNum { get; set; }
            public int idCompany { get; set; }
            public string paymentTerms { get; set; }

    /*    public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(string.Format("Name = {0}; ", this.Name));
            sb.Append(string.Format("Address = {0}; ", this.Address));
           // sb.AppendLine(string.Format("Id = {0}.", this.Id));
            return sb.ToString();

        }*/
    }
}
