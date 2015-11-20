using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Budgeting.Core.Interfaces
{
    public interface IWalletRepository
    {
        Model.Wallet createWallet(Guid id, string walletName, double salary);
    }
}
