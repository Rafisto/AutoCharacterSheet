using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCharacterSheet
{
    public partial class Form1 : Form
    {
        public int ph_base, ph_temp, men_base, men_temp, will_base, will_temp, soci_base, soci_temp, base_hp, hp_per_level, level;

        void updateHP(object sender, EventArgs e)
        {
            CurrentHP = MaxHP + DamageTaken;
            label_CurrentHP.Text = CurrentHP.ToString();
        }

        void updatePH(object sender, EventArgs e)
        {
            ph_base = (int)Numeric_PH_Base.Value;
            ph_temp = (int)Numeric_PH_Temp.Value;
            CalculatePH();
            CalculateMaxHP();
        }
        void updateMEN(object sender, EventArgs e)
        {
            men_base = (int)Numeric_MEN_Base.Value;
            men_temp = (int)Numeric_MEN_Temp.Value;
            CalculateMen();
            CalculateMaxHP();
        }
        void updateWIL(object sender, EventArgs e)
        {
            will_base = (int)Numeric_WIL_Base.Value;
            will_temp = (int)Numeric_WIL_Temp.Value;
            CalculateWill();
            CalculateMaxHP();
        }
        void updateSOC(object sender, EventArgs e)
        {
            soci_base = (int)Numeric_SOC_Base.Value;
            soci_temp = (int)Numeric_SOC_Temp.Value;
            CalculateSoci();
            CalculateMaxHP();
        }

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

        private void button_add_HP_Click(object sender, EventArgs e)
        {
            DamageTaken = DamageTaken + (int)numeric_modify_HP.Value;
            updateHP(sender, e);
            numeric_modify_HP.Value = 0;
        }

        private void button_remove_HP_Click(object sender, EventArgs e)
        {
            DamageTaken = DamageTaken - (int)numeric_modify_HP.Value;
            updateHP(sender, e);
            numeric_modify_HP.Value = 0;
        }

        private void numeric_BaseHP_ValueChanged(object sender, EventArgs e)
        {
            updateHP(sender, e);
        }

        private void Numeric_HPpLVL_ValueChanged(object sender, EventArgs e)
        {
            updateHP(sender, e);
        }
    }
}
