
namespace HW6
{
    abstract class Worker
    {
        public string name { get; set; } = "Unknown";
        public int salary { get; set; }

        public Worker() { }
        public Worker(string name, int salary) 
        {
            this.name = name;
            this.salary = salary;
        }
        public virtual void Print()
        {
            Console.WriteLine($"name: {name}\nsalary: {salary}");
        }
    }
}
