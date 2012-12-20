using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BillDomain.Entity;
using BillDomain.Repository.Interface;
using BillDomain.Context;

namespace BillDomain.Repository.Class
{
    public class BillMainRepository: IBillMainRepository
    {
        LazyAccountContext _db;

        public BillMainRepository()
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
            if (_db.BillMains.Where(n => n.Id.ToString() == key).Any())
                return true;
            else
                return false;
        }

        /// <summary>
        /// Find the Bill object and return it
        /// </summary>
        /// <param name="entity">Bill object</param>
        /// <returns>Bill object</returns>
        public BillMain Find(BillMain entity)
        {
            return _db.BillMains.Find(entity);
        }

        /// <summary>
        /// Get all data from Bill entity
        /// </summary>
        /// <returns>IList of Bill</returns>
        public IList<BillMain> GetAll()
        {
            var result = from n in _db.BillMains
                         select n;
            return result.ToList<BillMain>();
        }

        /// <summary>
        /// Add Bill object to db
        /// </summary>
        /// <param name="entity">Bill object</param>
        /// <returns>null</returns>
        public BillMain Add(BillMain entity)
        {
            if (entity != null)
            {
                _db.BillMains.Add(entity);
                _db.SaveChanges();
            }
            return null;
        }
        
        /// <summary>
        /// Modify current Bill object
        /// </summary>
        /// <param name="oldEntity">Old Bill object</param>
        /// <param name="newEntity">New Bill object</param>
        /// <returns>null</returns>
        public BillMain Modify(BillMain oldEntity, BillMain newEntity)
        {
            if (oldEntity != null && newEntity != null)
            {
                _db.Entry(oldEntity).CurrentValues.SetValues(newEntity);
            }
            return null;
        }

        /// <summary>
        /// Delete current Bill object
        /// </summary>
        /// <param name="entity">Bill object</param>
        /// <returns>null</returns>
        public BillMain Delete(BillMain entity)
        {
            if (entity != null)
            {
                _db.BillMains.Remove(entity);
            }
            return null;
        }
    }
}
