using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStore
{
    public interface IBalance
    {
        double WalletBalance {get;}
        void  WalletRecharge(double amount);
        
    }
}