using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntityFrameworkDAL;

namespace Server
{
    public class ProductDataServices
    {
        #region Singelton

        private static ProductDataServices _instance;

        public static ProductDataServices Instance
        {
            get { return _instance ?? (_instance = new ProductDataServices()); }
        }

        private ProductDataServices()
        {
            // this will happens only once
            // Do your connection stuff in here
        }

        #endregion Singelton


        #region Project

        public IEnumerable<Products> ViewingProduct()
        {
            using (var ctx = new SystemCompanyEntities())
            {
                return ctx.Products.ToList();
            }
        }

        public void DeleteProduct(Products products)
        {
            using (var ctx = new SystemCompanyEntities())
            {
                Products ProductsToDelete = ctx.Products.First(e => e.idProduct == products.idProduct);
                AuditDataServices.Instance.InsertAudit(ProductsToDelete.idProduct, 0, 0, "products", ProductsToDelete.ProductName, "Delete");
                AuditDataServices.Instance.InsertAudit(ProductsToDelete.idProduct, 0, 0, "products", Convert.ToString(ProductsToDelete.ProductCostPrice), "Delete");
                AuditDataServices.Instance.InsertAudit(ProductsToDelete.idProduct, 0, 0, "products", Convert.ToString(ProductsToDelete.ProductCount), "Delete");
                AuditDataServices.Instance.InsertAudit(ProductsToDelete.idProduct, 0, 0, "products", Convert.ToString(ProductsToDelete.ProductDate), "Delete"); 
                AuditDataServices.Instance.InsertAudit(ProductsToDelete.idProduct, 0, 0, "products", ProductsToDelete.ProductDiscription, "Delete");
                ctx.DeleteObject(ProductsToDelete);
                ctx.SaveChanges();
            }
        }

        public void InsertProduct(Products products)
        {
            using (var ctx = new SystemCompanyEntities())
            {
                ctx.AddToProducts(products);
                ctx.SaveChanges();
            }
        }

        public void UpdateProduct(Products newProduct)
        {
            using (var ctx = new SystemCompanyEntities())
            {
                Products product = ctx.Products.First(e => e.idProduct == newProduct.idProduct);
                if (product.ProductName != newProduct.ProductName || 
                    product.ProductDiscription != newProduct.ProductDiscription ||
                    product.ProductDate != newProduct.ProductDate ||
                    product.ProductCount != newProduct.ProductCount || 
                    product.ProductCostPrice != newProduct.ProductCostPrice ||
                    product.ProductCustomers != newProduct.ProductCustomers)
                {
                    AuditDataServices.Instance.InsertAudit(newProduct.idProduct, 0, 0, "products", product.ProductName, "Update");
                    AuditDataServices.Instance.InsertAudit(newProduct.idProduct, 0, 0, "products", product.ProductDiscription, "Update");
                    AuditDataServices.Instance.InsertAudit(newProduct.idProduct, 0, 0, "products",Convert.ToString( product.ProductDate), "Update");
                    AuditDataServices.Instance.InsertAudit(newProduct.idProduct, 0, 0, "products", Convert.ToString(product.ProductCount), "Update");
                    AuditDataServices.Instance.InsertAudit(newProduct.idProduct, 0, 0, "products", Convert.ToString(newProduct.ProductCostPrice), "Update");
                    AuditDataServices.Instance.InsertAudit(newProduct.idProduct, 0, 0, "products", Convert.ToString(newProduct.ProductCustomers), "Update");
                    
                    product.ProductCustomers = newProduct.ProductCustomers;
                    product.ProductName = newProduct.ProductName;
                    product.ProductDiscription = newProduct.ProductDiscription;
                    product.ProductDate = newProduct.ProductDate;
                    product.ProductCount = newProduct.ProductCount;
                    product.ProductCostPrice = newProduct.ProductCostPrice;
                    ctx.SaveChanges();
                }
            }
        }

        #endregion Project
    }
}
