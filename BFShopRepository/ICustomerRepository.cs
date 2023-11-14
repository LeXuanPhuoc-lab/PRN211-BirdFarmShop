using BFShopBussinessObjects.Entities;

namespace BFShopRepository
{
    public interface ICustomerRepository
    {
        List<Account> GetAllCustomer();

        bool UpdateMember(string email, Account account);
        bool Delete(string email);
        List<Account> SearchMember(string searchValue);
        
    }
}