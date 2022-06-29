namespace EjercicioCuadrilateros.Modelos
{
    public abstract class Cuadrilatero
    {
        public Cuadrilatero(int x1, int y1)
        {
            this.x1 = x1;
            this.y1 = y1;
        }

        public abstract double CalcularArea();
        public double Distancia(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        protected int x1;
        protected int y1;
    }
}
