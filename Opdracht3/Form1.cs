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
        Stapel<int> stapelInteger = new Stapel<int>();
        Stapel<string> stapelString = new Stapel<string>();
        Stapel<Auto> stapelAuto = new Stapel<Auto>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnToevoegenInt_Click(object sender, EventArgs e)
        {
            stapelInteger.Toevoegen(int.Parse(tbUpdateInteger.Text));
        }

        private void btnVerwijderInt_Click(object sender, EventArgs e)
        {
            stapelInteger.Verwijderen();
        }

        private void btnLeegmakenInt_Click(object sender, EventArgs e)
        {
            stapelInteger.Leegmaken();
        }

        private void btnToonStapelInt_Click(object sender, EventArgs e)
        {
            tbStapelInt.Text = stapelInteger.ToString();
        }

        private void btnIsAanwezigInt_Click(object sender, EventArgs e)
        {
            tbStapelInt.Text = stapelInteger.IsAanwezig(int.Parse(tbUpdateInteger.Text)).ToString();
        }

        private void btnKopieerInt_Click(object sender, EventArgs e)
        {
            Stapel<int> = nieuweStapelInteger = new Stapel<int>();
            nieuweStapelInteger = stapelInteger.Shallowcopy();
        }

        private void btnToevoegenString_Click(object sender, EventArgs e)
        {
            stapelString.Toevoegen(tbUpdateAuto.Text);
        }

        private void btnVerwijderString_Click(object sender, EventArgs e)
        {
            stapelString.Verwijderen();
        }

        private void btnLeegmakenString_Click(object sender, EventArgs e)
        {
            stapelString.Leegmaken();
        }

        private void btnToonStapelString_Click(object sender, EventArgs e)
        {
            tbStapelString.Text = stapelString.ToString();
        }

        private void btnIsAanwezigString_Click(object sender, EventArgs e)
        {
            tbStapelString.Text = stapelString.IsAanwezig(tbUpdateString.Text).ToString();
        }

        private void btnKopieerString_Click(object sender, EventArgs e)
        {
            Stapel<string> nieuweStapelString = new Stapel<string>();
            nieuweStapelString = stapelString.Shallowcopy();
        }

        private void btnToevoegenAuto_Click(object sender, EventArgs e)
        {
            stapelAuto.Toevoegen(new Auto(tbUpdateAuto.Text));
        }

        private void btnVerwijderAuto_Click(object sender, EventArgs e)
        {
            stapelAuto.Verwijderen();
        }

        private void btnLeegmakenAuto_Click(object sender, EventArgs e)
        {
            stapelAuto.Leegmaken();
        }

        private void btnToonStapelAuto_Click(object sender, EventArgs e)
        {
            tbStapelAuto.Text = stapelAuto.ToString();
        }

        private void btnIsAanwezigAuto_Click(object sender, EventArgs e)
        {
            Auto auto = new Auto(tbUpdateAuto.Text);
            tbStapelAuto.Text = stapelAuto.IsAanwezig(auto).ToString();
        }

        private void btnKopieerAuto_Click(object sender, EventArgs e)
        {
            Stapel<Auto> nieuweStapelAuto = new Stapel<Auto>();
            nieuweStapelAuto = stapelAuto.Shallowcopy();
        }
    }
}
