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
    public partial class FormularEditareClienti : Form
    {
        Client client;
        public FormularEditareClienti(Client c)
        {
            InitializeComponent();

            client = c;
        }

        private void btnReunta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            //inoarcere date actualizate in form principal
            client.NumeClient = tbNume.Text;
            client.PrenumeClient = tbPrenume.Text;
            client.DateNasterii = dataNastere.Value;

            if (rbAbonamentPremium.Checked)
                client.TipAbonament1 = tipAbonament.Abonament_premium;
            if (rdAbonamentNormal.Checked)
                client.TipAbonament1 = tipAbonament.Abonament_normal;
            if (rdAbonamentStudent.Checked)
                client.TipAbonament1 = tipAbonament.Abonament_Student;

            this.Close();

        }

        private void FormularEditareClienti_Load(object sender, EventArgs e)
        {
            tbNume.Text = client.NumeClient;
            tbPrenume.Text = client.PrenumeClient;
            dataNastere.Value = client.DateNasterii;


            tipAbonament tip = client.TipAbonament1;
            if (tip==tipAbonament.Abonament_normal)
            {
                rdAbonamentNormal.Checked = true;
            }
            else if (tip == tipAbonament.Abonament_premium)
            {
                rbAbonamentPremium.Checked = true;
            }
            else
            {
                rdAbonamentStudent.Checked = true;
            }
                
        }

      
    }
}
