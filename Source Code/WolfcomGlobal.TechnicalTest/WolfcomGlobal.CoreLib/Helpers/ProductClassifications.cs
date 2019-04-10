using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolfcomGlobal.CoreLib.Entity;
using WolfcomGlobal.CoreLib.Model;

namespace WolfcomGlobal.CoreLib.Helpers
{
    public class ProductClassifications
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public static List<Products> GettheProductClassification(List<string> adProducts)
        {
            List<Products> ProductList = new List<Products>();
            try
            {
                var adProductsGrouped = adProducts.GroupBy(s => s);

                using (WOLFCOMTechnicalTestEntities db = new WOLFCOMTechnicalTestEntities())
                {
                    foreach (var adProduct in adProductsGrouped)
                    {
                        var product = db.ProductDetails.FirstOrDefault(x => x.ProductId == adProduct.Key.Trim() && x.Status == true);
                        if (product != null)
                        {
                            ProductList.Add(new Products(product, adProduct.Count()));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error("This is an error message" + ex);
                throw ex;
            }

            return ProductList;
        }
    }
}
