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
        public string CurrentClass;
        public string CurrentSubclass;
        public Dictionary<int, string> Grunt_Class_Features = new Dictionary<int, string>
        {
            {0, "In The Zone: \r\nWhenever in combat, you can activate In The Zone. While In The Zone is active, you gain the following ability." +
                "\r\nWet Work: At the start of every turn, you have 6AP that you can only use for offensive actions." +
                "\r\nIn The Zone can remain active up to a number of rounds equal to your level divided by 3 rounded down (minimum 1), You may cancel the ability and save whatever remaining rounds that you may have for later use. " +
                "You replenish all uses at the end of combat." },
            {1, "Run While You Can: \r\nWhenever you end a conversation and you get attacked as a direct result of it, you may make an Intimidate attempt against all " +
                "of the hostile NPCs. Whoever you succeed against becomes Panicked for 1 turn." },
            {2, "Fast Weapon Operation: \r\nYou may draw weapons that are in holsters or on sling at no AP cost. You may also switch firing modes and pull items out of your vest at no AP cost." },
            {3, "Covered: \r\nyou can take full cover for free as if you took an offensive action on your turn." },
            {4, "Lightning Hands: \r\nWhile In The Zone is active, you may reload one weapon for free every turn. Every reload thereafter will have its reload AP cost decreased by 2AP down to a minimum of 1AP." },
            {5, "Operator: \r\nIf In The Zone is active and you score a kill, its duration increases by one round. This can only happen once per turn. Canceling In The Zone will not allow you " +
                "to save rounds given to you by this ability." },
            {6, "Grit: \r\nIf something dealt enough damage to you to cause you to get knocked down, but not go unconscious or killed outright, you instead remain at 1HP and In The Zone will " +
                "immediately activate on your next turn. This In The Zone activation " +
                "does not consume your regular In The Zone turns, but only lasts for 1 turn. This may only activate once per day." },
            };
        public Dictionary<int, string> Grunt_Shocktrooper_Subclass_Features = new Dictionary<int, string>
        {
            {0, "Shockzone: \r\nYou gain an additional In The Zone ability.\r\nRun and Gun: You gain 6AP per turn that you may use for movement." },
            {1, "Hit and Run: \r\nAfter you kill an enemy, you may take any actions after sprinting on that turn." },
            {2, "Booming Start: \r\nOn your first turn of combat, you gain 4AP of movement, and 1 free offensive action." },
            {3, "Throwback: \r\nWhenever you succeed on a Dodge check to avoid taking damage from a thrown grenade (be it HE, Fragmentation, molotov, incendiary, etc.), you take the grenade and throw it 20m in a direction of your choosing, where it will explode as the grenade normally would, but with its save DC increased by 3." },
            {4, "Lightning Reflexes: \r\nIf you get attacked on your turn (eg. from a prepared attack), the enemy has a -10 penalty on the attack." },
            {5, "Twice as Bright, Half as Long: \r\nWhenever you deal a critical hit, you may choose to use a battleart and apply it to that hit instead of increasing the damage. You may pick any battleart from the list, even one you don’t have." },
            {6, "Onslaught: \r\nhen you kill an enemy on your turn, you get 6AP back. Cannot trigger more than once per turn." },
        };
        public string[] base_subclasses = { "Medic", "Squad Leader" };
        public Dictionary<int, string[]> specific_subclases = new Dictionary<int, string[]>{
            {0, new string[] { "Shock Trooper", "Juggernaut" } },
            {1, new string[] { "Demolitions", "Machine Gunner" } },
            {2, new string[] { "Infiltrator", "Scout" } },
            {3, new string[] { "Designated Marksman", "Sniper" } },
        };
        public int[] Feature_Levels = { 1, 4, 7, 9, 13, 17, 19 };
        public int[] Subclass_Feature_Levels = { 3, 5, 8, 11, 18, 20 };

        public Form1()
        {
            InitializeComponent();
            CurrentClass = comboBox_Class.Text;
            CurrentSubclass = comboBox_Subclass.Text;
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

        private void Numeric_Level_ValueChanged(object sender, EventArgs e)
        {
            int Level = (int)Numeric_Level.Value;
            CurrentClass = comboBox_Class.Text;
            CurrentSubclass = comboBox_Subclass.Text;

            //TODO: i in the for loop iterates Level numer of times, rather than only the number of times it's supposed to

            if (CurrentClass == "Grunt")
            {
                int FeatureIndex = 0;
                label_ClassFeatureSheet.Text = "";
                while (Feature_Levels[FeatureIndex] < Level)
                {
                    FeatureIndex++;
                    if (Feature_Levels.Contains(FeatureIndex))
                    {
                        label_ClassFeatureSheet.Text += Grunt_Class_Features[FeatureIndex] + "\r\n\r\n";

                    }
                }

            }
            if (CurrentSubclass == "Shock Trooper")
            {
                {
                    if (Subclass_Feature_Levels.Contains(Level))
                        label_SubclassFeatureSheet.Text = "";
                    for (int i = 0; i < Level; i++)
                    {
                        label_SubclassFeatureSheet.Text += Grunt_Shocktrooper_Subclass_Features[i] + "\r\n\r\n";
                    }
                }
            }
        }
    }
}

/*
         * Class/Subclass Feature Dictionary Template
         *   public Dictionary<int, string[]> Grunt_Subclass_Features = new Dictionary<int, string[]>
        {
            { 0, new string[] { "", "" } },
            { 1, new string[] { "", "" } },
            { 2, new string[] { "", "" } },
            { 3, new string[] { "", "" } },
            { 4, new string[] { "", "" } },
            { 5, new string[] { "", "" } },
            { 6, new string[] { "", "" } },
        };
         */