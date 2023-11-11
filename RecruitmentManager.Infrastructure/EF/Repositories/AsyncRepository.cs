using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Infrastructure.EF.Context;

namespace RecruitmentManager.Infrastructure.EF.Repositories;

public class AsyncRepository<T> : IAsyncRepository<T> where T : class
{
	private readonly RecruitmentManagerDbContext _context;

	public AsyncRepository(RecruitmentManagerDbContext context)
	{
		_context = context;
	}

	public async Task Add(T entity)
	{
		await _context.Set<T>().AddAsync(entity);
		await _context.SaveChangesAsync();
	}

	public async Task Delete(T entity)
	{
		_context.Set<T>().Remove(entity);
		await _context.SaveChangesAsync();
	}

	public async Task<List<T>?> GetListByPredicateAsync(Expression<Func<T, bool>> predicate)
	{
		return await _context
			.Set<T>()
			.Where(predicate)
			.ToListAsync();
	}

	public async Task<List<T>?> GetAllAsync()
	{
		return await _context.Set<T>().ToListAsync();
	}

	public async Task<T?> GetById(Guid Id)
	{
		return await _context.Set<T>()
			.FindAsync(Id);
	}

	public async Task Update(T entity)
	{
		_context.Entry(entity).State = EntityState.Modified;
		await _context.SaveChangesAsync();
	}
}
