using System;

namespace Exercise1Strategy
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Flying with wings.");
        }
    }

    public class FlyWithJetPropulsion : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("WHOOOOOOSH!");
        }
    }

    public class QuackLikeMallard : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack!");
        }
    }

    public class QuackLikeSpaniel : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Woof!");
        }
    }
}
