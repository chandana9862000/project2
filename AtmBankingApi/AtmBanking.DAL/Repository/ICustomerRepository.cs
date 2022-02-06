using AtmBanking.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtmBanking.DAL.Repository
{
    public interface ICustomerRepository
    {
        void AddCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(int Card_no);
        Customer GetCustomerByCard_no(int Card_no);
        IEnumerable<Customer> GetCustomers();
        void Register(Customer customer);
    }
}
