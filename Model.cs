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
        public int PhysTotal = 0;
        public int MentTotal = 0;
        public int WillTotal = 0;
        public int SociTotal = 0;
        public int MaxHP = 0;
        public int DamageTaken = 0;
        public int CurrentHP = 0;
        public string CurrentClass;
        public string CurrentSubclass;

        void CalculatePH()
        {
            PhysTotal = ph_base+ph_temp;
            RefreshPH();
        }

        void CalculateMen()
        {
            MentTotal = men_base + men_temp;
            RefreshMen();
        }

        void CalculateWill()
        {
            WillTotal = will_base + will_temp;
            RefreshWill();
        }

        void CalculateSoci()
        {
            SociTotal = soci_base + soci_temp;
            RefreshSoci();
        }


        void CalculateMaxHP()
        {
            MaxHP = ph_base * 4 + will_base * 2 + base_hp + (hp_per_level * level);
            CurrentHP = MaxHP + DamageTaken;
            RefreshMaxHP();
        }
    }
}
