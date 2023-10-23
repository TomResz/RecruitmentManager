namespace RecruitmentManager.Application.Interfaces.Repositories;

public interface IAsyncRepository<T> where T : class
{
	Task<List<T>?> GetAllAsync();
	Task<T?> GetById(Guid Id);
	Task Add(T entity);
	Task Update(T entity);
	Task Delete(T entity);
}
