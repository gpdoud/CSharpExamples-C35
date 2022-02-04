using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamples {

    class StringExamples {

        public static void Run() {

            // immutable strings
            string name = "Greg";
            name = $"{name} Doud";

            // replacing a single quote for SQL
            string name2 = "O'Malley".Replace("'", "''");

            // checking a user entered value in a case-insensitive way
            string option = "j".ToUpper();
            if(option == "J") {
                Console.WriteLine("Found");
            }

            // split
            string names = "Abe Barb Charlie Darlene";
            string[] allNames = names.Split(" ");

            // split to get individual components
            string address = " |805 Main Street|Dallas|TX|12345| ";
            address = address.Trim();
            string[] addressComponents = address.Split("|");
            string address1 = addressComponents[1];
            string city = addressComponents[2];
            string stateCode = addressComponents[3];
            string zipCode = addressComponents[4];

            // parse string allowing currency symbols
            string currency = "$123,456.78";
            //decimal dollars = decimal.Parse(currency, NumberStyles.AllowCurrencySymbol 
            //                                            | NumberStyles.AllowDecimalPoint
            //                                            | NumberStyles.AllowThousands);
            decimal dollars = decimal.Parse(currency, NumberStyles.Currency);

            // nullable reference types
            int? i = null;
#nullable enable
            string? s = null;
#nullable disable
            string s1 = null;

            // StringBuilder
            StringBuilder stringBuilder = new StringBuilder("ABCXYZ");
            stringBuilder.Append("12345"+"ZZZZZ");
            string aString = stringBuilder.ToString();

            // String.Format(..)
            decimal a = 88.77m;
            int b = -123;
            decimal[] c = { 12.34m, 56.78m, 90.12m, 9876.54m };
            string message = string.Format("a = {0:c2}, b = {1}", a, b);
            message = $"a = {a,10:c2}, b = {b}";
            foreach(decimal money in c) {
                Console.WriteLine($"{money,12:c2}");
            }
        }
    }
}
