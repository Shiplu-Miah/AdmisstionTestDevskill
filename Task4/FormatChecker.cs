using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task4
{
    public static class FormatChecker
    {

        public const string myNum = @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$";

        public static bool IsValid(string mobileNumber)
        {
            if (mobileNumber != null) 
                return Regex.IsMatch(mobileNumber, myNum);
            else
                return false;
        }
    }
}