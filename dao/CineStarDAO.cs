using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using WCFCineStar.bean;

namespace WCFCineStar.dao
{
    public class CineStarDAO
    {

        db.Db db = new db.Db("cnCineStar");

        public DataSet getPeliculas(int id)
        {
            db.Sentencia("sp_getPeliculas " + id);
            return db.getDataSet();
        }

        [WebMethod]
        public DataSet getPelicula(int id)
        {
            db.Sentencia("sp_getPelicula " + id);
            return db.getDataSet();
        }

        [WebMethod]
        public DataSet getCines()
        {
            db.Sentencia("sp_getCines");
            return db.getDataSet();
        }

        [WebMethod]
        public DataSet getCine(int id)
        {
            db.Sentencia("sp_getCine " + id);
            return db.getDataSet();
        }

        [WebMethod]
        public DataSet getCineTarifas(int id)
        {
            db.Sentencia("sp_getCineTarifas " + id);
            return db.getDataSet();
        }

        internal List<Pelicula> getPeliculaList(int id)
        {
            db.Sentencia("sp_getPelicula " + id);
            DataTable dt = db.getDataSet().Tables[0];

            if (dt.Rows.Count == 0) return null;

            List<Pelicula> lst = new List<Pelicula>();
            foreach (DataRow dr in dt.Rows)
                lst.Add(new Pelicula(dr));

            return lst;
        }

        internal Pelicula getPeliculaEntidad(int id)
        {
            db.Sentencia("sp_getPëlicula " + id);
            DataTable dt = db.getDataSet().Tables[0];

            if (dt.Rows.Count == 0) return null;
            return new Pelicula(dt.Rows[0]);
        }
    }
}