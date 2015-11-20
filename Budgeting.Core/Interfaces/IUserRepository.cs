using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Budgeting.Core.Interfaces
{
    public interface IUserRepository
    {
        Model.User Register(string user, string password);

        Model.User Login(string user, string password);
    }
}
