using HW6;
//Task 1
/*var teach = new Teach[]
{
    new Kettle ("aboba", "chs-sd", "bibobop", 100),
    new Car ("Car", "vhiyyyy", "sup fast", 170)
};
foreach (var t in teach)
{
    t.Show();
    t.Sound();
    t.Desc();
    Console.WriteLine();
}*/
//Task 2
var teach = new Worker[]
{
    new President("Piter",300),
    new Security("Parker",40),
    new Manager("Ben",5),
    new Engineer("Solo",800),
};
foreach(var worker in teach)
{
    worker.Print();
}