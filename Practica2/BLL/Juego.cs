using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class Juego
    {
        private string cat;
        private string palabra;
        private Jugador player;
        private int intentos = 6;

        Juego (string cat,string palabra, Jugador player)
        {
           
            cat = this.cat;
            palabra = this.palabra;
            player = this.player;
        }

        private int evaluar(char a)
        {
            int index=-1;
            if (palabra.Contains(a)){
                index = 0;
            }
            else
            {
                intentos--;
                index = -1;
            }
            return index;
        }

       private bool perder()
        {
            if (intentos == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
