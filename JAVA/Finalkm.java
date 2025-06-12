// Using Method 

class A
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

public class Finalkm
{
    public static void main(String args[])
    {
        B m=new B();
        m.show();
    }
}

// error: show() in B cannot override show() in A
//    void show()
//       ^
//  overridden method is final
