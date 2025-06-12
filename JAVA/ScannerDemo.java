import java.util.*;
class student
{
    int rn;
    String name;

    void get()
    {
        Scanner s =new Scanner(System.in);
        System.out.print("Enter Roll Num:-> ");
        rn=s.nextInt();
        System.out.print("Enter Name:-> ");
        name=s.next();
    }

    void show()
    {
        System.out.println("Roll Num:-> "+rn);
        System.out.println("Name:-> "+name);
    }
}

class ScannerDemo
{
    public static void main (String args[])
    {
        student a = new student ();
        a.get();
        a.show();
    }
}
