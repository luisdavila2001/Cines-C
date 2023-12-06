using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFCineStar.bean
{
    public class Cines
    {
        public int id {  get; set; }
        public string RazonSocial { get; set; }
        public int Salas { get; set; }
        public int idDistrito { get; set; }
        public string idDireccion { get; set ; }
        public int Telefono { get; set; }
        public string Detalle { get; set; }

        public Cines() { }

        public Cines (System.Data.DataRow dr)
        {
            if (dr == null) return;

            id = int.Parse(dr["id"].ToString());
            RazonSocial = dr["RazonSocial"].ToString();
            Salas = int.Parse(dr["Salas"].ToString());
            idDistrito = int.Parse(dr["idDistrito"].ToString());
            idDireccion = dr["idDireccion"].ToString();
            Telefono = int.Parse(dr["Direccion"].ToString());
            Detalle = dr["Detalle"].ToString();

            
        }
    }
}