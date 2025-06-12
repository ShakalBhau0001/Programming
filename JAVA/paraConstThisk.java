// Parameterized Constructor using 'this' keyword

public class paraConstThisk 
{
    paraConstThisk()
    {
        this(55);
        System.out.println("Hello SBK");
    }
    paraConstThisk(int x)
    {
        System.out.println(x);
    }
    public static void main(String[] args) 
    {
        paraConstThisk a= new paraConstThisk(); 
    }
}
