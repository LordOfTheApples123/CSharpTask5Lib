using ConsoleApp1;

namespace ClassLibrary1;

public class ModelB: SiemensMobile
{
    public ModelB(string company, int prop1, double prop2, string b2, int b1) : base(company, prop1, prop2)
    {
        B2 = b2;
        B1 = b1;
    }

    private string B2
    {
        get;
        set;
    }

    private int B1
    {
        get;
        set;
    }

    public int B1Method(int x)
    {
        return B1 + x;
    }

    public string B2Method(string x)
    {
        return B2 + x;
    }
}