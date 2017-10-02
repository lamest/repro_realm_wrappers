using System;
using Realms;

namespace repro_wrappers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var t = Realm.GetInstance();
            Console.Write(t.ToString());
        }
    }
}