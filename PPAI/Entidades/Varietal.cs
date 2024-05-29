namespace PPAI.Entidades
{
    public class Varietal
    {
        private string descripcion;
        private float porcentajeComposicion;

        public Varietal(string descripcion, float porcentajeComposicion)
        {
            this.descripcion = descripcion;
            this.porcentajeComposicion = porcentajeComposicion;
        }

        public string Descripcion
        {
            get => descripcion;
            set => descripcion = value;
        }

        public float PorcentajeComposicion
        {
            get => porcentajeComposicion;
            set => porcentajeComposicion = value;
        }
    }
}

// Falta agregar los métodos: conocerTipoUva(), esDeTipoUva(), mostrarPorcentaje() y crear()