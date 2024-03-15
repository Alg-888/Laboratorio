static double CalculoProgresivo(double x, int n)
{
    double respuesta = 0;
    for (int i = 0; i <= n; i++)
    {
        respuesta += Math.Pow(x, i);
    }
    return respuesta;
}
