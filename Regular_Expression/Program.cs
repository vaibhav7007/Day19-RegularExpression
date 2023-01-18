using System;

namespace RegularExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the regular expression");
            //UC3 Checking pincode with alphabet at end
            PinCode.check_Six_Digit_Pin_Code();
            Console.ReadLine();
        }
    }
}