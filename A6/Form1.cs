using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnveri_Click(object sender, EventArgs e)
        {
            string nome;
            string sobrenome;
            int ano;
            int year= DateTime.Now.Year;


            nome = txtnome.Text;
            sobrenome= txtsobrenome.Text;
            ano = int.Parse(txtano.Text);

            int year1 = year - ano;

            if (year1 >= 18)
            {
               
                lblresult1.Text = "Ta liberado";
                lblresult1.ForeColor = Color.Green;
                picimagem.Image = Properties.Resources.image1;
            }
            else
            {
               
                lblresult1.Text = "Dá o fora";
                lblresult1.ForeColor = Color.Red;
                picimagem.Image = Properties.Resources.Nana_imagoi;
            }

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnome.Text = " ";
            txtsobrenome.Text = " ";
            txtano.Text = " ";
            lblresult1.Text = " ";
            picimagem.Image = Properties.Resources.saudem_todos_o_rei_julien_maurice_mork_960x720;

        }

        //private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
