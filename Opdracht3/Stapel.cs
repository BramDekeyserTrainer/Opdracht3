using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3
{
    /*De onderstaande code, is de code van de eerste oefening van Opdracht 3.
     De generische klasse, functies, etc... worden hier aangemaakt.*/

    /*Eerst maak ik de generische klasse 'Stapel' aan.
     Deze bevat T als property.*/
    public class Stapel<T>
    {
        /*Ik maak een private list aan.
         Deze noem ik 'container'.*/
        private List<T> container;

        /*Ik maak de constructor van de klasse Stapel aan.
         Deze bevat de List 'container'.*/
        public Stapel(List<T> container)
        {
            this.container = container;
        }

        public Stapel()
        {
        }

        /*Een publieke method wordt aangemaakt.
         Deze method dient ervoor om generische objecten (items) toe te voegen aan de stapel.*/
        public void Toevoegen(T item)
        {
            /*met Add voeg ik een item (generisch object) toe aan de List 'container'*/
            container.Add(item);
        }

        /*Een publieke method wordt aangemaakt.
         Deze method dient ervoor om generische objecten (items) te verwijderen uit de stapel.*/
        public void Verwijderen(T item)
        {
            /*met Remove verwijder ik een item (generisch object) uit de List 'container'*/
            container.Remove(item);
        }

        /*Een publieke method wordt aangemaakt.
         Deze method dient ervoor om de gehele stapel leeg te maken.*/
        public void Leegmaken(T item)
        {
            /*Met Clear verwijder ik alle items (generische objecten) uit de List 'container'.
             In dit geval moet er geen 'T item' staan tussen de haakjes,
            omdat het compleet wordt leeggehaald.*/
            container.Clear();
        }

        /*Ik maak een override string method 'ToString'.
         Deze weergeeft alle informatie uit 'container' in een string.*/
        public override string ToString()
        {
            /*De informatie wordt in een variabele 'inhoud' gegoten.
             Alle container items worden in de string gegoten, en krijgen
            '/' als separator.*/
            var inhoud = string.Join(" / ", container);

            /*Ik return de inhoud.*/
            return inhoud;
        }

        /*Ik maak een booleaanse methode 'IsAanwezig' aan.
         (Boolean is 'true' of 'false'.)
        Deze gaat na of een gegeven generisch object in de stapel voorkomt.
        Als deze voorkomt, returnt hij 'true',
        Zoniet, returnt hij 'false'.*/
        public bool IsAanwezig(T item)
        {
            if (container.Contains(item))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*Ik maak een publieke methode aan.
         Deze maakt een shallow kopij aan van een stapel naar een andere.
        Een shallow kopij, wordt er een kopij van het oorspronkelijke object opgeslagen,
        en enkel een referentie-adres uiteindelijk gekopieerd.
        Bij een deep kopij daarentegen, wordt zowel het oorspronkelijke object als
        de repititieve kopijen opgeslagen.*/
        public object Shallowcopy()
        {
            return this.MemberwiseClone();
        }
    }
}
