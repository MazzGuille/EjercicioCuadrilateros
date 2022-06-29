namespace EjercicioCuadrilateros.Modelos
{
    public class Rectangulo : Cuadrilatero
    {
        private int x2;
        private int y2;
        public Rectangulo(int x1, int y1, int x2, int y2) : base(x1, y1)
        {
            this.x2 = x2;
            this.y2 = y2;
        }

        public override double CalcularArea()
        {
            return x1 * y1;
        }
    }

}
