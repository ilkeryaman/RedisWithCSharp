using System;

namespace RedisWithCSharp.Cache.Provider
{
    public interface ICacheProvider
    {
        void Set<T>(string key, T value);

        void Set<T>(string key, T value, DateTime cacheTime);

        T Get<T>(string key);

        bool Remove(string key);

        bool IsInCache(string key);

        bool IsInCache<T>(string key, ref T value);
    }
}
