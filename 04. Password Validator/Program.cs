using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            const int minLenght = 6;
            const int maxLenght = 10;
            const int minCountDigith = 2;
            string password = Console.ReadLine();
            bool isPasswordValid = ValidatePassword(password,minLenght,maxLenght,minCountDigith);
            if (isPasswordValid)
            {
                Console.WriteLine("Password is valid");
            }
            
        }
        static bool ValidatePassword(string password,int minLenght,int 
            maxLenght,int minCountDigiht)
        {
           
            bool isPassowordValid = true;
            if (!ValidatePasswordLenght(password, minLenght, maxLenght))
            {
                Console.WriteLine($"Password must be between {minLenght}" +
                    $" and {maxLenght} characters");
                isPassowordValid = false;
            }
            if (!ValidatePasswordIsAlphaNumeric(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isPassowordValid = false;
            }
            if (!ValidateDigithCount(password,minCountDigiht))
            {
                Console.WriteLine("Password must have at least 2 digits");
                isPassowordValid = false;
            }
            return isPassowordValid;
        }
        static bool ValidatePasswordLenght(string password,int minLenght,int maxLenght)
        {
            if (password.Length >= minLenght && password.Length<=maxLenght)
            {
                return true;
            }
            return false;
        }
        static bool ValidatePasswordIsAlphaNumeric(string password)
        {
            foreach(char ch in password)
            {
                if (!Char.IsLetterOrDigit(ch))
                {
                    return false;
                }
            }
            return true;
        }
        static bool ValidateDigithCount(string password,int minDigithCount)
        {
            int digithCount = 0;
            foreach(char ch in password)
            {
                if (Char.IsDigit(ch))
                {
                    digithCount++;
                }
                
            }
            return digithCount >= minDigithCount;
        }
    }
}
