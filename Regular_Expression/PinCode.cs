using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpression
{
    class PinCode
    {
        public static void check_Six_Digit_Pin_Code()
        {
            //UC1 Checking the PIN Code is a 6 digit code 
            string pattern = "^[0-9]{6}$";
            string[] pincode = { "400088", "431717", "400085", "40013b", "A41100", "400 088" }; //UC4 400 088 invalid case
            foreach (string input in pincode)
            {
                if (Regex.IsMatch(input, pattern))
                {
                    Console.WriteLine("{0} is valid ", input);
                }
                else
                {
                    Console.WriteLine("{0} is invalid", input);
                }
            }
        }
    }
}