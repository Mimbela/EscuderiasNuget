using System;
using System.Collections.Generic;
using System.Text;

namespace EscuderiasNuget
{


    public class ListaEscuderias:List<Escuderia>
    {
        public ListaEscuderias()
        {
            Escuderia e = new Escuderia()
            {
                IdEscuderia = 1
                ,
                Nombre = "Ferrari"
                ,
                Debut = 1950
                ,
                Pais = "Italia"
                ,
                Piloto="Sebastian Vettel"
                ,
                Imagen = "https://images.app.goo.gl/eXLMYt5K1EMoxoWS9"
            };
            this.Add(e);

            e = new Escuderia
            {
                IdEscuderia = 2
                ,
                Nombre = "McLaren"
                ,
                Debut = 1966
                ,
                Pais = "Reino Unido"
                ,
                Piloto="Carlos Sainz"
                ,
                Imagen = "https://images.app.goo.gl/Hd7N2LvRyfXfjC269"
            };
            this.Add(e);

            e = new Escuderia
            {
                IdEscuderia = 3
                ,
                Nombre = "Red Bull"
                ,
                Debut = 2005
                ,
                Pais = "Austria"
                ,
                Piloto = "Max Verstappen"
                ,
                Imagen = "https://images.app.goo.gl/ZAKpBCJqDEWQkdrHA"

            };
            this.Add(e);

            e = new Escuderia
            {
                IdEscuderia = 4
                ,
                Nombre = "Mercedes"
                ,
                Debut = 2010
                ,
                Pais = "Alemania"
                ,
                Piloto = "Lewis Hamilton"
                ,
                Imagen = "https://images.app.goo.gl/43v2Ab7JqRAdUM9NA"
            };
            this.Add(e);

            e = new Escuderia
            {
                IdEscuderia = 5
                ,
                Nombre = "Toro Rosso"
                ,
                Debut = 2006
                ,
                Pais = "Italia"
                ,
                Piloto = "Daniil Kvyat"
                ,
                Imagen = "https://images.app.goo.gl/9ShANFe5v9DWDo8U6"
            };
            this.Add(e);
        }
        
    }
}


