using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.ServiceModel;
using System.Text;
using Services;
using WcfServiceLibrarySystemCompanies.DataContracts;
using System.Data;

namespace WcfServiceLibrarySystemCompanies
{
    public class ProductService 
    {
        public void Insert(Product product)
        {
            ProductServices.Instance.InsertProduct(product.ProductName, product.ProductDescription, product.ProductDate, product.ProductCount, product.ProductCostPrice);
        }

        public void UpdateProduct(Product product)
        {
            ProductServices.Instance.UpdateProduct(product.ProductName, product.IdProduct, product.ProductDescription, product.ProductDate, product.ProductCount, product.ProductCostPrice);
        }

        public string GetAllProduct()
        {
            return Utils.ConvertDataTableToXML(ProductServices.Instance.GetAllProduct(), "Products");
        }

        public DataSet GetAllProductsDataSet()
        {
            DataSet ds = new DataSet();
            ds.Tables.Add(ProductServices.Instance.GetAllProduct());
            return ds;
         }

        public void DeleteService(Product product)
        {
            try
            {
                ProductServices.Instance.DeleteProduct(product.IdProduct);
            }
            catch (DbException e)
            {
                throw new FaultException(
                    new FaultReason(e.Message),
                    new FaultCode("Data Access Error"));
            }
        }

        public List<Tuple<int, string>> GetAllProductsToDropDown()
        {
            return ProductServices.Instance.GetAllProductToDropDown();
        }

        public bool CheckProductId(Product product)
        {
            return ProductServices.Instance.CheckProductId(product.IdProduct);
        }
    }
}
