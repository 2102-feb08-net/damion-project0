using System;
using DataAccess;
namespace ProjectUI
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInterface run = new UserInterface(new MemberRepository(),new StoreRepository(),new ProductRepository(), new OrderRepository());
            run.Run();

        }
    }
}
