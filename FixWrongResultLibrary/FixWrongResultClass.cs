using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace FixWrongResultLibrary
{
    public class FixWrongResultClass
    {
        public string FixWrongResult(string text)
        {
            string reg = @"^-?[0-9]+\/-?[0-9]+$";
            if ( Regex.IsMatch(text,reg,RegexOptions.IgnoreCase)) {
                string[] nums = text.Split('/');
                if (Convert.ToInt32(nums[0]) > Convert.ToInt32(nums[1]))
                {
                    nums[0] = nums[1];
                }

                string endnums = String.Join("/", nums);

                return endnums;
            }
            else throw new Exception();
        }

    }
}
