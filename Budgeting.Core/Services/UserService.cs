using Budgeting.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Budgeting.Core.Services
{
    public class UserService
    {
        private IUserRepository userRepository;

        public UserService(IUserRepository userRepo)
        {
            this.userRepository = userRepo;
        }

        public Model.User RegisterUser(string user, string password)
        {
            Validator.checkUsernameIsNull(user);
            Validator.checkPasswordIsNull(password);

            Model.User NewUser = userRepository.Register(user, password);

            return NewUser;
        }
    }
}
