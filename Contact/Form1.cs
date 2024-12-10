using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact List 1.0");
        }

        private void peopleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.peopleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contactDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'contactDBDataSet1.People'. Você pode movê-la ou removê-la conforme necessário.
            this.peopleTableAdapter1.Fill(this.contactDBDataSet1.People);
            // TODO: esta linha de código carrega dados na tabela 'contactDBDataSet1.Protheus'. Você pode movê-la ou removê-la conforme necessário.
            this.protheusTableAdapter.Fill(this.contactDBDataSet1.Protheus);
            // TODO: esta linha de código carrega dados na tabela 'contactDBDataSet.People'. Você pode movê-la ou removê-la conforme necessário.
            this.peopleTableAdapter.Fill(this.contactDBDataSet.People);

        }
    }
}
