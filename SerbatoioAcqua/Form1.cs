using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerbatoioAcqua
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Serbatoio S1 = new Serbatoio(1, "UniAcque", "Sv1000", 100, 100, 1000);
        Serbatoio S2 = new Serbatoio(2, "UniAcque", "Sv1000", 100, 100, 1000);

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                S1.Aggiungere(700);
                S1.Svuotare(S2);
            }
            catch (Exception Eccezione)
            {
                MessageBox.Show(Eccezione.Message);
            }

            progressBar1.Value = S1.LvAcqua / 10;
            progressBar2.Value = S2.LvAcqua / 10;
            Serbatoio1.Text = Convert.ToString(S1.LvAcqua / 10);
            Serbatoio2.Text = Convert.ToString(S2.LvAcqua / 10);


            if (S1.Lamp.Stato)
            {
                Lamp1.BackColor = Color.Red;
            }

            if (S1.Siren.Stato)
            {
                Siren1.BackColor = Color.Red;
            }

            if (S2.Lamp.Stato)
            {
                Lamp2.BackColor = Color.Red;
            }

            if (S2.Siren.Stato)
            {
                Siren2.BackColor = Color.Red;
            }
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
