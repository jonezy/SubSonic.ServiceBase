using System.Collections.Generic;
using System.Linq;

using ExampleSite.Data;

using SubSonic.Query;
using SubSonic.Repository;
using SubSonic.Schema;

namespace ExampleSite.Infrastructure {
    public abstract class ServiceBase {
        protected IQuerySurface Database;

        public ServiceBase() {
            if (Database == null) Database = new ExampleSiteDB();
        }

        protected SubSonicRepository<T> GetRepository<T>(IQuerySurface db) where T : class, new() {
            return new SubSonicRepository<T>(db);
        }

        protected virtual List<T> GetData<T>(IQuerySurface db) where T : class, new() {
            return GetRepository<T>(db).GetAll().ToList();
        }

        public virtual object Save<T>(T entity) where T : class, new() {
            IRepository<T> repository = null;
            ITable tbl = null;
            try {
                tbl = Database.Provider.FindOrCreateTable(typeof(T));
                repository = GetRepository<T>(Database);
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