using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

namespace PAW_PROJECT
{
    public partial class FormDragAndDrop : Form
    {
        private List<Aparat> listaAparate = null;

        public FormDragAndDrop()
        {
            InitializeComponent();
            listBoxAparateDetaliate.AllowDrop = true;
            //listView1.AllowDrop = true;
            listaAparate = new List<Aparat>();
            Aparat a1 = new Aparat("Stepper", 130.2, 150.9, 8);
            Aparat a2 = new Aparat("Banca", 130.2, 150.9, 3);
            Aparat a3 = new Aparat("Banda alergare", 130.2, 150.9, 4);
            Aparat a4 = new Aparat("Scari electrice", 130.2, 150.9, 6);
            Aparat a5 = new Aparat("Greutati", 130.2, 150.9, 114);
            listaAparate.Add(a5);
            listaAparate.Add(a1);
            listaAparate.Add(a2);
            listaAparate.Add(a3);
            listaAparate.Add(a4);
        }

        //private void golireFormular()
        //{
        //    tbNumeAparat.Clear();
        //    tbStoc.Clear();
        //}

        private void btnCurata_Click(object sender, EventArgs e)
        {
            //  golireFormular();
        }

        private void golireLista()
        {
            listView1.Items.Clear();
        }

        private void populeazaLista()
        {
            golireLista();
            foreach (Aparat a in listaAparate)
            {
                ListViewItem item = new ListViewItem(a.DenumireAparat);
                item.SubItems.Add(a.NrInStoc.ToString());
                item.SubItems.Add(a.LatimeAparat.ToString());
                item.SubItems.Add(a.InaltimeAparat.ToString());
                listView1.Items.Add(item);
            }
        }

        private void btnArata_Click(object sender, EventArgs e)
        {
            populeazaLista();
        }

        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems != null)
                listView1.DoDragDrop(listView1.SelectedItems, DragDropEffects.Copy);
        }

        private void listBoxAparateDetaliate_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void listBoxAparateDetaliate_DragDrop(object sender, DragEventArgs e)
        {
            ListViewItem item = ((SelectedListViewItemCollection)e.Data.GetData(typeof(SelectedListViewItemCollection)))[0];
            Aparat aparat = new Aparat();
            aparat.DenumireAparat = item.SubItems[0].Text;
            aparat.NrInStoc = Int32.Parse(item.SubItems[1].Text);
            aparat.LatimeAparat = double.Parse(item.SubItems[2].Text);
            aparat.InaltimeAparat = double.Parse(item.SubItems[3].Text);
            listBoxAparateDetaliate.Items.Add(aparat.ToString());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}