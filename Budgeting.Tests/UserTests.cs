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
            Validator.checkUsernameIsNull(user.Username);

            //Assert
        }

        [Test]
        public void Username_Invalid_IsNotNull()
        {
            //Arrange
            User user = new User("SampleName", "123");

            //Act
            Validator.checkUsernameIsNull(user.Username);

            //Assert
        }

        [Test]
        [ExpectedException(typeof(Exception))]
        public void Password_Invalid_Isnull()
        {
            //Arrange
            User user = new User("SamplePass", "");

            //Act
            Validator.checkPasswordIsNull(user.Password);

            //Assert

        }

        [Test]
        public void Password_Valid_IsNotNull()
        {
            //Arrange
            User user = new User("SamplePass", "pass");

            //Act
            Validator.checkPasswordIsNull(user.Password);

            //Assert
        }

        [Test]
        public void RegisterUser_Valid_RegistrationShould()
        {
            //Arrange

            //Act

            //Assert
        }
    }
}
