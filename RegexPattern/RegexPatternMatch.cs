using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexPattern
{
    public class RegexPatternMatch
    {
        private const string REGEX_PINCODE = "^[1-9]{1}[0-9]{2}([ ])?[0-9]{3}$";
        private const string REGEX_EMAIL = "^[0-9a-zA-Z]{1,}([._+-])?[0-9a-zA-Z]{1,}[@][0-9a-zA-Z]{1,}[.][a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
        // ^[0-9a-zA-Z]+([._+-][0-9a-zA-Z]+)*[@][0-9a-zA-Z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$
        public bool ValidatePinCode(string pinCode)
        {
            return Regex.IsMatch(pinCode, REGEX_PINCODE);
        }

        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, REGEX_EMAIL);
        }
    }
}
