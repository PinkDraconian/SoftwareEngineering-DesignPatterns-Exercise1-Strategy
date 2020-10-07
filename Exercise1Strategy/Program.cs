using System;

namespace Exercise1Strategy
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Mallard");
            Mallard mallard = new Mallard();
            Helper(mallard);

            Console.WriteLine("Spaniel");
            Spaniel spaniel = new Spaniel();
            Helper(spaniel);

            Console.WriteLine("Progeny");
            Spaniel progeny = new Spaniel();
            progeny.SetQuack(new QuackLikeMallard());
            Helper(progeny);

            Console.WriteLine("SuperDuperDuck");
            SuperDuperDuck superDuperDuck = new SuperDuperDuck();
            Helper(superDuperDuck);

            Console.ReadLine();
        }

        static void Helper(Duck myDuck)
        {
            myDuck.Swim();
            myDuck.DoFly();
            myDuck.DoQuack();
        }
    }
}
