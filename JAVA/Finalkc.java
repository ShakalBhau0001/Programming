// Using Class

final class A
{
    final void show()
    {
        System.out.println("Final Show");
    }
}

class B extends A
{
    void show()
    {
        System.out.println("Hello Students");
    }
}

public class Finalkc
{
    public static void main(String args[])
    {
        B m=new B();
        m.show();
    }
}

/*
error: cannot inherit from final A
class B extends A
                ^
Finalkc.java:13: error: show() in B cannot override show() in A
    void show()
         ^
  overridden method is final
*/
