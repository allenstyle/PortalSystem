using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BillDomain.Entity;

namespace BillDomain.Repository.Interface
{
    public interface IBillMainRepository
    {
        bool IsExist(string key);
        BillMain Find(BillMain entity);
        IList<BillMain> GetAll();
        BillMain Add(BillMain entity);
        BillMain Modify(BillMain oldEntity, BillMain newEntity);
        BillMain Delete(BillMain entity);        
    }
}
