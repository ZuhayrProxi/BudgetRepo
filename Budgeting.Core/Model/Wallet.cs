using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Budgeting.Core.Model
{
    public class Wallet
    {
        public Guid _id { get; set; }
        public string _walletName { get; set; }
        public double _salary { get; set; }
        
        public Wallet( Guid id, string walletName, double salary)
        {
            this._walletName = walletName;
            this._id = id;
            this._salary = salary;
        }
    }
}
