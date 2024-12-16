using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjCaca
{
    public partial class Form1 : Form
    {
        private int correto;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLetra_Click(object sender, EventArgs e)
        {
            Button botaoClique = sender as Button;
            lblPalvra.Text += botaoClique.Text;
        }

        private void LblPalvra_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pcB2.Image = Properties.Resources.logo;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            chB1.Checked = false;
            chB2.Checked = false;
            chB3.Checked = false;
            chB4.Checked = false;
            chB5.Checked = false;
            lblPalvra.Text = "";

        }

        private void BtnVeri_Click(object sender, EventArgs e)
        {
            string palavracerta = lblPalvra.Text.ToUpper();

            switch (palavracerta)
            {
                case "LIAM":
                    chB1.Checked = true;
                    correto++;
                    pc1.Image = Properties.Resources.liam;
                    lblPalvra.Text = "";
                    break;

                case "LOUIS":
                    chB2.Checked = true;
                    correto++;
                    pc1.Image = Properties.Resources.louis;
                    lblPalvra.Text = "";
                    break;

                case "HARRY":
                    chB3.Checked = true;
                    correto++;
                    pc1.Image = Properties.Resources.harry;
                    lblPalvra.Text = "";
                    break;

                case "NIALL":
                    chB4.Checked = true;
                    correto++;
                    pc1.Image = Properties.Resources.niall;
                    lblPalvra.Text = "";
                    break;

                case "ZAYN":
                    chB5.Checked = true;
                    correto++;
                    pc1.Image = Properties.Resources.zany;
                    lblPalvra.Text = "";
                    break;



                default:

                    MessageBox.Show("A palavra não é igual");

                    break;

            }

            if (chB1.Checked && chB2.Checked && chB3.Checked && chB4.Checked && chB5.Checked == true)
            {
                MessageBox.Show("Parabéns você conseguiu");
            }
        }
    }
}
