namespace EjercicioCuadrilateros.Modelos
{
    public class Trapecio : Cuadrilatero
    {
        private int x2;
        private int y2;
        private int x3;
        private int y3;
        private int x4;
        private int y4;
        public Trapecio(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4) : base(x1, y1)
        {
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
            this.x4 = x4;
            this.y4 = y4;
        }

        public override double CalcularArea()
        {
            return (Distancia(x1, y1, x2, y2) + Distancia(x3, y3, x4, y4)) * (Distancia(x2, y2, x3, y3) + Distancia(x4, y4, x1, y1)) / 2;
        }

    }

}
