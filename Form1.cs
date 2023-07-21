using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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
            CurrentClass = comboBox_Class.Text;
            CurrentSubclass = comboBox_Subclass.Text;
            label_Max_HP_Display.Text = MaxHP.ToString();
        }

        public void RefreshMaxHP()
        {
            label_Max_HP_Display.Text = MaxHP.ToString();
            label_CurrentHP.Text = CurrentHP.ToString();
        }

        public void RefreshPH()
        {
            Numeric_PH_Val.Value = PhysTotal;
        }

        public void RefreshMen()
        {
            Numeric_MEN_Val.Value = PhysTotal;
        }

        public void RefreshWill()
        {
            Numeric_WIL_Val.Value = PhysTotal;
        }

        public void RefreshSoci()
        {
            Numeric_SOC_Val.Value = PhysTotal;
        }


    }
}