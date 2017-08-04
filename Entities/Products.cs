using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class EnProducts
    {
        public EnProducts(string ProductName, int idProduct, string ProductDiscription, int ProductCount, int ProductCostPrice, DateTime? ProductDate
            )
        {
            this.ProductName = ProductName;
            this.idProduct = idProduct;
            this.ProductDiscription = ProductDiscription;
            this.ProductDate = ProductDate;
            this.ProductCount = ProductCount;
            this.ProductCostPrice = ProductCostPrice;
                  }
        public EnProducts(string ProductName, string ProductDiscription, DateTime? ProductDate,
            int ProductCount, int ProductCostPrice)
        {
            this.ProductName = ProductName;
            this.ProductDiscription = ProductDiscription;
            this.ProductDate = ProductDate;
            this.ProductCount = ProductCount;
            this.ProductCostPrice = ProductCostPrice;
        }

        public EnProducts()
        { 
        
        }

        public EnProducts(int idProduct)
        {
            this.idProduct = idProduct;
        }

        public string ProductDiscription { get; set; }
        public string ProductName { get; set; }
        public int idProduct { get; set; }
        public int ProductCount { get; set; }
        public int ProductCostPrice { get; set; }
        public DateTime? ProductDate { get; set; }
           
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
