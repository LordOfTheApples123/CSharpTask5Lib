namespace ConsoleApp1;

public class ModelA: SiemensMobile
{
    public ModelA(string company, int prop1, double prop2, string a1, int a2) : base(company, prop1, prop2)
    {
        A1 = a1;
        A2 = a2;
    }

    private string A1
    {
        get;
        set;
    }

    private int A2
    {
        get;
        set;
    }

    public string Amethod1()
    {
        return A2.ToString();
    }

    public int AMethod2(int x1, int x2)
    {
        return x1 + x2;
    }
}