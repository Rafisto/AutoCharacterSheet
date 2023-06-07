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
        public int PhysTotal = 0;
        public Form1()
        {
            InitializeComponent();
        }

        void updatePH(object sender, EventArgs e)
        {
            PhysTotal = (int)Numeric_PH_Base.Value + (int)Numeric_PH_Temp.Value;
            Numeric_PH_Val.Value = PhysTotal;
        }
    }
}
