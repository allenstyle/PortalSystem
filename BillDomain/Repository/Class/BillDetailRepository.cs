using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BillDomain.Repository.Interface;
using BillDomain.Context;
using BillDomain.Entity;

namespace BillDomain.Repository.Class
{
    public class BillDetailRepository: IBillDetailRepository
    {
        LazyAccountContext _db;

        public BillDetailRepository()
        {
            _db = new LazyAccountContext();
        }

        /// <summary>
        /// Check the object is exist or not
        /// </summary>
        /// <param name="key">Entity key</param>
        /// <returns>true for exist; otherwise not</returns>
        public bool IsExist(string key)
        {
            if (_db.BillDetails.Where(n => n.Id.ToString() == key).Any())
                return true;
            else
                return false;
        }

        /// <summary>
        /// Find the BillDetail object and return it
        /// </summary>
        /// <param name="entity">BillDetail object</param>
        /// <returns>BillDetail object</returns>
        public BillDetail Find(BillDetail entity)
        {
            return _db.BillDetails.Find(entity);
        }

        /// <summary>
        /// Get all data from BillDetail entity
        /// </summary>
        /// <returns>IList of BillDetail</returns>
        public IList<BillDetail> GetAll()
        {
            var result = from n in _db.BillDetails
                         select n;
            return result.ToList<BillDetail>();
        }

        /// <summary>
        /// Add BillDetail object to db
        /// </summary>
        /// <param name="entity">BillDetail object</param>
        /// <returns>null</returns>
        public BillDetail Add(BillDetail entity)
        {
            if (entity != null)
            {
                _db.BillDetails.Add(entity);
                _db.SaveChanges();
            }
            return null;
        }
        
        /// <summary>
        /// Modify current BillDetail object
        /// </summary>
        /// <param name="oldEntity">Old BillDetail object</param>
        /// <param name="newEntity">New BillDetail object</param>
        /// <returns>null</returns>
        public BillDetail Modify(BillDetail oldEntity, BillDetail newEntity)
        {
            if (oldEntity != null && newEntity != null)
            {
                _db.Entry(oldEntity).CurrentValues.SetValues(newEntity);
            }
            return null;
        }

        /// <summary>
        /// Delete current BillDetail object
        /// </summary>
        /// <param name="entity">BillDetail object</param>
        /// <returns>null</returns>
        public BillDetail Delete(BillDetail entity)
        {
            if (entity != null)
            {
                _db.BillDetails.Remove(entity);
            }
            return null;
        }
    }
}
