namespace Portafolio.Servicios
{
    public class ServicioUnico
    {
        public ServicioUnico()
        {
            ObtenerGuid = Guid.NewGuid();
        }
        public Guid ObtenerGuid { get; private set; }
    }

    public class ServicioDelimitado
    {
        public ServicioDelimitado()
        {
            ObtenerGuid = Guid.NewGuid();
        }
        public Guid ObtenerGuid { get; private set; }
    }
    public class ServicioTrannsitorio
    {
        public ServicioTrannsitorio()
        {
            ObtenerGuid = Guid.NewGuid();
        }
        public Guid ObtenerGuid { get; private set; }
    }
}
