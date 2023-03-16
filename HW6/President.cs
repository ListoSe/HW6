
namespace HW6
{
    internal class President : Worker
    {
        public President() { }
        public President(string name, int salary)
        :base(name, salary) { }

        public override void Print()
        {
            Console.WriteLine("President");
            base.Print();
        }
    }
}
