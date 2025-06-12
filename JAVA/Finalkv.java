// Using Variable 

public class Finalkv
{
    public static void main(String args[])
    {
        final int x=30;
        System.out.println(x);
        x=x+1;
        System.out.println(x);
    }
}

//error: cannot assign a value to final variable x 
// x=x+1;
