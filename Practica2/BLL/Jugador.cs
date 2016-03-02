using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BLL
{
    public class Jugador
    {
        string nombre;
        int jugados;
        int perdidos;
        int ganados;

        /*Constructor de objeto Jugador. Necesita los juegos perdidos y ganados
        para poder actualizarle
        */
        public Jugador(int index)
        {
         
        }


        private void setJugados(int a)
        {
            this.jugados = a;
        }
        private void setGanados(int a)
        {
            this.ganados = a;
        }
        private void setPerdidos(int a)
        {
            this.perdidos = a;
        }
        private int getJugados()
        {
            return jugados;
        }
        private int getGanados()
        {
            return ganados;
        }
        private int getPerdidos()
        {
            return perdidos;
        }
        private string getNombre()
        {
            return nombre;
        }
    }
}