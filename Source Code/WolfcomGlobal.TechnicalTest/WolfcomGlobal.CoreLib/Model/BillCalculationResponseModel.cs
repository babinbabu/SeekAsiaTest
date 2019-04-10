using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolfcomGlobal.CoreLib.Model
{
   public class BillCalculationResponseModel
    {
        public string PrivilageType { get; set; }
        public string Ads { get; set; }
        public decimal TotalAmount { get; set; }

        public string Message { get; set; }
    }
}
