
namespace HW6
{
    internal class Car : Teach
    {
        public int MaxSpead { get; set; }

        public Car() { }
        public Car(string name, string sound, string description,
            int maxSpead) 
            : base(name, sound, description)
        {
            MaxSpead = maxSpead;
        }

        public override void Desc()
        {
            base.Desc();
            Console.WriteLine($"maxSpead: {MaxSpead}");
        }

        public override void Show()
        {
            Console.WriteLine("Car");
            base.Show();
        }
    }
}
