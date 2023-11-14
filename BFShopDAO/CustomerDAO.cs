using BFShopBussinessObjects.Entities;
using BFShopBussinessObjects.Utils;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFShopDAO
{
    public class CustomerDAO
    {
        private static CustomerDAO instance = null;
        public static CustomerDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CustomerDAO();
                }
                return instance;
            }
        }
        
        public List<Account> GetAllCustomer()
        {
            var dbcontext = new Bird_Farm_Shop_PRNContext();
            return dbcontext.Accounts.Include(a => a.Role).
                Where(account => account.Role.RoleDesc.Equals(Constants.IsCustomer)).ToList();
        }

        public bool UpdateMember(string email, Account account)
        {
            using (var context = new Bird_Farm_Shop_PRNContext())
            {
                var accountEntity
                    = context.Accounts.FirstOrDefault(x => x.Email.Equals(email));

                if (account is not null)
                {
                    accountEntity.Fullname = account.Fullname;
                    accountEntity.Password = account.Password;
                    accountEntity.RoleId = account.RoleId;
                    accountEntity.Birthday = account.Birthday;
                    accountEntity.Street = account.Street;
                    accountEntity.City = account.City;
                    accountEntity.Phone = account.Phone;
                    accountEntity.Gender = account.Gender;
                    context.SaveChanges();
                    return true;
                }

                return false;
            }
        }

        public bool Delete(string email)
        {
            using (var context = new Bird_Farm_Shop_PRNContext())
            {
                var accountEntity
                     = context.Accounts.FirstOrDefault(x => x.Email.Equals(email));

                if (accountEntity is not null)
                {
                    context.Accounts.Remove(accountEntity);
                    return context.SaveChanges() > 0;
                }

                return false;
            }
        }
        

        public List<Account> SearchMember(string searchValue)
        {
            using (var context = new Bird_Farm_Shop_PRNContext())
            {
                if (String.IsNullOrEmpty(searchValue))
                {
                    return context.Accounts.ToList();
                }

                var accounts = context.Accounts.Where(x => x.Email.Contains(searchValue)
                                            || x.Fullname.Contains(searchValue) || x.City.Contains(searchValue)&& x.RoleId == 4).ToList();
                if (accounts is null)
                {
                    return null;
                }
                else
                {
                    return accounts;
                }
            }
        }
        
    }
}
