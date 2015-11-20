using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Budgeting.Core.Model
{
    public class Wallet
    {
        public string _walletName { get; set; }
        
        public Wallet( string walletName)
        {
            this._walletName = walletName;
        }
    }
}
