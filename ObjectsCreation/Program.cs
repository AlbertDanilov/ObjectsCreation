
A a1 = new A();
B b1 = new B();
C c1 = new C();

A a2 = new B();

a1.foo();
b1.foo();

a2.foo();
c1.foo();


public class A
{
    public A() { Console.WriteLine("I'm A"); }

    public virtual void foo() 
    { 
        Console.WriteLine("foo A"); 
    }  
}

public class B : A
{
    public B() { Console.WriteLine("I'm B"); }

    public override void foo() 
    { 
        Console.WriteLine("foo B"); 
    }
}

public class C : A
{
    public C() { Console.WriteLine("I'm C"); }

    public override void foo()
    {
        Console.WriteLine("foo C");

        base.foo();
    }
}

