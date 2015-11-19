using Budgeting.Core.Model;
using Budgeting.Core;
using Budgeting.Core.Services;
using System;
using NUnit.Framework;
using Moq;
using Budgeting.Core.Interfaces;

namespace Budgeting.Tests
{
    [TestFixture]
    public class UserTests
    {
        private Mock<IUserRepository> mockRepository;

        [TestFixtureSetUp]
        public void Setup() 
        {
             mockRepository = new Mock<IUserRepository>();

             mockRepository
                 .Setup(t => t.Register(It.IsAny<string>(), It.IsAny<string>()))
                 .Returns(() => new User(It.IsAny<string>(), It.IsAny<string>()));
        }

        [Test]
        [ExpectedException]
        public void RegisterUser_Invalid_Isnull()
        {
            //Arrange
            UserService userService = new UserService(mockRepository.Object);
            User Result;
            
            //Act
            Result = userService.RegisterUser("", "123");

            //Assert
        }

        [Test]
        public void RegisterUser_Valid_IsNotNull()
        {

            //Arrange
            UserService userService = new UserService(mockRepository.Object);
            User Result;

            //Act
            Result = userService.RegisterUser("SampleName", "123");

            //Assert
            Assert.IsNotNull(Result);
        }

        //[Test]
        //[ExpectedException(typeof(Exception))]
        //public void Password_Invalid_Isnull()
        //{
        //    //Arrange
        //    User user = new User("SamplePass", "");

        //    //Act
        //    Validator.checkPasswordIsNull(user.Password);

        //    //Assert

        //}

        //[Test]
        //public void Password_Valid_IsNotNull()
        //{
        //    //Arrange
        //    User user = new User("SamplePass", "pass");

        //    //Act
        //    Validator.checkPasswordIsNull(user.Password);

        //    //Assert
        //}

        [Test]
        public void RegisterUser_Valid_RegistrationShould()
        {
            //Arrange
            
            UserService userService = new UserService(mockRepository.Object);

            //Act
            var Result = userService.RegisterUser("SampleUser", "123");

            //Assert
            mockRepository.VerifyAll();
        }
    }
}
