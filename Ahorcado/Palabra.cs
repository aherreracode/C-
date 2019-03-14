using System;
using System.Collections.Generic;
using System.Text;

namespace Ahorcado
{
    public class Palabra
    {
        public static char[] visible;

        public static string AsignarPalabra()
        {
            Random random = new Random();
            int Number = random.Next(1, 5);
            string seleccionada = "";

            switch (Number)
            {
                case 1:

                    seleccionada = "skyline";
      
                    break;

                case 2:

                    seleccionada = "silvia";

                    break;

                case 3:

                    seleccionada = "civic";

                    break;

                case 4:

                    seleccionada = "supra";

                    break;

                default:

                    break;
            }

            visible = seleccionada.ToCharArray();

            return seleccionada;

        }
                    
    }
}


