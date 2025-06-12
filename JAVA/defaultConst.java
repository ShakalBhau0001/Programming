// Default Contructor

public class defaultConst 
{
    int rn;
    String name;
    defaultConst()
    {
        rn=82;
        name="Alone";
    }
    void display()
    {
        System.out.println(rn);
        System.out.println(name);
    }
    public static void main (String args[])
    {
        defaultConst a= new defaultConst();
        defaultConst b= new defaultConst();
        defaultConst c= new defaultConst();
        a.display();
        b.display();
    }
}
