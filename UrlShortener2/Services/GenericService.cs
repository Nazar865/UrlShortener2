using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using UrlShortener2.Data;

namespace UrlShortener2.Services
{
	public class GenericService<T> where T : class
	{
		public readonly AppDbContext _dbContext;

		public GenericService(AppDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public async Task<int> SaveChanges()
		{
			return await _dbContext.SaveChangesAsync();
		}

		public async Task<IEnumerable<T>> GetRangeAsync()
		{
			return await _dbContext.Set<T>().ToListAsync();
		}

		public async Task<T> GetAsync(Guid id)
		{
			return await _dbContext.Set<T>().FindAsync(id);
		}

		public async Task InserAsynct(T entity, bool saveChanges = true)
		{
			_dbContext.Set<T>().Add(entity);
			if (saveChanges)
				await _dbContext.SaveChangesAsync();
		}

		public async Task InsertRangeAsync(IEnumerable<T> entities, bool saveChanges = true)
		{
			_dbContext.Set<T>().AddRange(entities);
			if (saveChanges)
				await _dbContext.SaveChangesAsync();
		}

		public async Task RemoveAsync(T entity, bool saveChanges = true)
		{
			_dbContext.Set<T>().Remove(entity);
			if (saveChanges)
				await _dbContext.SaveChangesAsync();
		}

		public async Task UpdateAsync(T entity, bool saveChanges = true)
		{
			_dbContext.Set<T>().Update(entity);
			if (saveChanges)
				await _dbContext.SaveChangesAsync();
		}

		public async Task UpdateRangeAsync(IEnumerable<T> entities, bool saveChanges = true)
		{
			_dbContext.Set<T>().UpdateRange(entities);
			if (saveChanges)
				await _dbContext.SaveChangesAsync();
		}

		public async Task<T> FindByConditionAsync(Expression<Func<T, bool>> expression)
		{
			var result = await _dbContext.Set<T>().FirstOrDefaultAsync(expression);

			return result;
		}
	}
}