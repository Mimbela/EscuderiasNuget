using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EscuderiasNuget
{
    public enum TiposEscuderia
    {
        Ferrari=1,
        McLaren=2,
        RedBull=3,
        Mercedes=4,
        ToroRosso = 5
    }
    public class Carrera
    {
        public Escuderia RescuperarEscuderia(TiposEscuderia tipo)
        {
            int indice = (int)tipo;
            ListaEscuderias escuderias = new ListaEscuderias();
            Escuderia esc = escuderias.Where(z => z.IdEscuderia == indice).FirstOrDefault();
            if (esc==null)
            {
                return null;
            }
            else
            {
                return esc;
            }
        }

    }
}
