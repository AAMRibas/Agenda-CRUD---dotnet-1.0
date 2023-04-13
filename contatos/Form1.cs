using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contatos
{
    public partial class AgendaContactos : Form
    {
        public AgendaContactos()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lista de contactos 1.0 \n\n\nDesenvolvido por mim\n \nArmando Ribas", "Sobre o Programa");
        }

        private void pessoasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pessoasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contatosDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'contatosDBDataSet.Pessoas'. Você pode movê-la ou removê-la conforme necessário.
            this.pessoasTableAdapter.Fill(this.contatosDBDataSet.Pessoas);

        }
    }
}
