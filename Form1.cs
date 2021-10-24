using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BA_Boost_SayiTahmin
{
    public partial class Form1 : Form
    {
        
        int rnd = new Random().Next(1, 100);
        public Form1()
        {
            InitializeComponent();
            
        }

        public void guessbutton_Click(object sender, EventArgs e)
        {
            decimal proximity=0;
            decimal input = Convert.ToDecimal(guess.Text.Trim());
            
            if (input < rnd) {
                proximity = (input / Convert.ToDecimal(rnd)) * 100;
            }
            else if (input > rnd) {

                proximity = (Convert.ToDecimal(rnd) / input) * 100;
            }
            else if (input == Convert.ToDecimal(rnd)) {
                proximity = 100;
                MessageBox.Show($"Tebrikler seçilen sayı {rnd} idi.");
                proximity = 0;
                progressBar1.Value = 0;
                rnd = new Random().Next(1, 100);
                guess.Clear();
                return;
            }
            
            progressBar1.Value = Convert.ToInt32(proximity);
            guess.Clear();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Maximum=100;
            progressBar1.Minimum = 0;
            
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {


        }
    }
}
