using NLog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolfcomGlobal.CoreLib.Entity;
using WolfcomGlobal.CoreLib.Model;

namespace WolfcomGlobal.CoreLib.Helpers
{
    public class BillCalculation
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();


        /// <summary>
        /// 
        /// </summary>
        /// <param name="customerPromotions"></param>
        /// <param name="products"></param>
        /// <returns></returns>
        public static decimal BillCalculationwithPromotion(List<CustomerPromotion> customerPromotions, List<Products> products)
        {
            decimal sumofPurchase = 0;
            foreach (var product in products)
            {
                
                var havePromotion = customerPromotions.FirstOrDefault(x => x.ProductCode == product.ProductCode);

                if (havePromotion != null)
                {
                    if (havePromotion.PromotionFormula != null && StringReplace.ComputeCondition(StringReplace.FormulaReplaceString(havePromotion.PromotionFormula, product.Count.ToString())))
                        sumofPurchase += (havePromotion.PromotionPrice * product.Count);
                    else
                        sumofPurchase += (product.ProductPrice * product.Count);

                }
                else
                {
                    sumofPurchase += (product.ProductPrice * product.Count);
                }
                
            }
            return sumofPurchase;
        }
    }
}
