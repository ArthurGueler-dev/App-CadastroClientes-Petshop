using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{

    public partial class Consulta : Form
    {

        public Consulta(string id, string nome, string tipoAnimal, string raca, string dataNascimento, string peso, string telefone)
        {
            InitializeComponent();

            // Exibe os dados nos controles, como labels ou textboxes
            lblId.Text = id;
            lblNome.Text = nome;
            lblanimal.Text = tipoAnimal;
            lblRaca.Text = raca;
            lblDataNascimento.Text = dataNascimento;
            lblPeso.Text = peso;
            lblTelefone.Text = telefone;
        }



        public Consulta()
        {
            InitializeComponent();
        }

        private void Consulta_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblDataNascimento_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
