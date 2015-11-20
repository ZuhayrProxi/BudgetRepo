using Budgeting.Core.Model;
using Budgeting.Core;
using Budgeting.Core.Interfaces;
using Budgeting.Core.Services;
using System;
using NUnit.Framework;
using Moq;

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

             mockRepository
                 .Setup(t => t.Login(It.IsAny<string>(), It.IsAny<string>()))
                 .Returns(() => new User(It.IsAny<string>(), It.IsAny<string>()));

             //mockWalletRepository = new Mock<IWalletRepository>();


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

        [Test]
        [ExpectedException]
        public void LoginUser_Invalid_IsNull()
        {
            //Arrange
            UserService userService = new UserService(mockRepository.Object);
            User Result;

            //Act
            Result = userService.Login("", "loginPass");

            //Assert
        }

        [Test]
        public void LoginUser_Valid_IsNotNull()
        {
            //Arrange
            UserService userService = new UserService(mockRepository.Object);
            User Result;

            //Act
            Result = userService.Login("LoginUser", "loginPass");

            //Assert
            Assert.IsNotNull(Result);
        }

        [Test]
        public void LoginUser_Valid_LoginShould()
        {
            //Arrange
            UserService userService = new UserService(mockRepository.Object);

            //Act
            var Result = userService.Login("LoginUser", "loginPass");

            //Assert
            mockRepository.Verify(x => x.Login(It.IsAny<string>(), It.IsAny<string>()));
        }

        [Test]
        public void AddNewWallet_Valid_WalletShould()
        {
            //arrange
            WalletService walletService = new WalletService(mockRepository.Object);

            //act
            var Result = walletService.createWallet("WalletName");

            //assert
            //mockRepository.Verify(x => x. );
        }
    }
}
