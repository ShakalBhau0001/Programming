// Default Contructor Using 'this' keyword

public class defaultConstThisk 
{
    defaultConstThisk()
    {
        System.out.println("Hello SBK");
    }
    defaultConstThisk(int x)
    {
        this();
        System.out.println(x);
    }
    public static void main(String[] args) 
    {
        defaultConstThisk a= new defaultConstThisk(40);
    }
}
