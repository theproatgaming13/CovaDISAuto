using CovaDISAutoAPI.Domain.Entities;

namespace CovaDISAutoAPI.Application.Repositories
{
    public interface IAutoRepository
    {
        Auto? GetById(int id);
        // You can add more methods as needed, e.g.:
        IEnumerable<Auto> GetAll();
        void Add(Auto auto);
        void Update(Auto auto);
        void Delete(int id);
    }
}
