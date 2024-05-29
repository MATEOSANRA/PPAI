namespace PPAI.Entidades
{
    public class Vino
    {
        private string nom;
        private bool imag;
        private float prec;
        private int aniada;
        private string nota;
        private DateTime fecha;

        public Vino(string nombre, bool imagenEtiqueta, float precioARS, int aniada, string notaDeCataBodega, DateTime fechaActualizacion)
        {
            nom = nombre;
            imag = imagenEtiqueta;
            prec = precioARS;
            this.aniada = aniada;
            nota = notaDeCataBodega;
            fecha = fechaActualizacion;
        }

        public string Nombre
        {
            get => nom;
            set => nom = value;
        }

        public bool ImagenEtiqueta
        {
            get => imag;
            set => imag = value;
        }

        public float PrecioArs
        {
            get => prec;
            set => prec = value;
        }

        public int Aniada
        {
            get => aniada;
            set => aniada = value;
        }

        public string NotaDeCataBodega
        {
            get => nota;
            set => nota = value;
        }

        public DateTime Fecha
        {
            get => fecha;
            set => fecha = value;
        }
    }
}

// Faltaría agregar cada uno de los 12 métodos...