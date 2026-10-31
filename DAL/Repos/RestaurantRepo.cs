using DAL.EF;
using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repos
{
    public class RestaurantRepo
    {
        ZeroHungerDbContext db;
        public RestaurantRepo(ZeroHungerDbContext db)
        {
            this.db = db;
        }
        public List<Restaurant> Get()
        {
            return db.Restaurants.ToList();
        }
        public Restaurant Get(int id)
        {
            return db.Restaurants.Find(id);
        }
        public bool Create(Restaurant Restaurant)
        {
            db.Restaurants.Add(Restaurant);
            return db.SaveChanges() > 0;
        }
        public bool Update(Restaurant Restaurant)
        {
            var ex = Get(Restaurant.Id);
            ex.Name = Restaurant.Name;
            ex.Address = Restaurant.Address;
            ex.Phone = Restaurant.Phone;
            ex.Email = Restaurant.Email;

            return db.SaveChanges() > 0;
        }
        public bool Delete(int id)
        {
            var ex = Get(id);
            db.Restaurants.Remove(ex);
            return db.SaveChanges() > 0;
        }
    }
}