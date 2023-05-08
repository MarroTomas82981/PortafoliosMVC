using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyextos();
    }
    public class RepositorioProyectos : IRepositorioProyectos
    {
        public List<Proyecto> ObtenerProyextos()
        {
            return new List<Proyecto>()
            {
                new Proyecto
                {
                    Titulo = "Web Pymes",
                    Descripcion = "Web para Pymes en Angular",
                    Link = "https://stackblitz.com/edit/pymes2021-wazuaz?file=src%2Fapp%2Fapp.component.ts",
                    ImagenURL = "/imagenes/pyme.png"

                }, new Proyecto
                {
                    Titulo = "Steam",
                    Descripcion = "Tienda en linea para compra de videojuegos",
                    Link = "https://store.steampowered.com/",
                    ImagenURL = "/imagenes/steam.png"

                }, new Proyecto
                {
                    Titulo = "Reddit",
                    Descripcion = "Red social para compartir publicaciones en comunidad",
                    Link = "https://www.reddit.com/",
                    ImagenURL = "/imagenes/reddit.png"

                },
            };

        }
    }
}
