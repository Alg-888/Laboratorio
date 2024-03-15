static double CalculoProgresivo(double x, int n)
{
    double result = 0;
    for (int i = 0; i <= n; i++)
    {
        result += Math.Pow(x, i);
    }
    return result;
}
