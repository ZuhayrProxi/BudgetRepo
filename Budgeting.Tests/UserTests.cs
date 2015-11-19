using Budgeting.Core;
using System;
using NUnit.Framework;

namespace Budgeting.Tests
{
    [TestFixture]
    public class UserTests
    {
        [Test]
        [ExpectedException(typeof(Exception))]
        public void Username_Invalid_Isnull()
        {
            //Arrange
            User user = new User("","123");
            
            //Act
            Validator.CheckUsernameIsNull(user.Username);

            //Assert
        }

        [Test]
        public void Username_Valid_IsNotNull()
        {
            //Arrange
            User user = new User("SampleName", "123");

            //Act
            Validator.CheckUsernameIsNull(user.Username);

            //Assert
        }

        [Test]
        [ExpectedException(typeof(Exception))]
        public void Password_Invalid_IsNull()
        {
            //Arrange
            User user = new User("SampleName", "");

            //Act
            Validator.CheckUsernameIsNull(user.Password);

            //Assert
        }

        [Test]
        public void Password_Valid_IsNotNull()
        {
            //Arrange
            User user = new User("SampleName", "123");

            //Act
            Validator.CheckPasswordIsNull(user.Password);

            //Assert
        }
    }
}
