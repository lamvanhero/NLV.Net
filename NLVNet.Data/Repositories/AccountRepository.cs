using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLVNet.Data.EF;

namespace NLVNet.Data.Repositories
{
    public class AccountRepository
    {
        //NLVNetEntities entity = new NLVNetEntities();

        public List<Account> GetAll()
        {
            var lst = new List<Account>();
            //var rs = (from account in entity.Accounts
            //    select new
            //    {
            //        account.UserId,
            //        account.UserName
            //    }).ToList();
            //foreach (var item in rs)
            //{
            //    var acc = new Account()
            //    {
            //        UserId = item.UserId,
            //        UserName = item.UserName
            //    };
            //    lst.Add(acc);
            //}
            return lst;
        }
    }
}
