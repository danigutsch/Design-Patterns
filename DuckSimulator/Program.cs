﻿using DuckSimulator.Composites;
using DuckSimulator.Decorators;
using DuckSimulator.Ducks;
using DuckSimulator.Factories;
using DuckSimulator.Observers;

namespace DuckSimulator
{
    public static class DuckSimulator
    {
        public static void Main()
        {
            //var simulator = new DuckSimulator();
            AbstractDuckFactory duckFactory = new CountingDuckFactory();

            Simulate(duckFactory);
        }

        public static void Simulate(AbstractDuckFactory duckFactory)
        {
            IQuackable redheadDuck = duckFactory.CreateRedheadDuck();
            IQuackable duckCall = duckFactory.CreateDuckCall();
            IQuackable rubberDuck = duckFactory.CreateRubberDuck();
            IQuackable gooseDuck = duckFactory.CreateAdaptedGoose();

            Flock flockOfDucks = new();

            flockOfDucks.Add(redheadDuck);
            flockOfDucks.Add(duckCall);
            flockOfDucks.Add(rubberDuck);
            flockOfDucks.Add(gooseDuck);

            Flock flockOfMallards = new();

            IQuackable mallardOne = duckFactory.CreateMallardDuck();
            IQuackable mallardTwo = duckFactory.CreateMallardDuck();
            IQuackable mallardThree = duckFactory.CreateMallardDuck();
            IQuackable mallardFour = duckFactory.CreateMallardDuck();

            flockOfMallards.Add(mallardOne);
            flockOfMallards.Add(mallardTwo);
            flockOfMallards.Add(mallardThree);
            flockOfMallards.Add(mallardFour);

            flockOfDucks.Add(flockOfMallards);

            Console.WriteLine("\nDuck Simulator: With Observer");

            Quackologist quackologist = new();
            flockOfDucks.RegisterObserver(quackologist);

            Simulate(flockOfDucks);

            Console.WriteLine($"\nThe ducks quacked {QuackCounter.NumberOfQuacks} times");
        }

        public static void Simulate(IQuackable duck) => duck.Quack();
    }
}