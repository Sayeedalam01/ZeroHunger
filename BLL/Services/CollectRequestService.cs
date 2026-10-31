using AutoMapper;
using BLL.Models;
using DAL.EF.Tables;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
    public class CollectRequestService
    {
        CollectRequestRepo repo;
        IMapper mapper;
        public CollectRequestService(CollectRequestRepo repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }

        public List<CollectRequestModel> Get()
        {
            var data = repo.Get();
            return mapper.Map<List<CollectRequestModel>>(data);
        }
        public CollectRequestModel Get(int id)
        {
            var data = repo.Get(id);
            return mapper.Map<CollectRequestModel>(data);
        }
        public bool Create(CollectRequestModel model)
        {
            var mapped = mapper.Map<CollectRequest>(model);
            return repo.Create(mapped);
        }
        public bool Update(CollectRequestModel model)
        {
            var mapped = mapper.Map<CollectRequest>(model);
            return repo.Update(mapped);
        }
        public bool Delete(int id)
        {

            return repo.Delete(id);
        }
    }
}