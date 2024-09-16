class Program
{
    static void Main(string[] args)
    {
        Pencil pencil1 = new PencilRed();
        pencil1 = new PencilDrive(pencil1);
        Console.WriteLine("{0}", pencil1.Name);
        Console.WriteLine("Цена: {0}", pencil1.Do());

        Pencil pencil2 = new PencilBlack();
        pencil2 = new PencilFly(pencil2);
        Console.WriteLine("{0}", pencil2.Name);
        Console.WriteLine("Цена: {0}", pencil2.Do());
        /*
                Pizza pizza1 = new ItalianPizza();
                pizza1 = new TomatoPizza(pizza1); // итальянская пицца с томатами
                Console.WriteLine("Название: {0}", pizza1.Name);
                Console.WriteLine("Цена: {0}", pizza1.GetCost());

                Pizza pizza2 = new ItalianPizza();
                pizza2 = new CheesePizza(pizza2);// итальянская пиццы с сыром
                Console.WriteLine("Название: {0}", pizza2.Name);
                Console.WriteLine("Цена: {0}", pizza2.GetCost());

                Pizza pizza3 = new BulgerianPizza();
                pizza3 = new TomatoPizza(pizza3);
                pizza3 = new CheesePizza(pizza3);// болгарская пиццы с томатами и сыром
                Console.WriteLine("Название: {0}", pizza3.Name);
                Console.WriteLine("Цена: {0}", pizza3.GetCost());*/
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
    public abstract int Do();
}
class PencilRed : Pencil
{    
    public PencilRed() : base("Красная ручка")
    {
    }

    public override int Do()
    {
        return 15;
    }
}
class PencilBlack : Pencil
{
    public PencilBlack() : base("Черная ручка")
    {
    }

    public override int Do()
    {
        return 10;
    }
}
abstract class PencilDecorator : Pencil
{
    protected Pencil pencil;
    public PencilDecorator(string n, Pencil pencil) : base(n)
    {
        this.pencil = pencil;
    }
}
class PencilDrive : PencilDecorator
{
    public PencilDrive(Pencil pencil) : base(pencil.Name + " ездит на колесиках", pencil)
    {
    }

    public override int Do()
    {
        return pencil.Do() + 10;
    }
}
class PencilFly : PencilDecorator
{
    public PencilFly(Pencil pencil) : base(pencil.Name + " летает как самолет", pencil)
    {
    }

    public override int Do()
    {
        return pencil.Do() + 10000;
    }
}

 