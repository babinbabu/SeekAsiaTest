using NLog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using WolfcomGlobal.CoreLib.Core.Repositories;
using WolfcomGlobal.CoreLib.Entity;
using WolfcomGlobal.CoreLib.Helpers;
using WolfcomGlobal.CoreLib.Model;

namespace WolfcomGlobal.CoreLib.Persistence.Repositories
{
    public class BillRepository : IBill
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        #region BillingRepositorie
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Model"></param>
        /// <returns></returns>
        public BillCalculationResponseModel CalculatetheBilledAmount(BillRequestViewModel Model)
        {

            BillCalculationResponseModel Result = new BillCalculationResponseModel();
            try
            {
                List<string> adsGroup = StringReplace.StringSplitter(Model.PurchasedAds);
                var PurchasedProductList = ProductClassifications.GettheProductClassification(adsGroup);
                if (PurchasedProductList.Count == 0)
                    Result.Message = "No Products found";
                decimal sumAmount = 0;

                using (WOLFCOMTechnicalTestEntities db = new WOLFCOMTechnicalTestEntities())
                {
                    var PrivilagePromotion = db.PrivilageCustomers.FirstOrDefault(x => x.CustomerPrivilageName == Model.UserType && x.Status == true);

                    if (PrivilagePromotion ==null || PrivilagePromotion.CustomerPromotions == null)
                    {
                        foreach (var PurchasedProduct in PurchasedProductList)
                        {
                            sumAmount += (PurchasedProduct.ProductPrice * PurchasedProduct.Count);
                        }
                    }

                    else
                    {
                        var CustomerPromotionList = PrivilagePromotion.CustomerPromotions.Where(customerpromotion => PurchasedProductList.Any(product => product.ProductCode.Equals(customerpromotion.ProductCode)) && customerpromotion.Status == true).ToList();
                        sumAmount = BillCalculation.BillCalculationwithPromotion(CustomerPromotionList, PurchasedProductList);

                    }
                    Result.PrivilageType = Model.UserType;
                    Result.Ads = Model.PurchasedAds;
                    Result.TotalAmount = Math.Round(sumAmount, 2);
                }
            }
            catch (Exception ex)
            {
                logger.Error("This is an error message" + ex);
                throw ex;
            }
            return Result;
        }

        public List<SelectListItem> GetUserPrivilages()
        {
            List<SelectListItem> Result = new List<SelectListItem>();
            try
            {
                using (WOLFCOMTechnicalTestEntities db = new WOLFCOMTechnicalTestEntities())
                {
                    var PrivilageCustomers = db.PrivilageCustomers.Where(x =>x.Status == true).ToList();
                    foreach(var PrivilageCustomer in PrivilageCustomers)
                    {
                        Result.Add(new SelectListItem{ Text = PrivilageCustomer.CustomerPrivilageName, Value = PrivilageCustomer.CustomerId.ToString()});
                    }

                    
                }
            }
            catch (Exception ex)
            {
                logger.Error("This is an error message" + ex);
                throw ex;
            }
            return Result;
        }
        #endregion
    }
}
