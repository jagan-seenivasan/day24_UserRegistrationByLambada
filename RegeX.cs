using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistration_Lambda
{
    public class RegeX
    {

        //UC-1
        //pattern for valid name
        public static string REGEX = "^[A-Z]{1}[A-Za-z]{2,}$";

        public bool ValidFirstName(string name)
        {
            return Regex.IsMatch(name, REGEX);
        }
        //UC-2
        //pattern for valid name
        public static string LastNameREGEX = "^[A-Z]{1}[A-Za-z]{2,}$";

        public bool ValidLastName(string name)
        {
            return Regex.IsMatch(name, LastNameREGEX);
        }

        //UC-3
        //pattern for valid email
        public static string EmailREGEX = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}";

        public bool ValidEmail(string email)
        {
            return Regex.IsMatch(email, EmailREGEX);
        }

        //UC-4
        //pattern for valid phonenumber
        public static string MobileNumREGEX = "^[91]{1}[ ]{1}[6-9]{1}[0-9]{9}$";

        public bool ValidMobile(string mobileNumber)
        {
            return Regex.IsMatch(mobileNumber, MobileNumREGEX);
        }

        //UC-5
        //pattern for valid rule1
        public static string Condition1REGEX = "^[A-Za-z0-9@$!%*#?&]{8,}$";

        public bool ValidCondition1(string password)
        {
            return Regex.IsMatch(password, Condition1REGEX); ;
        }

        //UC-6
        //pattern for valid rule2
        public static string Condition2REGEX = "^(?=.*?[A-Z])[A-Za-z0-9@$!%*#?&]{8,}$";

        public bool ValidCondition2(string password)
        {
            return Regex.IsMatch(password, Condition2REGEX); ;
        }

        //UC-7
        //pattern for valid rule3
        public static string Condition3REGEX = "^(?=.*?[A-Z])(?=.*?[0-9])[A-Za-z0-9@$!%*#?&]{8,}$";

        public bool ValidCondition3(string password)
        {
            return Regex.IsMatch(password, Condition3REGEX); ;
        }

        //UC-8
        //pattern for valid rule4
        public static string Condition4REGEX = "^[A-Za-z0-9]*[@$!%*#?&]{1}[A-Za-z0-9]*$";

        public bool ValidCondition4(string password)
        {
            return Regex.IsMatch(password, Condition4REGEX); ;
        }

        //UC-9
        //pattern for sample email
        public static string SampleEmailREGEX = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][0-9a-zA-Z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";

        public bool SampleEmail(string email)
        {
            return Regex.IsMatch(email, SampleEmailREGEX); ;
        }

        //UC-13

        public Func<string, bool> isValidFirstName = firstname => Regex.IsMatch(firstname, REGEX);


        public Func<string, bool> isValidLastName = lastname => Regex.IsMatch(lastname, LastNameREGEX);


        public Func<string, bool> isValidEmail = email => Regex.IsMatch(email, EmailREGEX);


        public Func<string, bool> isValidMobileNumber = mobilenumber => Regex.IsMatch(mobilenumber, MobileNumREGEX);


        public Func<string, bool> isValidPassword = password => Regex.IsMatch(password, Condition1REGEX) && Regex.IsMatch(password, Condition4REGEX);


    }
}