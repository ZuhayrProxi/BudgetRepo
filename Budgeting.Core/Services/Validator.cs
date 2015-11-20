using System;

namespace Budgeting.Core.Services
{
    public class Validator
    {
        public static void checkUsernameIsNull(string username)
        {
            if (username.Equals(null) || username.Equals(""))
            {
                throw new Exception("Username cannot be null");
            }
        }

        public static void checkPasswordIsNull(string password)
        {
            if (password.Equals(null) || password.Equals(""))
            {
                throw new Exception("Password cannot be null");
            }
        }


        public static void checkWalletSalaryIsNull(double salary)
        {
            if (salary == null || salary < 0)
            {
                throw new Exception("Salary cannot be null or negative.");  
            }
        }

        public static void checkWalletIdIsNull(Guid id)
        {
            if (id == null || id == Guid.Empty )
            {
                throw new Exception("User ID cannot be null");  
            }
        }

        public static void checkWalletNameIsNull(string walletName)
        {
            if (walletName == null || walletName.Equals(""))
            {
                throw new Exception("Wallet Name cannot be null");
            }
        }
    }
}