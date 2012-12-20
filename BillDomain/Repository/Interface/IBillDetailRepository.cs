using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BillDomain.Entity;

namespace BillDomain.Repository.Interface
{
    public interface IBillDetailRepository
    {
        bool IsExist(string key);
        BillDetail Find(BillDetail entity);
        IList<BillDetail> GetAll();
        BillDetail Add(BillDetail entity);
        BillDetail Modify(BillDetail oldEntity, BillDetail newEntity);
        BillDetail Delete(BillDetail entity); 
    }
}
