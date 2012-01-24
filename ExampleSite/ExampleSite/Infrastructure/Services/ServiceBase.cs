using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Caching;

using DatabaseLocator;

using SubSonic.Query;
using SubSonic.Repository;
using SubSonic.Schema;

/// <summary>
/// Base class to be used in a Service Pattern with SubSonic providing the repositories.
/// </summary>
public abstract class ServiceBase {
    protected virtual double CacheExpiry {
        get { return 60; }
    } // time in seconds the cache should live for

    protected abstract string CacheKey {
        get;
    } // a unique way to identify the item in the cache

    protected CacheHelper CacheHelper;

    public ServiceBase() {
        if (App.CachingEnabled) {
            if (CacheHelper == null) CacheHelper = new CacheHelper(HttpRuntime.Cache);
        }
    }

    public bool IsConnected<U>() where U : IQuerySurface {
        IQuerySurface Database = Locator.Instance.GetEndPoint<U>();
        if (Database != null) {
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

        return false;

    }

    public virtual List<T> GetData<T, U>() where T : class, new() where U : IQuerySurface {
        return GetRepository<T, U>().GetAll().ToList();
    }

    public virtual List<T> GetData<T, U>(Expression<Func<T, bool>> expression) where T : class, new() where U : IQuerySurface {
        string newCacheKey = CacheKey;
        if(expression != null)
            newCacheKey = string.Format("{0}:{1}", CacheKey, expression.ToString());
        
        List<T> data = CacheHelper != null && CacheExpiry > 0 ? CacheHelper.Get(newCacheKey) as List<T> : null;
        if (data == null) {
            SubSonicRepository<T> repository = GetRepository<T, U>();
            if (expression != null) {
                data = repository.Find(expression).ToList();
            } else {
                data = repository.GetAll().ToList();
            }

            if (CacheHelper != null)
                CacheHelper.Add(newCacheKey, data, DateTime.Now.AddSeconds(CacheExpiry));
        }
        
        return data;
    }

    public virtual object Save<T, U>(T entity) where T : class, new()  where U : IQuerySurface {
        IRepository<T> repository = null;
        ITable tbl = null;
        IQuerySurface database = Locator.Instance.GetEndPoint<U>();

        try {
            tbl = database.Provider.FindOrCreateTable(typeof(T)); // TODO: this should be FindTable
            repository = GetRepository<T, U>();
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

    private SubSonicRepository<T> GetRepository<T, U>() where T : class, new() where U : IQuerySurface {
        IQuerySurface db = Locator.Instance.GetEndPoint<U>();

        return new SubSonicRepository<T>(db);
    }
}

/// <summary>
/// Helper class that stores various static information about the application
/// </summary>
public static class App {
    public static bool CachingEnabled {
        get {
            if (ConfigurationManager.AppSettings["CachingEnabled"] != null) {
                bool enabled;
                bool.TryParse(ConfigurationManager.AppSettings["CachingEnabled"].ToString(), out enabled);

                return enabled;
            }

            return false;
        }
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

    public void Add(string keyName, object value, DateTime expiration) {
        if (expiration == null)
            throw new ArgumentException("Experation argument cannot be null");

        if (_cache.Get(keyName) != null)
            _cache.Remove(keyName);

        _cache.Add(keyName, value, null, expiration, Cache.NoSlidingExpiration, CacheItemPriority.Normal, null);
    }

    public void Add(string keyName, object value) {
        if (_cache.Get(keyName) != null)
            _cache.Remove(keyName);

        _cache.Add(keyName, value, null, DateTime.Now.AddMinutes(60), Cache.NoSlidingExpiration, CacheItemPriority.Normal, null);
    }

    public object Get(string keyName) {
        try {
            return _cache.Get(keyName);
        } catch { return null; }
    }

    public bool Remove(string keyName) {
        try {
            _cache.Remove(keyName);
            return true;
        } catch { return false; }
    }
}