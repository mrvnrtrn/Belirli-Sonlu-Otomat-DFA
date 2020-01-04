using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace otomatodevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabloekle_Click(object sender, EventArgs e)
        {

            listboxgirisler.Items.Add(combogiris.SelectedItem);
            listboxyollar.Items.Add("0");
            listboxcikis.Items.Add(combo0.SelectedItem);

            listboxgirisler.Items.Add(combogiris.SelectedItem);
            listboxyollar.Items.Add("1");
            listboxcikis.Items.Add(combo1.SelectedItem);

            combogiris.Items.Remove(combogiris.SelectedItem);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void stateekle_Click_1(object sender, EventArgs e)
        {
            String[] dizi = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "R", "S", "T", "U", "V", "Y", "Z" };
            String[] boskume = { "*", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "R", "S", "T", "U", "V", "Y", "Z" };

            int a = Convert.ToInt32(tsayi.Text);
            for (int i = 0; i < a; i++)
            {
                combogiris.Items.Add(dizi[i]);

            }
            for (int i = 0; i <= a; i++)
            {

                combo0.Items.Add(boskume[i]);
                combo1.Items.Add(boskume[i]);
            } 

        } 

        public void listboxgirisler_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = (sender as ListBox).SelectedIndex;

            listboxgirisler.SelectedIndex = index;
            listboxyollar.SelectedIndex = index;
            listboxcikis.SelectedIndex = index;     
        }
        private void listboxyollar_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = (sender as ListBox).SelectedIndex;

            listboxgirisler.SelectedIndex = index;
            listboxyollar.SelectedIndex = index;
            listboxcikis.SelectedIndex = index;
        }
        private void listboxcikis_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = (sender as ListBox).SelectedIndex;

            listboxgirisler.SelectedIndex = index;
            listboxyollar.SelectedIndex = index;
            listboxcikis.SelectedIndex = index;
        }

        public void btextekle_Click(object sender, EventArgs e)
        {
            tgiris.Text += listboxgirisler.SelectedItem.ToString();
            tyol.Text += listboxyollar.SelectedItem.ToString();
            tcikis.Text += listboxcikis.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kullanýlacak State Sayýsý girilince State Ekle Butonuna basýlýr ve Comboboxlarýn " +
                "içine sayý kadar state eklenir.Tabloya Ekle butonu Comboboxlarý Listbox tablosuna yazdýrýr.Listbox tablolarýndan " +
                "satýr seçimi yapýlýp Tablodan Ekle butonu ile Textboxlara yazdýrýlýr. ");
        }

      
    }
}

    
    

