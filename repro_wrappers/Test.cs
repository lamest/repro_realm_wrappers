using System;
using NUnit.Framework;
using Realms;

namespace repro_wrappers
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void Test1()
        {
            var t = Realm.GetInstance();
            Console.Write(t.ToString());
        }
    }
}