
namespace HW6
{
    internal class Manager : Worker
    {
        public Manager() { }
        public Manager(string name, int salary)
        : base(name, salary) { }

        public override void Print()
        {
            Console.WriteLine("Manager");
            base.Print();
        }
    }
}
