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
        public void Numeric_Level_ValueChanged(object sender, EventArgs e)
        {
            int Level = (int)Numeric_Level.Value;
            CurrentClass = comboBox_Class.Text;
            CurrentSubclass = comboBox_Subclass.Text;

            if (CurrentClass == "Grunt") RecalculateOutput(Level, label_ClassFeatureSheet, Feature_Levels, Grunt_Class_Features);
            if (CurrentSubclass == "Shock Trooper") RecalculateOutput(Level, label_SubclassFeatureSheet, Subclass_Feature_Levels, Grunt_Shocktrooper_Subclass_Features);
        }
        
        public void RecalculateOutput(int level, Label output_label, int[] level_list, Dictionary<int,string> class_features)
        {
            int FeatureIndex = 0;
            output_label.Text = "";
            while (FeatureIndex <= level)
            {
                if (level_list.Contains(FeatureIndex))
                {
                    int index = Array.IndexOf(level_list, FeatureIndex);
                    output_label.Text += class_features[index] + "\r\n\r\n";
                }
                FeatureIndex++;
            }
        }
    }
}
