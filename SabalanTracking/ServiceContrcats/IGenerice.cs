namespace SabalanTracking.ServiceContrcats
{
    public interface IGenerice<Tmodel>
    {
        public Task<List<Tmodel>> GetAllAsync();
        public Task<Tmodel> Create(Tmodel model);
        public Task<Tmodel> GetById(int Id);
        public Task<bool> delete(int Id);
        public Task<Tmodel> update(Tmodel model);
    }
}
