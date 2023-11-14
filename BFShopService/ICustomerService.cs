using BFShopBussinessObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFShopService
{
    public interface ICustomerService
    {
        List<Account> GetAllCustomer();

        bool UpdateMember(string email, Account account);
        bool Delete(string email);
        List<Account> SearchMember(string searchValue);
        
    }
}
