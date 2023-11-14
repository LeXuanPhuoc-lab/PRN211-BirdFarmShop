using BFShopBussinessObjects.Entities;
using BFShopDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BFShopRepository
{
    public class CustomerRepository : ICustomerRepository
    {
        public bool Delete(string email) => CustomerDAO.Instance.Delete(email); 
        

        public List<Account> GetAllCustomer()=> CustomerDAO.Instance.GetAllCustomer();
        

        public List<Account> SearchMember(string searchValue) => CustomerDAO.Instance.SearchMember(searchValue);
        

        public bool UpdateMember(string email, Account account) => CustomerDAO.Instance.UpdateMember(email, account);
        


    }
}
