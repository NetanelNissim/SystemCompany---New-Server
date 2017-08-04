using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using EntityFrameworkDAL;
using Server;
using SystemCustomers.DBUtils;
using Extensions;


namespace DataAccessLayer
{
    public class ProductsPersister 
    {
        #region Singleton
        private ProductsPersister()
        {
        }
        private static ProductsPersister instance;
        public static ProductsPersister Instance
        {
            get { return instance ?? (instance = new ProductsPersister()); }
        }
        #endregion Singleton

        private static Products ConvertProduct(EnProducts product)
        {
            return new Products
                       {
                           ProductName = product.ProductName,
                           idProduct = product.idProduct,
                           ProductDiscription = product.ProductDiscription,
                           ProductDate =  product.ProductDate,
                           ProductCount = product.ProductCount,
                           ProductCostPrice = product.ProductCostPrice
                       };
        }

        public void InsertProduct(string ProductName, string ProductDiscription, DateTime? ProductDate,
            int ProductCount, int ProductCostPrice)
        {
            var product = new EnProducts(ProductName, ProductDiscription,ProductDate,ProductCount,ProductCostPrice);
            ProductDataServices.Instance.InsertProduct(product.MapTo( new Products()));
        }

        public IEnumerable<EnProducts> GetAllProducts()
        {
            var products = ProductDataServices.Instance.ViewingProduct();
            return products.Select(product =>  product.MapTo( new EnProducts())).ToList();
           }

        public void UpdateProduct(string ProductName, int idProduct, string ProductDiscription, DateTime? ProductDate,
            int ProductCount, int ProductCostPrice)
       {
           var product = new EnProducts( ProductName,  idProduct,  ProductDiscription,  ProductCount,  ProductCostPrice, ProductDate);
           ProductDataServices.Instance.UpdateProduct(product.MapTo( new Products()));
        }

        public void DeleteProduct(int idProduct)
        {
            var product = new EnProducts(idProduct);
            ProductDataServices.Instance.DeleteProduct(product.MapTo(new Products()));
        }

        public IEnumerable<EnProducts> CheckProductId()
        {
            var products = ProductDataServices.Instance.ViewingProduct();
            return products.Select(product => product.MapTo( new EnProducts())).ToList();
        }
    }
}
