




Console.ReadKey();

class A
{
    public virtual void Foo()
    {
        Console.Write("Class A");
    }
}
class B : A
{
    public override void Foo()
    {
        Console.Write("Class B");
    }
}