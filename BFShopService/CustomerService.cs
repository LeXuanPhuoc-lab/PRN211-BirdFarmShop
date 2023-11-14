using BFShopBussinessObjects.Entities;
using BFShopRepository;

namespace BFShopService
{
    public class CustomerService : ICustomerService
    {
        private readonly CustomerRepository _customerRepository;

        public CustomerService() 
        {
            _customerRepository = new CustomerRepository();
        }
        public bool Delete(string email) => _customerRepository.Delete(email);
        

        public List<Account> GetAllCustomer() => _customerRepository.GetAllCustomer();
        

        public List<Account> SearchMember(string searchValue) => _customerRepository.SearchMember(searchValue);
        

        public bool UpdateMember(string email, Account account) => _customerRepository.UpdateMember(email, account);
       

    }
}