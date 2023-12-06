using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFCineStar.bean
{
    public class Pelicula
    {
        public int id { get; set; }
        public string Titulo { get; set; }
        public string FechaEstreno { get; set; }
        public string Director { get; set; }
        public string Generos { get; set; }
        public int idClasificacion { get; set; }
        public int idEstado { get; set; }
        public string Duracion { get; set; }
        public string Link { get; set; }
        public string Reparto { get; set; }
        public string Sinopsis { get; set; }

        public Pelicula() { }

        public Pelicula(System.Data.DataRow dr)
        {
            if (dr == null) return;

            id = int.Parse(dr["id"].ToString());
            Titulo = dr["Titulo"].ToString();
            Link = dr["Link"].ToString();
            Sinopsis = dr["Sinopsis"].ToString();


            if (dr.Table.Columns.Count > 4)
            {
                FechaEstreno = dr["FechaEstreno"].ToString();
                Director = dr["Director"].ToString();
                Generos = dr["Generos"].ToString();
                idClasificacion = int.Parse(dr["idClasificacion"].ToString());
                idEstado = int.Parse(dr["idEstado"].ToString());
                Duracion = dr["Duracion"].ToString();
                Reparto = dr["Reparto"].ToString();
            }
        }
    }
}