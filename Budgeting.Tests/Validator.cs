using System;

namespace Budgeting.Tests
{
    public class Validator
    {
        public static void CheckUsernameIsNull(string username)
        {
            if (username.Equals(null) || username.Equals(""))
            {
                throw new Exception("Username cannot be null");
            }
        }

        public static void CheckPasswordIsNull(string password)
        {
            if (password.Equals(null) || password.Equals(""))
            {
                throw new Exception("Username cannot be null");
            }
        }

    }
}