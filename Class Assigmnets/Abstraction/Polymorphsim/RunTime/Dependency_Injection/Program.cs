using System;
using System.Collections.Generic;
namespace Dependency_Injection;
class Program

{
    public static void Main(string[] args)
    {
        CCAccount ccAccount = new CCAccount();
        ccAccount.AccountNumber = 123;
        ccAccount.Name = "Vasanthakuamr";
        ccAccount.Balance = 10 * 1000000;

        SBAccount sbAccount = new SBAccount();
        sbAccount.AccountNumber = 324;
        sbAccount.Name = "BharaniDharan";
        sbAccount.Balance = 100 * 1000000;

        List<CCAccount> ccList = new List<CCAccount>();
        ccList.Add(ccAccount);


        List<SBAccount> sbList = new List<SBAccount>();
        sbList.Add(sbAccount);
        List<IAccount> accountList = new List<IAccount>();
        accountList.Add(ccAccount);
        accountList.Add(sbAccount);


    }
}