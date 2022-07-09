namespace Galaxy.School.Domain.Repositories.Shared
{
    public interface IBaseRepository<T>
    {
        IEnumerable<T> GetAll();
        Task<IEnumerable<T>> GetAllAsync();
        T GetById(Guid id);
        Task<T> GetByIdAsync(Guid id);
    }
}
