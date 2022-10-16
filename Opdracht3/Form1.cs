using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht3
{
    public partial class Form1 : Form
    {
        /*Ik maak mijn drie stapels aan.
         De eerste stapel is de stapel met integers.
        De tweede stapel is de stapel met strings.
        De derde stapel is de stapel van mijn custom kleine klasse 'Auto'.
        De stapel 'Auto' bevat de merken van de auto's. (Property 'Merk').*/
        Stapel<int> stapelInteger = new Stapel<int>();
        Stapel<string> stapelString = new Stapel<string>();
        Stapel<Auto> stapelAuto = new Stapel<Auto>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnToevoegenInt_Click(object sender, EventArgs e)
        {
            /*Wanneer er op de Toevoegen-knop wordt gedrukt,
             wordt de tekst van het tekstveldje naar een integer geparsed,
            en toegevoegd aan de stapel.*/
            stapelInteger.Toevoegen(int.Parse(tbUpdateInteger.Text));
        }

        private void btnVerwijderInt_Click(object sender, EventArgs e)
        {
            /*Wanneer er op de Verwijderen knop wordt gedrukt,
             wordt het bovenste item van de stapel verwijderd.*/
            stapelInteger.Verwijderen();
        }

        private void btnLeegmakenInt_Click(object sender, EventArgs e)
        {
            /*Wanneer er op de Leegmaken-knop wordt gedrukt,
            wordt de stapel leeggemaakt.*/
            stapelInteger.Leegmaken();
        }

        private void btnToonStapelInt_Click(object sender, EventArgs e)
        {
            /*Alle items binnen de stapel worden via de ToString() methode in het tekstveldje geplaatst.*/
            tbStapelInt.Text = stapelInteger.ToString();
        }

        private void btnIsAanwezigInt_Click(object sender, EventArgs e)
        {
            /*De stapel wordt ingelezen.
             Ik parse eerst de tekst naar een int.
            Als het item in de stapel staat, wordt er 'True' gegeven in het tekstveldje,
            Anders is het resultaat: 'False'.*/
            tbStapelInt.Text = stapelInteger.IsAanwezig(int.Parse(tbUpdateInteger.Text)).ToString();
        }

        private void btnKopieerInt_Click(object sender, EventArgs e)
        {
            /*Wanneer er op de kopieerknop wordt gedrukt,
             wordt er een shallow kopij aangemaakt.*/
            stapelInteger.Shallowcopy();
        }

        private void btnToevoegenString_Click(object sender, EventArgs e)
        {
            /*Wanneer er op de Toevoegen-knop wordt gedrukt,
             wordt de tekst van het tekstveldje toegevoegd aan de stapel.*/
            stapelString.Toevoegen(tbUpdateString.Text);
        }

        private void btnVerwijderString_Click(object sender, EventArgs e)
        {
            /*Wanneer er op de Verwijderen knop wordt gedrukt, 
             wordt het bovenste item van de stapel verwijderd.*/
            stapelString.Verwijderen();
        }

        private void btnLeegmakenString_Click(object sender, EventArgs e)
        {
            /*Wanneer er op de Leegmaken-knop wordt gedrukt,
             wordt de stapel leeggemaakt.*/
            stapelString.Leegmaken();
        }

        private void btnToonStapelString_Click(object sender, EventArgs e)
        {
            /*Alle items binnen de stapel worden via de ToString() methode in het tekstveldje geplaatst.*/
            tbStapelString.Text = stapelString.ToString();
        }

        private void btnIsAanwezigString_Click(object sender, EventArgs e)
        {
            /*De stapel wordt ingelezen.
            Als het item in de stapel staat, wordt er 'True' gegeven in het tekstveldje,
            Anders is het resultaat: 'False'.*/
            tbStapelString.Text = stapelString.IsAanwezig(tbUpdateString.Text).ToString();
        }

        private void btnKopieerString_Click(object sender, EventArgs e)
        {
            /*Wanneer er op de kopieerknop wordt gedrukt,
             wordt er een shallow kopij aangemaakt.*/
            stapelString.Shallowcopy();
        }

        private void btnToevoegenAuto_Click(object sender, EventArgs e)
        {
            /*Wanneer er op de Toevoegen-knop wordt gedrukt,
             wordt de tekst van het tekstveldje toegevoegd aan de stapel.*/
            stapelAuto.Toevoegen(new Auto(tbUpdateAuto.Text));
        }

        private void btnVerwijderAuto_Click(object sender, EventArgs e)
        {
            /*Wanneer er op de Verwijderen knop wordt gedrukt, 
             wordt het bovenste item van de stapel verwijderd.*/
            stapelAuto.Verwijderen();
        }

        private void btnLeegmakenAuto_Click(object sender, EventArgs e)
        {
            /*Wanneer er op de Leegmaken-knop wordt gedrukt, 
             wordt de stapel leeggemaakt.*/
            stapelAuto.Leegmaken();
        }

        private void btnToonStapelAuto_Click(object sender, EventArgs e)
        {
            /*Alle items binnen de stapel worden via de ToString() methode in het tekstveldje geplaatst.*/
            tbStapelAuto.Text = stapelAuto.ToString();
        }

        private void btnIsAanwezigAuto_Click(object sender, EventArgs e)
        {
            /*De stapel wordt ingelezen.
             Als het item in de stapel staat, wordt er 'True' gegeven in het tekstveldje,
            Anders is het resultaat: 'False'.*/
            Auto auto = new Auto(tbUpdateAuto.Text);
            tbStapelAuto.Text = stapelAuto.IsAanwezig(auto).ToString();
        }

        private void btnKopieerAuto_Click(object sender, EventArgs e)
        {
            /*Wanneer er op de kopieerknop wordt gedrukt,
             wordt er een shallow kopij aangemaakt.*/
            stapelAuto.Shallowcopy();
        }
    }
}
