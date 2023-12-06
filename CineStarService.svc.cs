using System;
using System.Collections.Generic;
using System.Data;
using WCFCineStar.bean;

namespace WCFCineStar
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class CineStarService : ICineStar
    {
        dao.CineStarDAO dao = new dao.CineStarDAO();

        public DataSet getCineTarifas(int id)
        {
            return dao.getCineTarifas(id);
        }

        public DataSet getCines()
        {
            return dao.getCines();
        }

        public DataSet getPelicula(int id)
        {
            return dao.getPelicula(id);
        }

        public Pelicula getPeliculaEntidad(int id)
        {
            return dao.getPeliculaEntidad(id); 
        }

        public DataSet getPeliculas(int id)
        {
            return dao.getPeliculas(id);
        }

        public List<Pelicula> getPeliculasList(int id)
        {
            return dao.getPeliculaList(id);
        }
    }
}
