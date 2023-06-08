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
        public int MentTotal = 0;
        public int WillTotal = 0;
        public int SociTotal = 0;
        public Form1()
        {
            InitializeComponent();
        }

        void updatePH(object sender, EventArgs e)
        {
            PhysTotal = (int)Numeric_PH_Base.Value + (int)Numeric_PH_Temp.Value;
            Numeric_PH_Val.Value = PhysTotal;
        }
        void updateMEN(object sender, EventArgs e)
        {
            MentTotal = (int)Numeric_MEN_Base.Value + (int)Numeric_MEN_Temp.Value;
            Numeric_MEN_Val.Value = MentTotal;
        }
        void updateWIL(object sender, EventArgs e)
        {
            WillTotal = (int)Numeric_WIL_Base.Value + (int)Numeric_WIL_Temp.Value;
            Numeric_WIL_Val.Value = WillTotal;
        }
        void updateSOC(object sender, EventArgs e)
        {
            SociTotal = (int)Numeric_SOC_Base.Value + (int)Numeric_SOC_Temp.Value;
            Numeric_SOC_Val.Value = SociTotal;
        }
    }
}
