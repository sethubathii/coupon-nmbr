using System;

internal class Scanner
{
    private object p1;
    private object p2;
    private int v;
    private string v1;

    public Scanner(int v)
    {
        this.v = v;
    }

    public Scanner(string v1)
    {
        this.v1 = v1;
    }

    public Scanner(object p1, in object p2)
    {
        this.p1 = p1;
        this.p2 = p2;
    }

    internal void close()
    {
        throw new NotImplementedException();
    }

    internal int nextInt()
    {
        throw new NotImplementedException();
    }
}