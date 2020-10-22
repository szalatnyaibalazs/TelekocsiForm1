using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TelekocsiForm1
{
    public partial class frmFo : Form
    {
        private List<Auto> autok = new List<Auto>();
        private List<Igeny> igenyek = new List<Igeny>();
        public frmFo()
        {
            InitializeComponent();
            lbKimenet.Items.Clear();
        }

        private void btnBeolvasas_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader ol = new StreamReader("autok.csv");
                ol.ReadLine();
                while (!ol.EndOfStream)
                {
                    string[] adat = ol.ReadLine().Split(';');
                    autok.Add(new Auto(adat[0], adat[1], adat[2], adat[3], int.Parse(adat[4])));
                }
                ol.Close();


                StreamReader lo = new StreamReader("igenyek.csv");
                lo.ReadLine();
                while (!lo.EndOfStream)
                {
                    string[] adat = lo.ReadLine().Split(';');
                    igenyek.Add(new Igeny(adat[0], adat[1], adat[2], int.Parse(adat[3])));
                }
                lo.Close();

                btnSecond.Enabled = true;
                btnBeolvasas.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSecond_Click(object sender, EventArgs e)
        {
            lbKimenet.Items.Add($"2.feladat\n  {autok.Count} autos hirdet fuvart");
            btnSecond.Enabled = false;
            btnThird.Enabled = true;
        }

        private void btnThird_Click(object sender, EventArgs e)
        {
            lbKimenet.Items.Clear();
            lbKimenet.Items.Add("Nem volt meg");

            btnThird.Enabled = false;
            btnFourth.Enabled = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFourth_Click(object sender, EventArgs e)
        {
            int max = 0;
            string utv = "";
            var utvonalak = from a in autok
                            orderby a.utvonal
                            group a by a.utvonal into temp
                            select temp;

            foreach (var u in utvonalak)
            {
                int fh = u.Sum(x => x.Ferohely);
                if (max < fh)
                {
                    max = fh;
                    utv = u.Key;
                }
                //Console.WriteLine($"{u.Key} -> {u.Count()}");
            }
            lbKimenet.Items.Clear();
            lbKimenet.Items.Add("4.feladat");
            lbKimenet.Items.Add("A legtöbb férőhelyet");
            lbKimenet.Items.Add($"({max})");
            lbKimenet.Items.Add("a");
            lbKimenet.Items.Add($"{utv} útvonalon");
            lbKimenet.Items.Add($"Ajánlották fel a hírdetők");


            btnFourth.Enabled = false;
            btnFifth.Enabled = true;
        }

        private void btnFifth_Click(object sender, EventArgs e)
        {
            lbKimenet.Items.Clear();
            lbKimenet.Items.Add("5.feladat");
            foreach (var i in igenyek)
            {
                int x = i.VanAuto(autok);
                if (x > -1)
                {
                    lbKimenet.Items.Add($"{i.Azonosito} => {autok[x].Rendszam}");
                }
            }
            btnFifth.Enabled = false;
            btnSixth.Enabled = true;
        }

        private void btnSixth_Click(object sender, EventArgs e)
        {
            lbKimenet.Items.Clear();
            lbKimenet.Items.Add("6.feladat");
            try
            {
                StreamWriter file = new StreamWriter("utasuzenetek.txt");
                foreach (var i in igenyek)
                {
                    int x = i.VanAuto(autok);
                    if (x > -1)
                    {
                        file.WriteLine($"{i.Azonosito}: Rendszám: {autok[x].Rendszam}, Telefonszám: {autok[x].Telefonszam}");
                    }
                    else
                    {
                        file.WriteLine($"{i.Azonosito}: Sajnos nem sikerült autót találni");
                    }
                }

                file.Close();
                lbKimenet.Items.Add("Adatok fájlba írása megtörtént");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
