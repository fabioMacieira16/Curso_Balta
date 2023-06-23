using System;
using UnitOfShop.Models;

namespace UnitOfShop.Repository;

public interface IOderRepository
{
    Void Save(Order order);
}

public class OrderRepository : IOderRepository
{

    public void Save(Order order)
    {
        
    }
} 