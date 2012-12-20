using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BillDomain.Entity;

namespace BillDomain.Repository.Interface
{
    public interface IItemRepository
    {
        bool IsExist(string key);
        Item Find(Item entity);
        IList<Item> GetAll();
        Item Add(Item entity);
        Item Modify(Item oldEntity, Item newEntity);
        Item Delete(Item entity);
    }
}
