
namespace HW6
{
    internal class Kettle : Teach
    {
        public int TimeToHot { get; set; }

        public Kettle() { }
        public Kettle(string name, string sound, string description,
            int timeToHot)
            : base(name, sound, description)
        {
            TimeToHot = timeToHot;
        }

        public override void Desc()
        {
            base.Desc();
            Console.WriteLine($"TimeToHot: {TimeToHot}");
        }

        public override void Show()
        {
            Console.WriteLine("Kettle");
            base.Show();
        }
    }
}
