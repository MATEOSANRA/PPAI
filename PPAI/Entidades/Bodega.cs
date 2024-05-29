namespace PPAI.Entidades
{
    public class Bodega
    {
        private string nombre;
        private string descripcion;
        private string historia;
        private int periodoActualizacion;
        private float coordenadasUbicacion;

        public Bodega(string nombre, string descripcion, string historia, int periodoActualizacion, float coordenadasUbicacion)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.historia = historia;
            this.periodoActualizacion = periodoActualizacion;
            this.coordenadasUbicacion = coordenadasUbicacion;
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

        public string Historia
        {
            get => historia;
            set => historia = value;
        }

        public int PeriodoActualizacion
        {
            get => periodoActualizacion;
            set => periodoActualizacion = value;
        }

        public float CoordenadasUbicacion
        {
            get => coordenadasUbicacion;
            set => coordenadasUbicacion = value;
        }
    }
}

// Falta agregar los metodos contarReseñas(), mostrarTodosVinos(), existeActualizacionDisponible(), mostrarNombre(), actualizarVinos()