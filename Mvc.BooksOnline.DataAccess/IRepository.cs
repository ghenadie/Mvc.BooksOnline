using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mvc.BooksOnline.DataAccess
{
    /// <summary>
    /// Base interface for all data access objects (DAOs) interfaces.
    /// </summary>
    /// <typeparam name="T">Business entity type.</typeparam>
    /// <typeparam name="IdT">The type of the primary identifier of T entity.</typeparam>
    public interface IRepository<T,IdT>
    {
        /// <summary>
        /// Finds the entity instance by its identifier.
        /// </summary>
        /// <param name="id">The instance's identifier.</param>
        /// <param name="locked">if set to <c>true</c>, will lock persistent object.</param>
        /// <returns></returns>
        T FindById(IdT id, bool locked);
        /// <summary>
        /// Finds all persitent objects of type T.
        /// </summary>
        /// <returns></returns>
        List<T> FindAll();
        /// <summary>
        /// Finds persistent objects by exemple.
        /// </summary>
        /// <param name="exemple">The entity example.</param>
        /// <returns></returns>
        List<T> FindByExemple(T exampleEntity, params string[] propertiesToExclude);
        /// <summary>
        /// Makes the entity object persistent.
        /// </summary>
        /// <param name="entity">The entity of type T.</param>
        /// <returns></returns>
        T MakePersistent(T entity);
        /// <summary>
        /// Makes the entity object transient.
        /// </summary>
        /// <param name="entity">The entity.</param>
        void MakeTransient(T entity);
    }
}
