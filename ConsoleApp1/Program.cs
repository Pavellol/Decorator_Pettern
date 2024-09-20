class Program
{
    static void Main(string[] args)
    {
        Pencil pencil1 = new PencilCar();
        
        Console.WriteLine("{0}", pencil1.Name);        
        Console.WriteLine("Цена: {0}", pencil1.GetCost());
        Console.WriteLine();

        Pencil pencil2 = new PencilHelicopter();

        Console.WriteLine("{0}", pencil2.Name);
        Console.WriteLine("Цена: {0}", pencil2.GetCost());
        Console.WriteLine();

        Pencil pencil3 = new PencilPlane();

        Console.WriteLine("{0}", pencil3.Name);
        Console.WriteLine("Цена: {0}", pencil3.GetCost());
        Console.WriteLine();
       
        Console.ReadLine();
    }
}
abstract class Pencil
{
    public Pencil(string n)
    {
        this.Name = n;
    }
    public string Name { get; protected set; }
    public abstract int GetCost();
}
class PencilCar : Pencil
{
    public PencilCar() : base("Ручка на колесах")
    {
        Drive();
    }

    public override int GetCost()
    {
        return 200;
    }

    public void Drive()
    {
        Console.WriteLine("Ручка теперь с клесиками, поехали ....!");
    }
}
class PencilHelicopter : Pencil
{
    public PencilHelicopter() : base("Ручка теперь имеет несущий винт")
    {
        FlyUp();
    }

    public override int GetCost()
    {
        return 300;
    }

    public void FlyUp()
    {
        Console.WriteLine("Ручка теперь можел летать вверх, вниз. Ура!");
    }
}
class PencilPlane : Pencil
{
    public PencilPlane() : base("Ручка теперь имеет крылья")
    {
        Fly();
    }

    public override int GetCost()
    {
        return 400;
    }
    private void Fly()
    {
        Console.WriteLine("Ручка теперь летать в доль горизонта. Юху!");
    }
}