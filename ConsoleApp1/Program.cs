using System;
using System.Collections.Generic;
using Starts2000.EFCoreCodeFirst.Models;
using System.Linq;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           TestDao();
           Console.ReadKey();
        }

        static async void TestDao()
        {
            EFDao<User> efdao = new EFDao<User>(new TestDbContext());
            var user = new User()
            {
                Aaccount = "CodeFirst-Test-" + DateTime.Now.ToString("yyyyMMddHHmmssfff"),
                Password = "123456"
            };
            var addret = await efdao.Add(user);
            var list = efdao.GetEntities(e => true).ToList();
        }
    }
}
