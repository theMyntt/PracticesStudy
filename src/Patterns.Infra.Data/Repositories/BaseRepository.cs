using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Patterns.Infra.Data.Abstractions;
using Patterns.Infra.Data.Context;

namespace Patterns.Infra.Data.Repositories;

public class BaseRepository<T> : IBaseRepository<T> where T : class
{
    private readonly DatabaseContext _context;
    private readonly DbSet<T> _table;

    public BaseRepository(DatabaseContext context)
    {
        _context = context;
        _table = _context.Set<T>();
    }
    
    public async Task SaveAsync(T input)
    {
        await _table.AddAsync(input);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<T>> FindAllAsync(int page, int limit)
    {
        int skip = (limit - 1) * page;

        return await _table
            .Skip(skip)
            .Take(limit)
            .ToListAsync();
    }

    public async Task<IEnumerable<T>?> FilterAsync(Expression<Func<T, bool>> filter)
    {
        return await _table.Where(filter).ToListAsync();   
    }

    public async Task<T?> FindOneAsync(Expression<Func<T, bool>> filter)
    {
        return await _table.FirstOrDefaultAsync(filter);
    }

    public async Task DeleteAsync(Expression<Func<T, bool>> filter)
    {
        var entity = await _table.FirstOrDefaultAsync(filter);

        if (entity == null)
            throw new Exception("Entity is null");
        
        _table.Remove(entity);
        await _context.SaveChangesAsync();
    }

    public async Task EditAsync(T input)
    {
        _table.Update(input);
        await _context.SaveChangesAsync();
    }
}