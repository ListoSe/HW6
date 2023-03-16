
namespace HW6
{
    internal class Engineer: Worker
    {
        public Engineer() { }
        public Engineer(string name, int salary)
        : base(name, salary) { }

        public override void Print()
        {
            Console.WriteLine("Engineer");
            base.Print();
        }
    }
}
