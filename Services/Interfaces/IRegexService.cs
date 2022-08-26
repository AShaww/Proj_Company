using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IRegexService
    {
        public bool IsPhoneNumber(string x)
        {
            var digit = new Regex("(\\d)");
            var symbol = new Regex("(\\W)-+");

            return digit.IsMatch(x) && symbol.IsMatch(x);
        }
    }
}
