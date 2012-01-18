using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

using ExampleSite.Data; // update this to match the the namespace specified in App_Data\Settings.ttinclude => Namespace

using SubSonic.Query;
using SubSonic.Repository;
using SubSonic.Schema;

namespace ExampleSite.Infrastructure {
    public abstract class ServiceBase {
        protected IQuerySurface Database;
        
        public bool IsConnected {
            get {
                try {
                    return Database.Provider.Schema.Tables.Count > 0;
                } catch {
                    return false;
                }
            }
        }

        public ServiceBase() {
            Initialize();
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
            if (expression == null) {
                return GetRepository<T>().GetAll().ToList();
            } else {
                return GetRepository<T>().Find(expression).ToList();
            }
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
}