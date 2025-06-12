// Parameterized Constructor

public class paraConst
{
    int rn;
    String name;
    paraConst(int x, String n)
    {
        rn=x;
        name=n;
        System.out.println(rn);
        System.out.println(name);
    }
    public static void main(String args[]) 
    {
       paraConst a= new paraConst(10, "abc");
       paraConst b= new paraConst(20, "def");
       paraConst c= new paraConst(30, "ghi"); 
    }
}
