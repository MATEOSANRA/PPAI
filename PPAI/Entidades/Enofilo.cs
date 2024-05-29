namespace PPAI.Entidades
{
    public class Enofilo
    {
        private string nom;
        private string ape;
        private bool imag;

        public Enofilo(string nombre, string apellido, bool imagen)
        {
            nom = nombre;
            ape = apellido;
            imag = imagen;
        }
        public string Nombre
        {
            get => nom;
            set => nom = value;
        }
        public string Apellido
        {
            get => ape;
            set => ape = value;
        }
        public bool Imagen
        {
            get => imag;
            set => imag = value;
        }
    }
}

// Falta agregar métodos esSeguidorDeBodega() y obtenerNombreUsuario()