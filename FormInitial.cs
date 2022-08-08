using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAW_PROJECT
{
    public partial class FormInitial : Form
    {
        public FormInitial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAdaugaClienti f = new FormAdaugaClienti();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAntrenorDB f = new FormAntrenorDB();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Histograma f = new Histograma();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Histograma f = new Histograma();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormDragAndDrop f = new FormDragAndDrop();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormClipBoard f = new FormClipBoard();
            this.Hide();
            f.ShowDialog();
            this.Show();

        }

       
    }
}
