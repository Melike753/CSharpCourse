namespace InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Worker(),
                new Manager(),
                new Robot(),
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[2]
            {
                new Worker(),
                new Manager(),
            };

            foreach (var eat in eats)
            {
                eat.Eat();
            }
        }
    }

    interface IWorker
    {
        void Work();
    }

    interface IEat
    {
        void Eat();
    }

    interface IGetSalary
    {
        void GetSalary();
    }

    // Bir class birden fazla interface i implemente edebilir.
    class Manager : IWorker, IEat, IGetSalary
    {
        public void Work() { }
        public void Eat() { }
        public void GetSalary() { }
    }
    class Worker : IWorker, IGetSalary, IEat
    {
        public void Work() { }
        public void Eat() { }
        public void GetSalary() { }
    }
    class Robot : IWorker
    {
        public void Work() { }

    }
}