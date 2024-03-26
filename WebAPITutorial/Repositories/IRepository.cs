using System.Linq.Expressions;

namespace WebAPITutorial.Repositories;

public interface IRepository<T> where T : class
{
	IEnumerable<T> GetAll();
	IEnumerable<T> Get(Expression<Func<T, bool>> expression);
	bool Add(T entity);
	bool AddRange(IEnumerable<T> entities);
	bool Remove(T entity);
	bool RemoveRange(IEnumerable<T> entities);
	int Save();
}

// generic make T jadi biar tipe class apa aja bisa masuk, kan ada class Category, Product
// Expression ini jadi kan ada method get by id trus nanti ada findordefault trus nanti ada masukin function nah itu biar bisa flexibel