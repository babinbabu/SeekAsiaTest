using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using WolfcomGlobal.CoreLib.Model;


namespace WolfcomGlobal.CoreLib.Core.Repositories
{
    public interface IBill
    {
        #region Billing
        BillCalculationResponseModel CalculatetheBilledAmount(BillRequestViewModel Model);

        List<SelectListItem> GetUserPrivilages();
        #endregion
    }
}
