using System;

namespace HW6
{
    internal class Teach
    {
        public string name { get; set; } = "Unknown";
        public string sound { get; set; } = "Unknown";
        public string description { get; set; } = "Unknown";
        public Teach() { }
        public Teach(string name, string sound, string description)
        {
            this.name = name;
            this.sound = sound;
            this.description = description;
        }
        public virtual void Sound()
        {
            Console.WriteLine($"Sound: {sound}");
        }

        public virtual void Show()
        {
            Console.WriteLine($"Name: {name}");
        }

        public virtual void Desc()
        {
            Console.WriteLine($"Desc: {description}");
        }
    }
}
