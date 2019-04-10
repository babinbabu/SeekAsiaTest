using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolfcomGlobal.CoreLib.Model;

namespace WolfcomGlobal.CoreLib.Helpers
{
   public class StringReplace
   {
        public static string FormulaReplaceString(string input, string formula)
        {
            if (!string.IsNullOrEmpty(input))
            {
                if (input.Contains(Constants.NumberofProducts))
                {
                    input = input.Replace(Constants.NumberofProducts, formula.ToString()); ;
                }
            }

            return input;
        }

        public static bool ComputeCondition(string value)
        {
            using (DataTable dt = new DataTable())
            {
                return (bool)(dt.Compute(value, null));
            }
        }

        public static List<string> StringSplitter(string ads)
        {
            string[] adsArray = ads.Split(',');
            List<string> adsList = new List<string>(adsArray.Length);
            adsList.AddRange(adsArray);
            adsList.Reverse();
            return adsList;
        }
    }
}
