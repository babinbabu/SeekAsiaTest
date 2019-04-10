using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolfcomGlobal.CoreLib.Model
{
    public class BillRequestViewModel
    {
        [Required]
        public string UserType { get; set; }
        [Required]
        public string PurchasedAds { get; set; }

        public BillRequestViewModel()
        {

        }
    }
}
