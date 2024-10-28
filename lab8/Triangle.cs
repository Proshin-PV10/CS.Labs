using System.Collections;

class Triangle
{
    private double A;
    private double B;
    private double C;
    private double S;
    public Triangle(double ast)
    {
        A = ast;
        B = ast;
        C = ast;
    }



    public Triangle(double ast, double bst, double cst)
    {
        A = ast;
        B = bst;
        C = cst;
    }
    public double STA()
    {
        return A;
    }

    public double STB()
    {
        return B;
    }

    public double STC()
    {
        return C;
    }

    public double STS()
    {

        double P = A + B + C;
        double p = P / 2;
        S = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        return S;
    }
    public bool REAL()
    {
        if (A <= B + C && B <= A + C && C <= A + B)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
