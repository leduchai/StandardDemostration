using System.Collections.Generic;


namespace Website_LDHai.DataAccess.Dao
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IActionDao<T>
    {
        /// <summary>
        /// Inserts the specified t.
        /// </summary>
        /// <param name="t">The t.</param>
        /// <returns></returns>
        int Insert(T t);

        /// <summary>
        /// Updates the specified t.
        /// </summary>
        /// <param name="t">The t.</param>
        /// <returns></returns>
        int Update(T t);

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        int Delete(int id);

        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        T GetById(int id);

        /// <summary>
        /// Gets the list.
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> GetList();
    }
}
