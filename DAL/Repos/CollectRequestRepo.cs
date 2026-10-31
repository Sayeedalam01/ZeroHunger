using DAL.EF;
using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repos
{
    public class CollectRequestRepo
    {
        ZeroHungerDbContext db;
        public CollectRequestRepo(ZeroHungerDbContext db)
        {
            this.db = db;
        }
        public List<CollectRequest> Get()
        {
            return db.CollectRequests.ToList();
        }
        public CollectRequest Get(int id)
        {
            return db.CollectRequests.Find(id);
        }
        public bool Create(CollectRequest CollectRequest)
        {
            db.CollectRequests.Add(CollectRequest);
            return db.SaveChanges() > 0;
        }
        public bool Update(CollectRequest CollectRequest)
        {
            var ex = Get(CollectRequest.Id);
            ex.RestaurantId = CollectRequest.RestaurantId;
            ex.EmployeeId = CollectRequest.EmployeeId;
            ex.PreserveUntil = CollectRequest.PreserveUntil;
            ex.Status = CollectRequest.Status;
            ex.CreatedAt = CollectRequest.CreatedAt;
            ex.CollectedAt = CollectRequest.CollectedAt;
            ex.DistributedAt = CollectRequest.DistributedAt;
            ex.CompletedAt = CollectRequest.CompletedAt;

            return db.SaveChanges() > 0;
        }
        public bool Delete(int id)
        {
            var ex = Get(id);
            db.CollectRequests.Remove(ex);
            return db.SaveChanges() > 0;
        }
    }
}