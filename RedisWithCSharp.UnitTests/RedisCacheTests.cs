using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RedisWithCSharp.Cache.Provider;
using RedisWithCSharp.Global.DTO;

namespace RedisWithCSharp.UnitTests
{
    [TestClass]
    public class RedisCacheTests
    {
        ICacheProvider _cacheProvider;

        [TestInitialize]
        public void Initialize()
        {
            _cacheProvider = new RedisCacheProvider();
        }

        [TestMethod]
        public void Test_SetValue()
        {
            List<Person> people = new List<Person>()
            {
                new Person(1, "Ilker Yaman", new List<Contact>()
                {
                    new Contact("1", "First contact  of Ilker Yaman"),
                    new Contact("2", "Second contact of Ilker Yaman")
                }),
                new Person(2, "Ahmet Yaman", new List<Contact>()
                {
                    new Contact("1", "First contact of Ahmet Yaman"),
                    new Contact("2", "Second contact of Ahmet Yaman")
                })
            };
            _cacheProvider.Set("People", people);
        }

        [TestMethod]
        public void Test_GetValue()
        {
            var people = _cacheProvider.Get<List<Person>>("People");
            
            Assert.IsNotNull(people);
            Assert.AreEqual(2, people.Count);
        }
    }
}
