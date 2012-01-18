using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Caching;

using ExampleSite.Infrastructure.Data; // update this to match the the namespace specified in Infrastructure\Data\Settings.ttinclude => Namespace

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

    protected ExampleSiteDB Database; // modify this to match what is specified in Infrastructure\Data\Settings.ttinclude => DatabaseName (minus the db)
        
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
        if (Database == null) Database = new ExampleSiteDB(); // modify this to match what is specified in Infrastructure\Data\Settings.ttinclude => DatabaseName (minus the db)
    }

    protected SubSonicRepository<T> GetRepository<T>() where T : class, new() {
        Initialize();

        return new SubSonicRepository<T>(Database);
    }

    public virtual List<T> GetData<T>() where T : class, new() {
        return GetRepository<T>().GetAll().ToList();
    }

    public virtual List<T> GetData<T>(Expression<Func<T, bool>> expression) where T : class, new() {
        string newCacheKey = CacheKey;
        if (expression != null)
            newCacheKey = string.Format("{0}:{1}", CacheKey, expression.ToString());

        List<T> data = CacheHelper != null && CacheExpiry > 0 ? CacheHelper.Get(newCacheKey) as List<T> : null;

        if (data == null) {
            if (expression != null) {
                data = GetRepository<T>().Find(expression).ToList();
            }

            if (CacheHelper != null)
                CacheHelper.Add(newCacheKey, data, DateTime.Now.AddSeconds(CacheExpiry));
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
    
    public virtual void Delete<T>(int id) where T: class, new() {
        GetRepository<T>().Delete(id);
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