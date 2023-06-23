using System;
using UnitOfShop.Models;

namespace UnitOfShop.Repository;

public interface ICustomerRepository
{
    Void Save(Customer customer);
}

public class CustomerRepository : ICustomerRepository
{

    public void Save(Customer customer)
    {
        
    }
} 