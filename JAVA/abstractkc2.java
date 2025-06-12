// abstract keyword class using static keyword

abstract class A
{
    static int a=250;
    A(int b)
    {
        System.out.println("Hello "+b);
    }
    abstract void sum();
    static void display()
    {
        System.out.println(a);
    }
}

class B extends A 
{
    int x=700,y=300,z;
    B()
    {
        super(90);
    }
    void sum()
    {
        z=x+y;
        System.out.println(z);
    }
}

public class abstractkc2
{
    public static void main (String[] args)
    {
        B w=new B();
        w.sum();
        A.display();
    }
}
