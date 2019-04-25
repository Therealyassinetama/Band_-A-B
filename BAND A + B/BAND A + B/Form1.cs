using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAND_A___B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BAND kpop = new BAND();
        BAND kpop2 = new BAND();
        BAND kpop3 = new BAND();
        BAND kpop4 = new BAND();


        double totaal_uitgave1 = 0;
        double totaal_uitgave2 = 0;
        double totaal_uitgave3 = 0;
        double totaal_uitgave4 = 0;

        private void button3_Click(object sender, EventArgs e)
        {
            kpop.naam = textBox2.Text;
            kpop2.naam = textBox3.Text;
            kpop3.naam = textBox4.Text;
            kpop4.naam = textBox5.Text;
            kpop.uurtarief = Convert.ToDouble(numericUpDown2.Value);
            kpop2.uurtarief = Convert.ToDouble(numericUpDown3.Value);
            kpop3.uurtarief = Convert.ToDouble(numericUpDown4.Value);
            kpop4.uurtarief = Convert.ToDouble(numericUpDown5.Value);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double temp = (Convert.ToDouble(numericUpDown1.Value)) / 60;
            totaal_uitgave1 += kpop.optreden(temp);
            totaal_uitgave2 += kpop2.optreden(temp);
            totaal_uitgave3 += kpop3.optreden(temp);
            totaal_uitgave4 += kpop4.optreden(temp);
            double max4 = Math.Max(totaal_uitgave1, Math.Max(totaal_uitgave2, Math.Max(totaal_uitgave4, totaal_uitgave3)));
            if (totaal_uitgave1 == max4)
            {
                MessageBox.Show("De duurste zonder sontekst" + kpop.naam);
            }
            else if (totaal_uitgave2 == max4)
            {
                MessageBox.Show("De duurste zonder sontekst" + kpop2.naam);
            }
            else if (totaal_uitgave3 == max4)
            {
                MessageBox.Show("De duurste zonder sontekst" + kpop3.naam);
            }
            else if (totaal_uitgave4 == max4)
            {
                MessageBox.Show("De duurste zonder sontekst" + kpop4.naam);
            }
            totaal_uitgave1 += kpop.songwriting(textBox1.Text);
            totaal_uitgave2 += kpop2.songwriting(textBox1.Text);
            totaal_uitgave3 += kpop3.songwriting(textBox1.Text);
            totaal_uitgave4 += kpop4.songwriting(textBox1.Text);
            double max5 = Math.Max(totaal_uitgave1, Math.Max(totaal_uitgave2, Math.Max(totaal_uitgave4, totaal_uitgave3)));
            if (totaal_uitgave1 == max5)
            {
                MessageBox.Show("De duurste met sontekst" + kpop.naam);
            }
            else if (totaal_uitgave2 == max5)
            {
                MessageBox.Show("De duurste met sontekst" + kpop2.naam);
            }
            else if (totaal_uitgave3 == max5)
            {
                MessageBox.Show("De duurste met sontekst" + kpop3.naam);
            }
            else if (totaal_uitgave4 == max5)
            {
                MessageBox.Show("De duurste met sontekst" + kpop4.naam);
            }
        }
    }
}
