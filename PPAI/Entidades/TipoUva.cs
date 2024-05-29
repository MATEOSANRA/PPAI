namespace PPAI.Entidades
{
    public class TipoUva
    {
        private string descripcion;
        private string nombre;

        public TipoUva(string descripcion, string nombre)
        {
            this.descripcion = descripcion;
            this.nombre = nombre;
        }

        public string Descripcion
        {
            get => descripcion;
            set => descripcion = value;
        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }
    }
}

// Falta agregar el método: esTipoUva()