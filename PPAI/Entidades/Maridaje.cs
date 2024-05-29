namespace PPAI.Entidades
{
    public class Maridaje
    {
        private string nombre;
        private string descripcion;

        public Maridaje(string nombre, string descripcion)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public string Descripcion
        {
            get => descripcion;
            set => descripcion = value;
        }
    }
}

// Falta agregar el método maridaConVino()