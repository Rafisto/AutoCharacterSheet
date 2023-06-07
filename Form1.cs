using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCharacterSheet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox_Name_TextChanged(object sender, EventArgs e)
        {
            label_display_name.Text = "NAME: " + textBox_Name.Text;
        }
    }
}
