
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
            this.Numeric_Level = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_Subclass = new System.Windows.Forms.ComboBox();
            this.comboBox_Class = new System.Windows.Forms.ComboBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Numeric_SOC_Val = new System.Windows.Forms.NumericUpDown();
            this.Numeric_WIL_Val = new System.Windows.Forms.NumericUpDown();
            this.Numeric_MEN_Val = new System.Windows.Forms.NumericUpDown();
            this.Numeric_PH_Val = new System.Windows.Forms.NumericUpDown();
            this.Numeric_SOC_Temp = new System.Windows.Forms.NumericUpDown();
            this.Numeric_WIL_Temp = new System.Windows.Forms.NumericUpDown();
            this.Numeric_MEN_Temp = new System.Windows.Forms.NumericUpDown();
            this.Numeric_PH_Temp = new System.Windows.Forms.NumericUpDown();
            this.Numeric_SOC_Base = new System.Windows.Forms.NumericUpDown();
            this.Numeric_WIL_Base = new System.Windows.Forms.NumericUpDown();
            this.Numeric_MEN_Base = new System.Windows.Forms.NumericUpDown();
            this.Numeric_PH_Base = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Base_Info = new System.Windows.Forms.TextBox();
            this.textBox_AbilityScores = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Pannel_LBA = new System.Windows.Forms.Panel();
            this.Numeric_CSPpLVL = new System.Windows.Forms.NumericUpDown();
            this.Numeric_SPpLVL = new System.Windows.Forms.NumericUpDown();
            this.Numeric_HPpLVL = new System.Windows.Forms.NumericUpDown();
            this.Label_LBAttributes = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_MainPage = new System.Windows.Forms.TabPage();
            this.tabPage_Inventory = new System.Windows.Forms.TabPage();
            this.tabPage_AbilitySheet = new System.Windows.Forms.TabPage();
            this.label_AbilitySheet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Level)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_SOC_Val)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_WIL_Val)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_MEN_Val)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_PH_Val)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_SOC_Temp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_WIL_Temp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_MEN_Temp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_PH_Temp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_SOC_Base)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_WIL_Base)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_MEN_Base)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_PH_Base)).BeginInit();
            this.Pannel_LBA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_CSPpLVL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_SPpLVL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_HPpLVL)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage_MainPage.SuspendLayout();
            this.tabPage_AbilitySheet.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_base_parameters
            // 
            this.label_base_parameters.AutoSize = true;
            this.label_base_parameters.Location = new System.Drawing.Point(7, 12);
            this.label_base_parameters.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_base_parameters.Name = "label_base_parameters";
            this.label_base_parameters.Size = new System.Drawing.Size(51, 126);
            this.label_base_parameters.TabIndex = 0;
            this.label_base_parameters.Text = "Name\r\n\r\nClass\r\n\r\nSubclass\r\n\r\nLevel";
            // 
            // Numeric_Level
            // 
            this.Numeric_Level.Location = new System.Drawing.Point(76, 118);
            this.Numeric_Level.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Numeric_Level.Name = "Numeric_Level";
            this.Numeric_Level.Size = new System.Drawing.Size(44, 26);
            this.Numeric_Level.TabIndex = 3;
            this.Numeric_Level.ValueChanged += new System.EventHandler(this.Numeric_Level_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBox_Subclass);
            this.panel1.Controls.Add(this.comboBox_Class);
            this.panel1.Controls.Add(this.textBox_Name);
            this.panel1.Controls.Add(this.label_base_parameters);
            this.panel1.Controls.Add(this.Numeric_Level);
            this.panel1.Location = new System.Drawing.Point(6, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 156);
            this.panel1.TabIndex = 4;
            // 
            // comboBox_Subclass
            // 
            this.comboBox_Subclass.Items.AddRange(new object[] {
            "Grunt",
            "Heavy Weapons",
            "Guerrila ",
            "Sharpshooter"});
            this.comboBox_Subclass.Location = new System.Drawing.Point(76, 81);
            this.comboBox_Subclass.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBox_Subclass.Name = "comboBox_Subclass";
            this.comboBox_Subclass.Size = new System.Drawing.Size(100, 26);
            this.comboBox_Subclass.TabIndex = 7;
            // 
            // comboBox_Class
            // 
            this.comboBox_Class.Items.AddRange(new object[] {
            "Grunt",
            "Heavy Weapons",
            "Guerrila ",
            "Sharpshooter"});
            this.comboBox_Class.Location = new System.Drawing.Point(76, 45);
            this.comboBox_Class.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBox_Class.Name = "comboBox_Class";
            this.comboBox_Class.Size = new System.Drawing.Size(100, 26);
            this.comboBox_Class.TabIndex = 6;
            this.comboBox_Class.SelectedIndexChanged += new System.EventHandler(this.comboBox_Class_SelectedIndexChanged);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(76, 9);
            this.textBox_Name.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 26);
            this.textBox_Name.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Numeric_SOC_Val);
            this.panel2.Controls.Add(this.Numeric_WIL_Val);
            this.panel2.Controls.Add(this.Numeric_MEN_Val);
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
            this.panel2.Location = new System.Drawing.Point(6, 240);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 147);
            this.panel2.TabIndex = 5;
            // 
            // Numeric_SOC_Val
            // 
            this.Numeric_SOC_Val.Location = new System.Drawing.Point(174, 109);
            this.Numeric_SOC_Val.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Numeric_SOC_Val.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Numeric_SOC_Val.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.Numeric_SOC_Val.Name = "Numeric_SOC_Val";
            this.Numeric_SOC_Val.ReadOnly = true;
            this.Numeric_SOC_Val.Size = new System.Drawing.Size(42, 23);
            this.Numeric_SOC_Val.TabIndex = 16;
            this.Numeric_SOC_Val.ValueChanged += new System.EventHandler(this.updateSOC);
            // 
            // Numeric_WIL_Val
            // 
            this.Numeric_WIL_Val.Location = new System.Drawing.Point(174, 80);
            this.Numeric_WIL_Val.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Numeric_WIL_Val.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Numeric_WIL_Val.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.Numeric_WIL_Val.Name = "Numeric_WIL_Val";
            this.Numeric_WIL_Val.ReadOnly = true;
            this.Numeric_WIL_Val.Size = new System.Drawing.Size(42, 23);
            this.Numeric_WIL_Val.TabIndex = 15;
            this.Numeric_WIL_Val.ValueChanged += new System.EventHandler(this.updateWIL);
            // 
            // Numeric_MEN_Val
            // 
            this.Numeric_MEN_Val.Location = new System.Drawing.Point(174, 46);
            this.Numeric_MEN_Val.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Numeric_MEN_Val.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Numeric_MEN_Val.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.Numeric_MEN_Val.Name = "Numeric_MEN_Val";
            this.Numeric_MEN_Val.ReadOnly = true;
            this.Numeric_MEN_Val.Size = new System.Drawing.Size(42, 23);
            this.Numeric_MEN_Val.TabIndex = 6;
            this.Numeric_MEN_Val.ValueChanged += new System.EventHandler(this.updateMEN);
            // 
            // Numeric_PH_Val
            // 
            this.Numeric_PH_Val.Location = new System.Drawing.Point(174, 11);
            this.Numeric_PH_Val.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.Numeric_PH_Val.ReadOnly = true;
            this.Numeric_PH_Val.Size = new System.Drawing.Size(42, 23);
            this.Numeric_PH_Val.TabIndex = 14;
            this.Numeric_PH_Val.ValueChanged += new System.EventHandler(this.updatePH);
            // 
            // Numeric_SOC_Temp
            // 
            this.Numeric_SOC_Temp.Location = new System.Drawing.Point(124, 109);
            this.Numeric_SOC_Temp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Numeric_SOC_Temp.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Numeric_SOC_Temp.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.Numeric_SOC_Temp.Name = "Numeric_SOC_Temp";
            this.Numeric_SOC_Temp.Size = new System.Drawing.Size(46, 23);
            this.Numeric_SOC_Temp.TabIndex = 13;
            this.Numeric_SOC_Temp.ValueChanged += new System.EventHandler(this.updateSOC);
            // 
            // Numeric_WIL_Temp
            // 
            this.Numeric_WIL_Temp.Location = new System.Drawing.Point(124, 80);
            this.Numeric_WIL_Temp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Numeric_WIL_Temp.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Numeric_WIL_Temp.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.Numeric_WIL_Temp.Name = "Numeric_WIL_Temp";
            this.Numeric_WIL_Temp.Size = new System.Drawing.Size(46, 23);
            this.Numeric_WIL_Temp.TabIndex = 12;
            this.Numeric_WIL_Temp.ValueChanged += new System.EventHandler(this.updateWIL);
            // 
            // Numeric_MEN_Temp
            // 
            this.Numeric_MEN_Temp.Location = new System.Drawing.Point(124, 45);
            this.Numeric_MEN_Temp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Numeric_MEN_Temp.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Numeric_MEN_Temp.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.Numeric_MEN_Temp.Name = "Numeric_MEN_Temp";
            this.Numeric_MEN_Temp.Size = new System.Drawing.Size(46, 23);
            this.Numeric_MEN_Temp.TabIndex = 11;
            this.Numeric_MEN_Temp.ValueChanged += new System.EventHandler(this.updateMEN);
            // 
            // Numeric_PH_Temp
            // 
            this.Numeric_PH_Temp.Location = new System.Drawing.Point(124, 11);
            this.Numeric_PH_Temp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.Numeric_PH_Temp.Size = new System.Drawing.Size(46, 23);
            this.Numeric_PH_Temp.TabIndex = 10;
            this.Numeric_PH_Temp.ValueChanged += new System.EventHandler(this.updatePH);
            // 
            // Numeric_SOC_Base
            // 
            this.Numeric_SOC_Base.Location = new System.Drawing.Point(74, 109);
            this.Numeric_SOC_Base.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Numeric_SOC_Base.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Numeric_SOC_Base.Name = "Numeric_SOC_Base";
            this.Numeric_SOC_Base.Size = new System.Drawing.Size(46, 23);
            this.Numeric_SOC_Base.TabIndex = 9;
            this.Numeric_SOC_Base.ValueChanged += new System.EventHandler(this.updateSOC);
            // 
            // Numeric_WIL_Base
            // 
            this.Numeric_WIL_Base.Location = new System.Drawing.Point(74, 80);
            this.Numeric_WIL_Base.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Numeric_WIL_Base.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Numeric_WIL_Base.Name = "Numeric_WIL_Base";
            this.Numeric_WIL_Base.Size = new System.Drawing.Size(46, 23);
            this.Numeric_WIL_Base.TabIndex = 8;
            this.Numeric_WIL_Base.ValueChanged += new System.EventHandler(this.updateWIL);
            // 
            // Numeric_MEN_Base
            // 
            this.Numeric_MEN_Base.Location = new System.Drawing.Point(74, 45);
            this.Numeric_MEN_Base.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Numeric_MEN_Base.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Numeric_MEN_Base.Name = "Numeric_MEN_Base";
            this.Numeric_MEN_Base.Size = new System.Drawing.Size(46, 23);
            this.Numeric_MEN_Base.TabIndex = 7;
            this.Numeric_MEN_Base.ValueChanged += new System.EventHandler(this.updateMEN);
            // 
            // Numeric_PH_Base
            // 
            this.Numeric_PH_Base.Location = new System.Drawing.Point(74, 11);
            this.Numeric_PH_Base.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Numeric_PH_Base.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Numeric_PH_Base.Name = "Numeric_PH_Base";
            this.Numeric_PH_Base.Size = new System.Drawing.Size(46, 23);
            this.Numeric_PH_Base.TabIndex = 6;
            this.Numeric_PH_Base.ValueChanged += new System.EventHandler(this.updatePH);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 11F);
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 126);
            this.label1.TabIndex = 0;
            this.label1.Text = "Physical\r\n\r\nMental\r\n\r\nWillpower\r\n\r\nSocial";
            // 
            // textBox_Base_Info
            // 
            this.textBox_Base_Info.Location = new System.Drawing.Point(5, 6);
            this.textBox_Base_Info.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_Base_Info.Name = "textBox_Base_Info";
            this.textBox_Base_Info.ReadOnly = true;
            this.textBox_Base_Info.Size = new System.Drawing.Size(122, 26);
            this.textBox_Base_Info.TabIndex = 6;
            this.textBox_Base_Info.Tag = "";
            this.textBox_Base_Info.Text = "Base Character Info";
            // 
            // textBox_AbilityScores
            // 
            this.textBox_AbilityScores.Location = new System.Drawing.Point(6, 207);
            this.textBox_AbilityScores.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_AbilityScores.Name = "textBox_AbilityScores";
            this.textBox_AbilityScores.ReadOnly = true;
            this.textBox_AbilityScores.Size = new System.Drawing.Size(79, 26);
            this.textBox_AbilityScores.TabIndex = 7;
            this.textBox_AbilityScores.Tag = "";
            this.textBox_AbilityScores.Text = "Ability Scores";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(5, 394);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(122, 26);
            this.textBox1.TabIndex = 8;
            this.textBox1.Tag = "";
            this.textBox1.Text = "Level-Based Attributes";
            // 
            // Pannel_LBA
            // 
            this.Pannel_LBA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pannel_LBA.Controls.Add(this.Numeric_CSPpLVL);
            this.Pannel_LBA.Controls.Add(this.Numeric_SPpLVL);
            this.Pannel_LBA.Controls.Add(this.Numeric_HPpLVL);
            this.Pannel_LBA.Controls.Add(this.Label_LBAttributes);
            this.Pannel_LBA.Location = new System.Drawing.Point(5, 426);
            this.Pannel_LBA.Name = "Pannel_LBA";
            this.Pannel_LBA.Size = new System.Drawing.Size(208, 151);
            this.Pannel_LBA.TabIndex = 9;
            // 
            // Numeric_CSPpLVL
            // 
            this.Numeric_CSPpLVL.Location = new System.Drawing.Point(160, 114);
            this.Numeric_CSPpLVL.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Numeric_CSPpLVL.Name = "Numeric_CSPpLVL";
            this.Numeric_CSPpLVL.Size = new System.Drawing.Size(34, 26);
            this.Numeric_CSPpLVL.TabIndex = 12;
            // 
            // Numeric_SPpLVL
            // 
            this.Numeric_SPpLVL.Location = new System.Drawing.Point(160, 77);
            this.Numeric_SPpLVL.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Numeric_SPpLVL.Name = "Numeric_SPpLVL";
            this.Numeric_SPpLVL.Size = new System.Drawing.Size(34, 26);
            this.Numeric_SPpLVL.TabIndex = 11;
            // 
            // Numeric_HPpLVL
            // 
            this.Numeric_HPpLVL.Location = new System.Drawing.Point(160, 42);
            this.Numeric_HPpLVL.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Numeric_HPpLVL.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.Numeric_HPpLVL.Name = "Numeric_HPpLVL";
            this.Numeric_HPpLVL.Size = new System.Drawing.Size(34, 26);
            this.Numeric_HPpLVL.TabIndex = 10;
            // 
            // Label_LBAttributes
            // 
            this.Label_LBAttributes.AutoSize = true;
            this.Label_LBAttributes.Location = new System.Drawing.Point(12, 10);
            this.Label_LBAttributes.Name = "Label_LBAttributes";
            this.Label_LBAttributes.Size = new System.Drawing.Size(133, 126);
            this.Label_LBAttributes.TabIndex = 0;
            this.Label_LBAttributes.Text = "Base HP\r\n\r\nHP/Level\r\n\r\nSkill Points/Level \r\n\r\nCombat Skill Points/Level";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage_MainPage);
            this.tabControl.Controls.Add(this.tabPage_Inventory);
            this.tabControl.Controls.Add(this.tabPage_AbilitySheet);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(903, 612);
            this.tabControl.TabIndex = 10;
            // 
            // tabPage_MainPage
            // 
            this.tabPage_MainPage.Controls.Add(this.textBox_Base_Info);
            this.tabPage_MainPage.Controls.Add(this.Pannel_LBA);
            this.tabPage_MainPage.Controls.Add(this.panel1);
            this.tabPage_MainPage.Controls.Add(this.textBox1);
            this.tabPage_MainPage.Controls.Add(this.panel2);
            this.tabPage_MainPage.Controls.Add(this.textBox_AbilityScores);
            this.tabPage_MainPage.Location = new System.Drawing.Point(4, 27);
            this.tabPage_MainPage.Name = "tabPage_MainPage";
            this.tabPage_MainPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_MainPage.Size = new System.Drawing.Size(895, 581);
            this.tabPage_MainPage.TabIndex = 0;
            this.tabPage_MainPage.Text = "Main Page";
            this.tabPage_MainPage.UseVisualStyleBackColor = true;
            // 
            // tabPage_Inventory
            // 
            this.tabPage_Inventory.Location = new System.Drawing.Point(4, 27);
            this.tabPage_Inventory.Name = "tabPage_Inventory";
            this.tabPage_Inventory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Inventory.Size = new System.Drawing.Size(895, 581);
            this.tabPage_Inventory.TabIndex = 1;
            this.tabPage_Inventory.Text = "Inventory";
            this.tabPage_Inventory.UseVisualStyleBackColor = true;
            // 
            // tabPage_AbilitySheet
            // 
            this.tabPage_AbilitySheet.Controls.Add(this.label_AbilitySheet);
            this.tabPage_AbilitySheet.Location = new System.Drawing.Point(4, 27);
            this.tabPage_AbilitySheet.Name = "tabPage_AbilitySheet";
            this.tabPage_AbilitySheet.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_AbilitySheet.Size = new System.Drawing.Size(895, 581);
            this.tabPage_AbilitySheet.TabIndex = 2;
            this.tabPage_AbilitySheet.Text = "Ability Sheet";
            this.tabPage_AbilitySheet.UseVisualStyleBackColor = true;
            // 
            // label_AbilitySheet
            // 
            this.label_AbilitySheet.AutoSize = true;
            this.label_AbilitySheet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_AbilitySheet.Location = new System.Drawing.Point(8, 3);
            this.label_AbilitySheet.Name = "label_AbilitySheet";
            this.label_AbilitySheet.Size = new System.Drawing.Size(40, 20);
            this.label_AbilitySheet.TabIndex = 0;
            this.label_AbilitySheet.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 612);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Form1";
            this.Text = "Auto_Character_Sheet";
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Level)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_SOC_Val)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_WIL_Val)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_MEN_Val)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_PH_Val)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_SOC_Temp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_WIL_Temp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_MEN_Temp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_PH_Temp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_SOC_Base)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_WIL_Base)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_MEN_Base)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_PH_Base)).EndInit();
            this.Pannel_LBA.ResumeLayout(false);
            this.Pannel_LBA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_CSPpLVL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_SPpLVL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_HPpLVL)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage_MainPage.ResumeLayout(false);
            this.tabPage_MainPage.PerformLayout();
            this.tabPage_AbilitySheet.ResumeLayout(false);
            this.tabPage_AbilitySheet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_base_parameters;
        private System.Windows.Forms.NumericUpDown Numeric_Level;
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
        private System.Windows.Forms.ComboBox comboBox_Class;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.NumericUpDown Numeric_MEN_Val;
        private System.Windows.Forms.NumericUpDown Numeric_WIL_Val;
        private System.Windows.Forms.NumericUpDown Numeric_SOC_Val;
        private System.Windows.Forms.TextBox textBox_Base_Info;
        private System.Windows.Forms.TextBox textBox_AbilityScores;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel Pannel_LBA;
        private System.Windows.Forms.Label Label_LBAttributes;
        private System.Windows.Forms.NumericUpDown Numeric_CSPpLVL;
        private System.Windows.Forms.NumericUpDown Numeric_SPpLVL;
        private System.Windows.Forms.NumericUpDown Numeric_HPpLVL;
        private System.Windows.Forms.ComboBox comboBox_Subclass;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_MainPage;
        private System.Windows.Forms.TabPage tabPage_Inventory;
        private System.Windows.Forms.TabPage tabPage_AbilitySheet;
        private System.Windows.Forms.Label label_AbilitySheet;
    }
}

