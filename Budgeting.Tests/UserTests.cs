using Budgeting.Core;
using NUnit.Core;
using NUnit.Framework;
using System;

namespace Budgeting.Tests
{
    [TestFixture]
    public class UserTests
    {
        [Test]
        [ExpectedException]
        public void Username_Invalid_Isnull()
        {
            //Arrange
            User user = new User("SampleUsername","123");
            
            //Act
            Validator.checkUsernameIsNull(user.Username);

            //Assert

        }
    }
}
