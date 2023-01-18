using System;

namespace RegularExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the regular expression");
            //UC4 Checking pincode having a space inside in it
            PinCode.check_Six_Digit_Pin_Code();
            Console.ReadLine();
        }
    }
}