using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaHistograma;

namespace PAW_PROJECT
{
    public partial class Histograma : Form
    {
        public Histograma()
        {
            InitializeComponent();
            BibliotecaHistograma .Histograma histograma = new BibliotecaHistograma.Histograma();

            histograma.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            histograma.Location = new System.Drawing.Point(13, 13);
            histograma.Name = "histograma1";
            histograma.Size = new System.Drawing.Size(775, 425);
            histograma.TabIndex = 0;

            this.Controls.Add(histograma);
        }

        private void Histograma_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
