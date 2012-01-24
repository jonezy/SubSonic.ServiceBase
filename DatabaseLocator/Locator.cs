using System;
using System.Collections.Generic;
using System.Reflection;

namespace DatabaseLocator {
    
    public class Locator {
        private Dictionary<Type, Type> _endPoints;
        private Dictionary<Type, object> _endPointsCache;

        private static readonly object l = new Object();
        private static Locator instance;

        public static Locator Instance {
            get {
                lock (l) {
                    if (instance == null) {
                        instance = new Locator();
                    }
                }

                return instance;
            }
        }

        internal Locator() {
            _endPoints = DatabaseTable.Databases;
            _endPointsCache = new Dictionary<Type, object>();
        }
        
        public T GetEndPoint<T>() {
            if(_endPointsCache.ContainsKey(typeof(T))) {
                return (T)_endPointsCache[typeof(T)];
            }

            try {
                ConstructorInfo constructor = null;
                foreach (KeyValuePair<Type, Type> item in _endPoints) {
                    if(item.Key == typeof(T)) {
                        constructor = item.Value.GetConstructor(new Type[0]);
                        break;
                    }
                }

                if (constructor == null)
                    return default(T);

                T service = (T)constructor.Invoke(null);

                _endPointsCache.Add(typeof(T), service);

                return service;
            } catch (KeyNotFoundException) {
                throw new ApplicationException("The requested service is not registered");
            }
        }
    }

    public class DatabaseTable {
        private static readonly object l = new Object();
        private static DatabaseCollection instance;

        public static DatabaseCollection Databases {
            get {
                lock (l) {
                    if (instance == null) {
                        instance = new DatabaseCollection();
                    }
                }

                return instance;
            }
        }
    }

    public class DatabaseCollection : Dictionary<Type, Type> { }

    public static class Extensions {
        public static void MapStorageEndPoint(this DatabaseCollection endPoints, Type endPointType, Type endPointImplementation) {
            endPoints.Add(endPointType, endPointImplementation);
        }
    }
}