using Microsoft.EntityFrameworkCore;
using SabalanTracking.Models;
using SabalanTracking.Models.IRepository;
using SabalanTracking.ServiceContrcats;

namespace SabalanTracking.Services
{
    public class PersonService : IPeople
    {
        private readonly IRepoPeople _repo;
        public PersonService(IRepoPeople repo)
        {
            _repo = repo;
        }
        public async Task<List<Person>> GetAllAsync()
        {
            var list = (await _repo.GetAllAsync()).Include(t=>t.Processs).ToList();
            return list;
        }

        public async Task<Person> Create(Person model)
        {
            await _repo.Add(model);
            return model;
        }

        public async Task<Person> GetById(int Id)
        {
            var person = (await _repo.GetById(Id)).Include(t=>t.Processs).FirstOrDefault();
            return person;
        }

        public async Task<bool> delete(int Id)
        {
            var person = (await _repo.GetById(Id)).FirstOrDefault();
            await _repo.Delete(person);
            return true;
        }

        public async Task<Person> update(Person model)
        {
            var main = (await _repo.GetById(model.Id)).FirstOrDefault();
            main.Name = model.Name;
            main.Email = model.Email;
            main.Phone = model.Phone;
            main.Address = model.Address;
            return model;
        }
    }
}

