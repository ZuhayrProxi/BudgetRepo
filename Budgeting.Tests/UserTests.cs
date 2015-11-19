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
            User user = new User("SampleUsername","123");
            
            //Act
            Validator.checkUsernameIsNull(user.Username);

            //Assert

        }

        [Test]
        public void Password_Invalid_Isnull()
        {
            //Arrange
            User user = new User("")

            //Act

            //Assert

        }
    }
}
