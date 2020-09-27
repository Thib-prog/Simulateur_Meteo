using System;
using System.Collections.Generic;
using System.Text;

namespace SimulateurMeteo
{
    public class Meteo
    {
        public delegate void changementMeteoDel(MeteoEnum newMeteo);
        public event changementMeteoDel ChangementMeteo;
        public enum MeteoEnum
        {
            Soleil = 0,
            Nuage,
            Pluie,
            Orage
        }
        public MeteoEnum MeteoActuel = 0;

        public void CheckWeather(int value)
        {
            MeteoEnum newMeteo;
            if (value < 5)
                newMeteo = MeteoEnum.Soleil;
            else if (value < 50)
                newMeteo = MeteoEnum.Nuage;
            else if (value < 90)
                newMeteo = MeteoEnum.Pluie;
            else
                newMeteo = MeteoEnum.Orage;

            if (MeteoActuel != newMeteo)
            {
                ChangementMeteo(newMeteo);
            }
            MeteoActuel = newMeteo;
        }
    }


}
