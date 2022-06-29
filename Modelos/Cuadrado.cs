namespace EjercicioCuadrilateros.Modelos
{
    public class Cuadrado : Cuadrilatero
    {
        public Cuadrado(int x1, int y1) : base(x1, y1)
        {
        }

        public override double CalcularArea()
        {
            return x1 * x1;
        }
    }

}
