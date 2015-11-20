using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Budgeting.Core;
using Budgeting.Core.Interfaces;
using Budgeting.Core.Services;

namespace Budgeting.Core.Services
{
    public class WalletService
    {
        private Interfaces.IWalletRepository walletRepository;

        public WalletService(Interfaces.IWalletRepository walletRepository)
        {
            this.walletRepository = walletRepository;
        }

        public Model.Wallet createWallet( Guid id, string walletName, double salary)
        {
            Validator.checkWalletIdIsNull(id);

            Validator.checkWalletNameIsNull(walletName);

            Validator.checkWalletSalaryIsNull(salary);

            Model.Wallet newWallet = walletRepository.createWallet(id, walletName, salary);

            return newWallet;
        }
    }
}
