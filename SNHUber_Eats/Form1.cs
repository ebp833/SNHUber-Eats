using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SNHUber_Eats_Dining_Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MillCityMenu mc = new MillCityMenu();
            mc.ShowDialog();
            this.Close();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MillCityLabel_Click(object sender, EventArgs e)
        {

        }
        private void MillCityGrillButton_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void FiestaZoneButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FiestaZoneMenu fz = new FiestaZoneMenu();
            fz.ShowDialog();
            this.Close();
        }

        private void LaTrattoriaPastaButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LaTrattoriaPastaMenu fz = new LaTrattoriaPastaMenu();
            fz.ShowDialog();
            this.Close();
        }

        private void LaTrattoriaButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LaTrattoriaPizzaMenu fz = new LaTrattoriaPizzaMenu();
            fz.Show();
        }
    }
}
