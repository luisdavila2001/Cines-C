using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFCineStar.bean
{
    public class CineTarifa
    {
        public int id { get; set; }
        public string DiasSemana { get; set; }
        public int Precio { get; set; }
        

        public CineTarifa() { }

        public CineTarifa(System.Data.DataRow dr)
        {
            if (dr == null) return;

            id = int.Parse(dr["id"].ToString());
            DiasSemana = dr["DiasSeamana"].ToString();
            Precio = int.Parse(dr["Precio"].ToString());
          


        }

    }

}