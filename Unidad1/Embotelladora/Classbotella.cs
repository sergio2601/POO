using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Embotelladora
{
    class Classbotella
    {
        //Atributos de la clase
        public int nivelLlenado;
        int mililitrosVerificados;

        //Metodos de la clase

       public String VerificarLlenado()
        {
            string Mensaje;

            if (nivelLlenado == 250)
            {
                 Mensaje = "Llenado perfeto";
            }
                
            else if (nivelLlenado < 250)
            {
                mililitrosVerificados = 250 - nivelLlenado;
                Mensaje = "Le falta " + mililitrosVerificados + " mililitros";
            }
            else
            {
                    mililitrosVerificados = nivelLlenado - 250;
                    Mensaje = " le sobran " + mililitrosVerificados + " mililitros  ";
            }
                

                return Mensaje;
        }
        


          
    }
}
