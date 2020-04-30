using RedisWithCSharp.Cache.Configuration;
using RedisWithCSharp.Global;
using ServiceStack.Redis;
using System;

namespace RedisWithCSharp.Cache.Provider
{
    public class RedisCacheProvider : ICacheProvider
    {
        readonly RedisEndpoint _endPoint;

        public RedisCacheProvider()
        {
             var config = RedisConfigurationManager.Config;
            _endPoint = new RedisEndpoint(config.Host, config.Port, config.Password, config.DatabaseID);
        }

        public void Set<T>(string key, T value)
        {
            this.Set(key, value, DateTime.UtcNow.AddHours(1));
        }

        public void Set<T>(string key, T value, DateTime cacheTime)
        {
            var timeSpan = Helpers.DateTimeToTimeSpan(cacheTime);
            using (RedisClient client = new RedisClient(_endPoint))
            {
                client.As<T>().SetValue(key, value, timeSpan);
            }
        }

        public T Get<T>(string key)
        {
            T result = default(T);

            using (RedisClient client = new RedisClient(_endPoint))
            {
                var wrapper = client.As<T>();

                result = wrapper.GetValue(key);
            }

            return result;
        }

        public bool Remove(string key)
        {
            bool removed = false;

            using (RedisClient client = new RedisClient(_endPoint))
            {
                removed = client.Remove(key);
            }

            return removed;
        }

        public bool IsInCache(string key)
        {
            bool isInCache = false;

            using (RedisClient client = new RedisClient(_endPoint))
            {
                isInCache = client.ContainsKey(key);
            }

            return isInCache;
        }

        public bool IsInCache<T>(string key, ref T value)
        {
            bool isInCache = false;

            using (RedisClient client = new RedisClient(_endPoint))
            {
                isInCache = client.ContainsKey(key);

                if (isInCache)
                    value = Get<T>(key);
            }

            return isInCache;
        }
    }
}
