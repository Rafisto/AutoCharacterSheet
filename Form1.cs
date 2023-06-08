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

        public string[] base_subclasses = { "Subclass 0", "Subclass 1" };
        public Dictionary<int, string[]> specific_subclases = new Dictionary<int, string[]>{
            {0, new string[] { "SS 0 - 1", "SS 0 - 2" } },
            {1, new string[] { "SS 1 - 1", "SS 1 - 2" } },
            {2, new string[] { "SS 2 - 1", "SS 2 - 2" } },
            {3, new string[] { "SS 3 - 1", "SS 3 - 2" } },
        };
        private void comboBox_Class_SelectedIndexChanged(object sender, EventArgs e)
        {
            /// <summary>
            /// Change the subclass comboBox options with regard to the selected class
            /// </summary>
            int selectedClassID = comboBox_Class.SelectedIndex;
            comboBox_Subclass.Items.Clear();
            foreach (string base_subclass in base_subclasses)
            {
                comboBox_Subclass.Items.Add(base_subclass);
            }
            foreach (string specific_subclass in specific_subclases[selectedClassID])
            {
                comboBox_Subclass.Items.Add(specific_subclass);
            }
        }

        public Dictionary<int, string> new_abilities = new Dictionary<int, string>{
            {0, "Ability 1" },
            {1, "Ability 2" },
            {2, "Ability 3" },
            {3, "Ability 4" },
        };
        private void Numeric_Level_ValueChanged(object sender, EventArgs e)
        {
            int level = (int)Numeric_Level.Value;
            label_AbilitySheet.Text = "";
            for (int i = 0; i < level; i++) {
                if (i <= new_abilities.Count - 1)
                {
                    label_AbilitySheet.Text += new_abilities[i] + "\r\n";
                }
                else
                {
                    label_AbilitySheet.Text += "Undefined ability" + "\r\n";
                }
            }
        }
    }
}
