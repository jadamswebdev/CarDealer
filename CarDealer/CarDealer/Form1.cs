using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }

        private void carList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listLabel_Click(object sender, EventArgs e)
        {

        }
        // Controls all the List view items and opens a window based on selected index
        private void selectButton_Click(object sender, EventArgs e)
        {
            if (carList.SelectedIndex == 0)
            {
                honda m = new honda();
                m.Show();
            }
            if (carList.SelectedIndex == 1)
            {
                Ford m = new Ford();
                m.Show();
            }
            if (carList.SelectedIndex == 2)
            {
                Tesla m = new Tesla();
                m.Show();
            }
        }
    }
}
