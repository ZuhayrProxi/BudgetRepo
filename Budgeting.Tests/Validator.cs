using System;

namespace Budgeting.Tests
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

    }
}