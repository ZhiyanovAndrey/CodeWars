


B obj1 = (B)new A(); // не удается неявно преобразовать
obj1.Foo();          // Unable to cast object of type 'A' to type 'B'."


B obj2 = new B();
obj2.Foo();        // Class B

A obj3 = new B();
obj3.Foo();        // Работает явное переопределение в Class B

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