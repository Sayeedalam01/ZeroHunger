using DAL.EF;
using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repos
{
    public class FoodItemRepo
    {
        ZeroHungerDbContext db;
        public FoodItemRepo(ZeroHungerDbContext db)
        {
            this.db = db;
        }
        public List<FoodItem> Get()
        {
            return db.FoodItems.ToList();
        }
        public FoodItem Get(int id)
        {
            return db.FoodItems.Find(id);
        }
        public bool Create(FoodItem FoodItem)
        {
            db.FoodItems.Add(FoodItem);
            return db.SaveChanges() > 0;
        }
        public bool Update(FoodItem FoodItem)
        {
            var ex = Get(FoodItem.Id);
            ex.Name = FoodItem.Name;
            ex.CollectRequestId = FoodItem.CollectRequestId;
            ex.Quantity = FoodItem.Quantity;
            ex.Unit = FoodItem.Unit;

            return db.SaveChanges() > 0;
        }
        public bool Delete(int id)
        {
            var ex = Get(id);
            db.FoodItems.Remove(ex);
            return db.SaveChanges() > 0;
        }
    }
}