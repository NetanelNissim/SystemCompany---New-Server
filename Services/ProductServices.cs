using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using DataAccessLayer;
using System.Data;

namespace Services
{
    public class ProductServices
    {
        private static ProductServices instance;
        public static ProductServices Instance
        {
            get { return instance ?? (instance = new ProductServices()); }
        }

        public void InsertProduct(string productName, string productDescription, DateTime? productDate, int productCount, int productCostPrice)
        {
            ProductsPersister.Instance.InsertProduct(productName, productDescription, productDate, productCount, productCostPrice);
        }

        public void UpdateProduct(string productName, int idProduct, string productDescription, DateTime? productDate, int productCount, int productCostPrice)
        {
            ProductsPersister.Instance.UpdateProduct(productName,idProduct, productDescription, productDate, productCount, productCostPrice);
        }

        public DataTable GetAllProduct()
        {
            return DataTableCreator.Instance.ConvertListToDataTable(ProductsPersister.Instance.GetAllProducts().ToList<EnProducts>());
        }

        public void DeleteProduct(int idProduct)
        {
            try
            {
                ProductsPersister.Instance.DeleteProduct(idProduct);
            }
            catch(ExecutionEngineException)
            {
                throw;
            }
        }

        public List<Tuple<int, string>> GetAllProductToDropDown()
        {
            var product = ProductsPersister.Instance.GetAllProducts();
           var list = new List<Tuple<int, string>>();
           foreach (var item in product)
           {
               list.Add(new Tuple<int, string>(item.idProduct , item.ProductName));
           }
           return list;
        }

        public bool CheckProductId(int id)
        {
            var list = ProductsPersister.Instance.CheckProductId();
            foreach (var item in list)
            {
                if (item.idProduct == id) return false;
            }
            return true;
        }

    }
}
