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
    public partial class FormClipBoard : Form
    {
        private Label label;
        private bool imageOnSrc = true;
        public FormClipBoard()
        {
            InitializeComponent();
            label = new Label();

            label.Location = new Point(10, 10);
            label.Text = "0";

            this.Controls.Add(label);

            //FormAntrenorDB.sizeChanged += UpdateLabel;

            src.ImageLocation = "C:\\Users\\cosmi\\Desktop\\1051_FloareaCosminaGeorgiana_Proiect\\client.jpg";
        }
        public void UpdateLabel(int numar)
        {
            label.Text = numar.ToString();
        }
        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbSrc.Text);
            tbSrc.Clear();
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            tbDst.Text = Clipboard.GetText();
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            if (imageOnSrc)
            {
                Clipboard.SetImage(src.Image);

                dst.Image = Clipboard.GetImage();
                src.Image = null;

                imageOnSrc = false;
            }
            else
            {
                Clipboard.SetImage(dst.Image);

                src.Image = Clipboard.GetImage();
                dst.Image = null;

                imageOnSrc = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
