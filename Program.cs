using System;

public class Coupon
{
    public static object StdOut { get; private set; }
    public static object Integer { get; private set; }

    // return a random coupon between 0 and n-1
    public static int getCoupon(int n)
    {
        return (int)(Math.random * n);
    }

    // return number of cards you collect before obtaining one of each of the n types
    public static int collect(int n)
    {
        boolean[] isCollected = new boolean[n];
        int count = 0;         
        int distinct = 0;       

        // repeat until you've collected all n card types
        while (distinct < n)
        {
            int value = getCoupon(n);            // pick a random card 
            count++;                             // one more card
            if (!isCollected[value])
            {           // discovered a new card type
                distinct++;
                isCollected[value] = true;
            }
        }
        return count;
    }

    // test client
    public static void main(String[] args)
    {
        int n = Integer.parseInt(args[0]);
        int count = collect(n);
        object p = StdOut.println(count);
    }
}
