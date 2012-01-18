using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web.Caching;

using ExampleSite.Data; // update this to match the the namespace specified in App_Data\Settings.ttinclude => Namespace

using SubSonic.Query;
using SubSonic.Repository;
using SubSonic.Schema;
using System.Web;
using System.Data.SqlClient;

namespace ExampleSite.Infrastructure {
    public abstract class ServiceBase {
        protected virtual double CacheExpiry {
            get { return 60; }
        } // time in seconds the cache should live for

        protected abstract string CacheKey {
            get;
        } // a unique way to identify the item in the cache

        protected CacheHelper CacheHelper;

        protected IQuerySurface Database;
        
        public bool IsConnected {
            get {
                SqlConnection connection = new SqlConnection(Database.Provider.ConnectionString);
                try {
                    connection.Open();
                    return true;
                } catch {
                    return false;
                } finally {
                    connection.Close();
                    connection.Dispose();
                }
            }
        }

        public ServiceBase() {
            Initialize();

            if (App.CachingEnabled) {
                if (CacheHelper == null) CacheHelper = new CacheHelper(HttpContext.Current.Cache);
            }
        }

        private void Initialize() {
            if (Database == null) Database = new ExampleSiteDB(); // modify this to match what is specified in App_Data\Settings.ttinclude => DatabaseName (minus the db)
        }

        protected SubSonicRepository<T> GetRepository<T>() where T : class, new() {
            Initialize();

            return new SubSonicRepository<T>(Database);
        }

        public virtual List<T> GetData<T>() where T : class, new() {
            return GetRepository<T>().GetAll().ToList();
        }

        public virtual List<T> GetData<T>(Expression<Func<T, bool>> expression) where T : class, new() {
            List<T> data;
            if (expression == null) {
                data = CacheHelper != null && CacheExpiry > 0 ? CacheHelper.Get(CacheKey) as List<T> : null;

                if (data == null) {
                    data = GetRepository<T>().GetAll().ToList();
                    if (CacheHelper != null)
                        CacheHelper.Add(CacheKey, data, DateTime.Now.AddSeconds(CacheExpiry));
                }

                
            } else {
                string newCacheKey = string.Format("{0}:{1}", CacheKey, expression.ToString());
                data = CacheHelper != null && CacheExpiry > 0 ? CacheHelper.Get(newCacheKey) as List<T> : null;

                if (data == null) {
                    data = GetRepository<T>().Find(expression).ToList();
                    if (CacheHelper != null)
                        CacheHelper.Add(newCacheKey, data, DateTime.Now.AddSeconds(CacheExpiry));
                }
            }

            return data;
        }

        public virtual object Save<T>(T entity) where T : class, new() {
            IRepository<T> repository = null;
            ITable tbl = null;
            try {
                tbl = Database.Provider.FindOrCreateTable(typeof(T));
                repository = GetRepository<T>();
            } catch { }

            if (repository == null || tbl == null)
                return null;

            var prop = entity.GetType().GetProperty(tbl.PrimaryKey.Name); // determine the pk field of the entities table.
            int primaryKeyValue;
            int.TryParse(prop.GetValue(entity, null).ToString(), out primaryKeyValue); // figure out the value of the pk

            if (primaryKeyValue > 0)
                return repository.Update(entity);

            return repository.Add(entity);
        }
    }

    /// <summary>
    /// Generic class to manage adding, removing and retrieving objects from cache.
    /// </summary>
    public class CacheHelper {
        private Cache _cache;

        public CacheHelper(Cache cache) {
            _cache = cache;
        }

        /// <summary>
        /// Adds the value to the cache and set's the expiry to the value passed in 
        /// the expiration argument.
        /// </summary>
        /// <param name="keyName">The key used to identify this value in the cache</param>
        /// <param name="value">The object to store in cache</param>
        /// <param name="expiration">How long until the cache expires</param>
        public void Add(string keyName, object value, DateTime expiration) {
            if (expiration == null)
                throw new ArgumentException("Experation argument cannot be null");

            if (_cache.Get(keyName) != null)
                _cache.Remove(keyName);

            _cache.Add(keyName, value, null, expiration, Cache.NoSlidingExpiration, CacheItemPriority.Normal, null);
        }


        /// <summary>
        /// Adds the value to the cache and set's the expiry to 1 hour
        /// </summary>
        /// <param name="keyName">The key used to identify this value in the cache</param>
        /// <param name="value">The object to store in cache</param>
        public void Add(string keyName, object value) {
            if (_cache.Get(keyName) != null)
                _cache.Remove(keyName);

            _cache.Add(keyName, value, null, DateTime.Now.AddMinutes(60), Cache.NoSlidingExpiration, CacheItemPriority.Normal, null);
        }

        /// <summary>
        /// Returns the value in the cache associated with the keyName argument.
        /// </summary>
        /// <param name="keyName">The cache key to find the value for</param>
        /// <returns>The value in the cache, or null if not found.</returns>
        public object Get(string keyName) {
            try {
                return _cache.Get(keyName);
            } catch { return null; }
        }

        /// <summary>
        /// Removes the cache entry for the keyName argument.
        /// </summary>
        /// <param name="keyName">The cache key to remove from the cache.</param>
        /// <returns>True if removed, false if not.</returns>
        public bool Remove(string keyName) {
            try {
                _cache.Remove(keyName);
                return true;
            } catch { return false; }
        }
    }
}