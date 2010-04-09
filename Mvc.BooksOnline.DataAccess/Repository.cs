using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mvc.BooksOnline.DataAccess
{
    /// <summary>
    /// Abstract base class, for all data access objects (DAOs). Implements IRepository interface, and contains basic CRUD operations logic.
    /// </summary>
    /// <typeparam name="T">Business entity type.</typeparam>
    /// <typeparam name="IdT">The type of the primary identifier of T entity.</typeparam>
    public abstract class Repository<T, IdT> : IRepository<T, IdT> where T : class
    {
        #region IRepository<T,IdT> Members

        /// <summary>
        /// Finds the entity instance by its identifier.
        /// </summary>
        /// <param name="id">The instance's identifier.</param>
        /// <param name="locked">if set to <c>true</c>, will lock persistent object.</param>
        /// <returns></returns>
        public T FindById(IdT id, bool locked)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Finds all persitent objects of type T.
        /// </summary>
        /// <returns></returns>
        public List<T> FindAll()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Finds persistent objects by exemple.
        /// </summary>
        /// <param name="exemple">The entity example.</param>
        /// <returns></returns>
        public List<T> FindByExemple(T exampleEntity, params string[] propertiesToExclude)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Makes the entity object persistent.
        /// </summary>
        /// <param name="entity">The entity of type T.</param>
        /// <returns></returns>
        public T MakePersistent(T entity)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Makes the entity object transient.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public void MakeTransient(T entity)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
