using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul3_103022400028
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Pilih satuan terlebih dahulu!");
                return;
            } //Mengecek apakah satuan suhu belum dipilih. Jika belum, program menampilkan pesan “Pilih satuan terlebih dahulu!”.
            if (!double.TryParse(textBox1.Text, out double inputValue))
            {
                MessageBox.Show("Masukkan angka yang valid!"); return;
            } //Mengecek apakah input pada textBox1 adalah angka yang valid. Jika tidak, akan muncul pesan “Masukkan angka yang valid!”.
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
