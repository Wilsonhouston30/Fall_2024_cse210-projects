using System.Diagnostics;

public class Fraction
{
    private int _bottom;
    private int _top;

    public Fraction()
    {
        _bottom = 1;
        _top = 1;
    }

    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }
    public Fraction (int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }
    public int GetBottom()
    {
        return _bottom;
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string fractionstring = $"{_top} / {_bottom}";
        return fractionstring;
    }

    public double GetDecimalValue()
    {
        return (double)_top  / (double)_bottom;
    }
}

