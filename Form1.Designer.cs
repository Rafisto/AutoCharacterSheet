
namespace AutoCharacterSheet
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_base_parameters = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Class = new System.Windows.Forms.TextBox();
            this.numeric_Level = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Numeric_SOC_Temp = new System.Windows.Forms.NumericUpDown();
            this.Numeric_WIL_Temp = new System.Windows.Forms.NumericUpDown();
            this.Numeric_MEN_Temp = new System.Windows.Forms.NumericUpDown();
            this.Numeric_PH_Temp = new System.Windows.Forms.NumericUpDown();
            this.Numeric_SOC_Base = new System.Windows.Forms.NumericUpDown();
            this.Numeric_WIL_Base = new System.Windows.Forms.NumericUpDown();
            this.Numeric_MEN_Base = new System.Windows.Forms.NumericUpDown();
            this.Numeric_PH_Base = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Numeric_PH_Val = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Level)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_SOC_Temp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_WIL_Temp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_MEN_Temp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_PH_Temp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_SOC_Base)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_WIL_Base)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_MEN_Base)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_PH_Base)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_PH_Val)).BeginInit();
            this.SuspendLayout();
            // 
            // label_base_parameters
            // 
            this.label_base_parameters.AutoSize = true;
            this.label_base_parameters.Location = new System.Drawing.Point(9, 12);
            this.label_base_parameters.Name = "label_base_parameters";
            this.label_base_parameters.Size = new System.Drawing.Size(48, 90);
            this.label_base_parameters.TabIndex = 0;
            this.label_base_parameters.Text = "Name\r\n\r\nClass\r\n\r\nLevel";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(71, 12);
            this.textBox_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(132, 25);
            this.textBox_Name.TabIndex = 1;
            // 
            // textBox_Class
            // 
            this.textBox_Class.Location = new System.Drawing.Point(71, 48);
            this.textBox_Class.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Class.Name = "textBox_Class";
            this.textBox_Class.Size = new System.Drawing.Size(132, 25);
            this.textBox_Class.TabIndex = 2;
            // 
            // numeric_Level
            // 
            this.numeric_Level.Location = new System.Drawing.Point(71, 84);
            this.numeric_Level.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numeric_Level.Name = "numeric_Level";
            this.numeric_Level.Size = new System.Drawing.Size(40, 25);
            this.numeric_Level.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox_Name);
            this.panel1.Controls.Add(this.label_base_parameters);
            this.panel1.Controls.Add(this.numeric_Level);
            this.panel1.Controls.Add(this.textBox_Class);
            this.panel1.Location = new System.Drawing.Point(14, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 129);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Numeric_PH_Val);
            this.panel2.Controls.Add(this.Numeric_SOC_Temp);
            this.panel2.Controls.Add(this.Numeric_WIL_Temp);
            this.panel2.Controls.Add(this.Numeric_MEN_Temp);
            this.panel2.Controls.Add(this.Numeric_PH_Temp);
            this.panel2.Controls.Add(this.Numeric_SOC_Base);
            this.panel2.Controls.Add(this.Numeric_WIL_Base);
            this.panel2.Controls.Add(this.Numeric_MEN_Base);
            this.panel2.Controls.Add(this.Numeric_PH_Base);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Font = new System.Drawing.Font("Consolas", 10F);
            this.panel2.Location = new System.Drawing.Point(14, 173);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 139);
            this.panel2.TabIndex = 5;
            // 
            // Numeric_SOC_Temp
            // 
            this.Numeric_SOC_Temp.Location = new System.Drawing.Point(136, 95);
            this.Numeric_SOC_Temp.Name = "Numeric_SOC_Temp";
            this.Numeric_SOC_Temp.Size = new System.Drawing.Size(34, 23);
            this.Numeric_SOC_Temp.TabIndex = 13;
            // 
            // Numeric_WIL_Temp
            // 
            this.Numeric_WIL_Temp.Location = new System.Drawing.Point(136, 66);
            this.Numeric_WIL_Temp.Name = "Numeric_WIL_Temp";
            this.Numeric_WIL_Temp.Size = new System.Drawing.Size(34, 23);
            this.Numeric_WIL_Temp.TabIndex = 12;
            // 
            // Numeric_MEN_Temp
            // 
            this.Numeric_MEN_Temp.Location = new System.Drawing.Point(136, 37);
            this.Numeric_MEN_Temp.Name = "Numeric_MEN_Temp";
            this.Numeric_MEN_Temp.Size = new System.Drawing.Size(34, 23);
            this.Numeric_MEN_Temp.TabIndex = 11;
            // 
            // Numeric_PH_Temp
            // 
            this.Numeric_PH_Temp.Location = new System.Drawing.Point(136, 8);
            this.Numeric_PH_Temp.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Numeric_PH_Temp.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.Numeric_PH_Temp.Name = "Numeric_PH_Temp";
            this.Numeric_PH_Temp.Size = new System.Drawing.Size(34, 23);
            this.Numeric_PH_Temp.TabIndex = 10;
            this.Numeric_PH_Temp.ValueChanged += new System.EventHandler(this.updatePH);
            // 
            // Numeric_SOC_Base
            // 
            this.Numeric_SOC_Base.Location = new System.Drawing.Point(96, 95);
            this.Numeric_SOC_Base.Name = "Numeric_SOC_Base";
            this.Numeric_SOC_Base.Size = new System.Drawing.Size(34, 23);
            this.Numeric_SOC_Base.TabIndex = 9;
            // 
            // Numeric_WIL_Base
            // 
            this.Numeric_WIL_Base.Location = new System.Drawing.Point(96, 66);
            this.Numeric_WIL_Base.Name = "Numeric_WIL_Base";
            this.Numeric_WIL_Base.Size = new System.Drawing.Size(34, 23);
            this.Numeric_WIL_Base.TabIndex = 8;
            // 
            // Numeric_MEN_Base
            // 
            this.Numeric_MEN_Base.Location = new System.Drawing.Point(96, 37);
            this.Numeric_MEN_Base.Name = "Numeric_MEN_Base";
            this.Numeric_MEN_Base.Size = new System.Drawing.Size(34, 23);
            this.Numeric_MEN_Base.TabIndex = 7;
            // 
            // Numeric_PH_Base
            // 
            this.Numeric_PH_Base.Location = new System.Drawing.Point(96, 8);
            this.Numeric_PH_Base.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Numeric_PH_Base.Name = "Numeric_PH_Base";
            this.Numeric_PH_Base.Size = new System.Drawing.Size(34, 23);
            this.Numeric_PH_Base.TabIndex = 6;
            this.Numeric_PH_Base.ValueChanged += new System.EventHandler(this.updatePH);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 119);
            this.label1.TabIndex = 0;
            this.label1.Text = "Physical\r\n\r\nMental\r\n\r\nWillpower\r\n\r\nSocial";
            // 
            // Numeric_PH_Val
            // 
            this.Numeric_PH_Val.Location = new System.Drawing.Point(176, 8);
            this.Numeric_PH_Val.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Numeric_PH_Val.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.Numeric_PH_Val.Name = "Numeric_PH_Val";
            this.Numeric_PH_Val.Size = new System.Drawing.Size(43, 23);
            this.Numeric_PH_Val.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 770);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Consolas", 11F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Auto_Character_Sheet";
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Level)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_SOC_Temp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_WIL_Temp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_MEN_Temp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_PH_Temp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_SOC_Base)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_WIL_Base)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_MEN_Base)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_PH_Base)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_PH_Val)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_base_parameters;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Class;
        private System.Windows.Forms.NumericUpDown numeric_Level;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Numeric_SOC_Temp;
        private System.Windows.Forms.NumericUpDown Numeric_WIL_Temp;
        private System.Windows.Forms.NumericUpDown Numeric_MEN_Temp;
        private System.Windows.Forms.NumericUpDown Numeric_PH_Temp;
        private System.Windows.Forms.NumericUpDown Numeric_SOC_Base;
        private System.Windows.Forms.NumericUpDown Numeric_WIL_Base;
        private System.Windows.Forms.NumericUpDown Numeric_MEN_Base;
        private System.Windows.Forms.NumericUpDown Numeric_PH_Base;
        private System.Windows.Forms.NumericUpDown Numeric_PH_Val;
    }
}

