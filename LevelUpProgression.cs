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
            if (CurrentSubclass == "Juggernaut") RecalculateOutput(Level, label_SubclassFeatureSheet, Subclass_Feature_Levels, Grunt_Juggernaut_Subclass_Features);
            if (CurrentClass == "Heavy Weapons") RecalculateOutput(Level, label_ClassFeatureSheet, Feature_Levels, Heavy_Class_Features);
            if (CurrentSubclass == "Machine Gunner") RecalculateOutput(Level, label_SubclassFeatureSheet, Subclass_Feature_Levels, Heavy_MachineGunner_Subclass_Features);
            if (CurrentSubclass == "Demolitions") RecalculateOutput(Level, label_SubclassFeatureSheet, Subclass_Feature_Levels, Heavy_Demolitions_Subclass_Features);
            if (CurrentClass == "Sharpshooter") RecalculateOutput(Level, label_ClassFeatureSheet, Feature_Levels, Sharpshooter_Class_Features);
            if (CurrentSubclass == "Sniper") RecalculateOutput(Level, label_SubclassFeatureSheet, Subclass_Feature_Levels, Sharpshooter_Sniper_Sublass_Features);
            if (CurrentSubclass == "Designated Marksman") RecalculateOutput(Level, label_SubclassFeatureSheet, Subclass_Feature_Levels, Sharpshooter_Designated_Marksman_Sublass_Features);
            if (CurrentClass == "Guerilla") RecalculateOutput(Level, label_ClassFeatureSheet, Feature_Levels, Guerilla_Class_Features);
            if (CurrentSubclass == "Scout") RecalculateOutput(Level, label_SubclassFeatureSheet, Subclass_Feature_Levels, Guerilla_Scout_Sublass_Features);
            if (CurrentSubclass == "Infiltrator") RecalculateOutput(Level, label_SubclassFeatureSheet, Subclass_Feature_Levels, Guerilla_Infiltrator_Sublass_Features);
            if (CurrentSubclass == "Medic") RecalculateOutput(Level, label_SubclassFeatureSheet, Subclass_Feature_Levels, Universal_Medic_Sublass_Features);
            if (CurrentSubclass == "Squad Leader") RecalculateOutput(Level, label_SubclassFeatureSheet, Subclass_Feature_Levels, Universal_Squad_Leader_Sublass_Features);

            updateMaxHP(sender, e);

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
