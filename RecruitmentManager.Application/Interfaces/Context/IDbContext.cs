namespace RecruitmentManager.Application.Interfaces.Context;

public interface IDbContext
{
	IQueryable<TEntity> Get<TEntity>() where TEntity : class;
}
