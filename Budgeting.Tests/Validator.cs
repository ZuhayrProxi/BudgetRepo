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

    }
}