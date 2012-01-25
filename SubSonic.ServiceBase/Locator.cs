using System;
using System.Collections.Generic;
using System.Reflection;

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
        _endPoints = DatabaseEndPointTable.Databases;
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

public class DatabaseEndPointTable {
    private static readonly object l = new Object();
    private static DatabaseEndPointCollection instance;

    public static DatabaseEndPointCollection Databases {
        get {
            lock (l) {
                if (instance == null) {
                    instance = new DatabaseEndPointCollection();
                }
            }

            return instance;
        }
    }
}

public class DatabaseEndPointCollection : Dictionary<Type, Type> { }

public static class Extensions {
    public static void MapStorageEndPoint(this DatabaseEndPointCollection endPoints, Type endPointType, Type endPointImplementation) {
        endPoints.Add(endPointType, endPointImplementation);
    }
}
