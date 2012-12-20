using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BillDomain.Entity;
using BillDomain.Repository.Interface;
using BillDomain.Context;

namespace BillDomain.Repository.Class
{
    public class ItemRepository: IItemRepository
    {
        LazyAccountContext _db = new LazyAccountContext();

        /// <summary>
        /// Check the object is exist or not
        /// </summary>
        /// <param name="key">Entity key</param>
        /// <returns>true for exist; otherwise not</returns>
        public bool IsExist(string key)
        {
            if (_db.Items.Where(n => n.Id.ToString() == key).Any())
                return true;
            else
                return false;
        }

        /// <summary>
        /// Find the Item object and return it
        /// </summary>
        /// <param name="entity">Item object</param>
        /// <returns>Item object</returns>
        public Item Find(Item entity)
        {
            return _db.Items.Find(entity);
        }

        /// <summary>
        /// Get all data from Item entity
        /// </summary>
        /// <returns>IList of Item</returns>
        public IList<Item> GetAll()
        {
            var result = from n in _db.Items
                         select n;
            return result.ToList<Item>();
        }

        /// <summary>
        /// Add Item object to db
        /// </summary>
        /// <param name="entity">Item object</param>
        /// <returns>null</returns>
        public Item Add(Item entity)
        {
            if (entity != null)
            {
                _db.Items.Add(entity);
                _db.SaveChanges();
            }
            return null;
        }

        /// <summary>
        /// Modify current Item object
        /// </summary>
        /// <param name="oldEntity">Old Item object</param>
        /// <param name="newEntity">New Item object</param>
        /// <returns>null</returns>
        public Item Modify(Item oldEntity, Item newEntity)
        {
            if (oldEntity != null && newEntity != null)
            {
                _db.Entry(oldEntity).CurrentValues.SetValues(newEntity);
            }
            return null;
        }

        /// <summary>
        /// Delete current Item object
        /// </summary>
        /// <param name="entity">Item object</param>
        /// <returns>null</returns>
        public Item Delete(Item entity)
        {
            if (entity != null)
            {
                _db.Items.Remove(entity);
            }
            return null;
        }
    }
}
