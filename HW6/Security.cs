

namespace HW6
{
    internal class Security : Worker
    {
        public Security() { }
        public Security(string name, int salary)
        : base(name, salary) { }

        public override void Print()
        {
            Console.WriteLine("Security");
            base.Print();
        }
    }
}
