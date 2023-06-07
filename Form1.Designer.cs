
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
            this.label_display_name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Level)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_base_parameters
            // 
            this.label_base_parameters.AutoSize = true;
            this.label_base_parameters.Location = new System.Drawing.Point(8, 10);
            this.label_base_parameters.Name = "label_base_parameters";
            this.label_base_parameters.Size = new System.Drawing.Size(48, 85);
            this.label_base_parameters.TabIndex = 0;
            this.label_base_parameters.Text = "Name\r\n\r\nClass\r\n\r\nLevel";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(62, 10);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(116, 23);
            this.textBox_Name.TabIndex = 1;
            this.textBox_Name.TextChanged += new System.EventHandler(this.textBox_Name_TextChanged);
            // 
            // textBox_Class
            // 
            this.textBox_Class.Location = new System.Drawing.Point(62, 40);
            this.textBox_Class.Name = "textBox_Class";
            this.textBox_Class.Size = new System.Drawing.Size(116, 23);
            this.textBox_Class.TabIndex = 2;
            // 
            // numeric_Level
            // 
            this.numeric_Level.Location = new System.Drawing.Point(62, 70);
            this.numeric_Level.Name = "numeric_Level";
            this.numeric_Level.Size = new System.Drawing.Size(117, 23);
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 108);
            this.panel1.TabIndex = 4;
            // 
            // label_display_name
            // 
            this.label_display_name.AutoSize = true;
            this.label_display_name.Location = new System.Drawing.Point(218, 14);
            this.label_display_name.Name = "label_display_name";
            this.label_display_name.Size = new System.Drawing.Size(56, 17);
            this.label_display_name.TabIndex = 5;
            this.label_display_name.Text = "NAME: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 484);
            this.Controls.Add(this.label_display_name);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Auto_Character_Sheet";
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Level)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_base_parameters;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Class;
        private System.Windows.Forms.NumericUpDown numeric_Level;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_display_name;
    }
}

