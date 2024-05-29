namespace PPAI.Entidades
{
    public class Siguiendo
    {
        private string fechaInicio;
        private string fechaFin;

        public Siguiendo(string fechaInicio, string fechaFin)
        {
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
        }
        public string FechaInicio
        {
            get => fechaInicio;
            set => fechaInicio = value;
        }
        public string FechaFin
        {
            get => fechaFin;
            set => fechaFin = value;
        }
    }
}

// Faltaría agregar método sosDeBodega()