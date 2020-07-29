namespace ExactDataMatchConfiguration
{
    partial class frmEDM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEDM));
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFileSelected = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDataStoreName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dlgFile = new System.Windows.Forms.OpenFileDialog();
            this.cboLanguage = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProximity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtConfidence = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgRules = new System.Windows.Forms.DataGridView();
            this.FieldName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Searchable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Match = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMinMatches = new System.Windows.Forms.TextBox();
            this.txtMaxMatches = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.lblPublisherName = new System.Windows.Forms.Label();
            this.txtPublisherName = new System.Windows.Forms.TextBox();
            this.txtCustomInformationType = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusProcessingStep = new System.Windows.Forms.ToolStripStatusLabel();
            this.label19 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createEDMSchemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createEDMRulePackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadSchemaAndRulePackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadDataFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgRules)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select CVS Data File*";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(392, 160);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "File Selected";
            // 
            // txtFileSelected
            // 
            this.txtFileSelected.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtFileSelected.Location = new System.Drawing.Point(392, 189);
            this.txtFileSelected.Name = "txtFileSelected";
            this.txtFileSelected.ReadOnly = true;
            this.txtFileSelected.Size = new System.Drawing.Size(306, 20);
            this.txtFileSelected.TabIndex = 44;
            this.txtFileSelected.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Data Store Name*";
            // 
            // txtDataStoreName
            // 
            this.txtDataStoreName.Location = new System.Drawing.Point(392, 223);
            this.txtDataStoreName.Name = "txtDataStoreName";
            this.txtDataStoreName.Size = new System.Drawing.Size(306, 20);
            this.txtDataStoreName.TabIndex = 4;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(392, 250);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(306, 20);
            this.txtDescription.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Description*";
            // 
            // dlgFile
            // 
            this.dlgFile.FileName = "dlgFile";
            // 
            // cboLanguage
            // 
            this.cboLanguage.FormattingEnabled = true;
            this.cboLanguage.Items.AddRange(new object[] {
            "en-us"});
            this.cboLanguage.Location = new System.Drawing.Point(94, 3);
            this.cboLanguage.Name = "cboLanguage";
            this.cboLanguage.Size = new System.Drawing.Size(85, 21);
            this.cboLanguage.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Language";
            // 
            // txtProximity
            // 
            this.txtProximity.Location = new System.Drawing.Point(94, 29);
            this.txtProximity.Name = "txtProximity";
            this.txtProximity.Size = new System.Drawing.Size(85, 20);
            this.txtProximity.TabIndex = 10;
            this.txtProximity.Text = "300";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Pattern Proximity";
            // 
            // txtConfidence
            // 
            this.txtConfidence.Location = new System.Drawing.Point(94, 56);
            this.txtConfidence.Name = "txtConfidence";
            this.txtConfidence.Size = new System.Drawing.Size(85, 20);
            this.txtConfidence.TabIndex = 11;
            this.txtConfidence.Text = "75";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Confidence";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(185, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "%";
            // 
            // dgRules
            // 
            this.dgRules.AllowUserToAddRows = false;
            this.dgRules.AllowUserToDeleteRows = false;
            this.dgRules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FieldName,
            this.Searchable,
            this.Match});
            this.dgRules.Location = new System.Drawing.Point(258, 410);
            this.dgRules.MultiSelect = false;
            this.dgRules.Name = "dgRules";
            this.dgRules.RowHeadersWidth = 82;
            this.dgRules.ShowEditingIcon = false;
            this.dgRules.Size = new System.Drawing.Size(479, 159);
            this.dgRules.TabIndex = 8;
            // 
            // FieldName
            // 
            this.FieldName.HeaderText = "Field Name";
            this.FieldName.MaxInputLength = 255;
            this.FieldName.MinimumWidth = 10;
            this.FieldName.Name = "FieldName";
            this.FieldName.ReadOnly = true;
            this.FieldName.Width = 200;
            // 
            // Searchable
            // 
            this.Searchable.HeaderText = "Searchable";
            this.Searchable.MinimumWidth = 10;
            this.Searchable.Name = "Searchable";
            this.Searchable.Width = 75;
            // 
            // Match
            // 
            this.Match.HeaderText = "Match";
            this.Match.MinimumWidth = 10;
            this.Match.Name = "Match";
            this.Match.Width = 75;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(260, 377);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 31);
            this.label10.TabIndex = 18;
            this.label10.Text = "Rules";
            // 
            // txtMinMatches
            // 
            this.txtMinMatches.Location = new System.Drawing.Point(94, 85);
            this.txtMinMatches.Name = "txtMinMatches";
            this.txtMinMatches.Size = new System.Drawing.Size(51, 20);
            this.txtMinMatches.TabIndex = 12;
            this.txtMinMatches.Text = "1";
            // 
            // txtMaxMatches
            // 
            this.txtMaxMatches.Location = new System.Drawing.Point(94, 111);
            this.txtMaxMatches.Name = "txtMaxMatches";
            this.txtMaxMatches.Size = new System.Drawing.Size(51, 20);
            this.txtMaxMatches.TabIndex = 13;
            this.txtMaxMatches.Text = "5";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Min Matches";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Max Matches";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(800, 528);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(133, 41);
            this.btnCreate.TabIndex = 14;
            this.btnCreate.Text = "Create EDM Schema";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(704, 189);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(44, 23);
            this.btnLoad.TabIndex = 24;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Visible = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 139);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 20);
            this.label13.TabIndex = 26;
            this.label13.Text = "Directions";
            // 
            // lblPublisherName
            // 
            this.lblPublisherName.AutoSize = true;
            this.lblPublisherName.Location = new System.Drawing.Point(336, 283);
            this.lblPublisherName.Name = "lblPublisherName";
            this.lblPublisherName.Size = new System.Drawing.Size(54, 13);
            this.lblPublisherName.TabIndex = 28;
            this.lblPublisherName.Text = "Publisher*";
            // 
            // txtPublisherName
            // 
            this.txtPublisherName.Location = new System.Drawing.Point(392, 276);
            this.txtPublisherName.Name = "txtPublisherName";
            this.txtPublisherName.Size = new System.Drawing.Size(306, 20);
            this.txtPublisherName.TabIndex = 6;
            // 
            // txtCustomInformationType
            // 
            this.txtCustomInformationType.Location = new System.Drawing.Point(392, 302);
            this.txtCustomInformationType.Name = "txtCustomInformationType";
            this.txtCustomInformationType.Size = new System.Drawing.Size(306, 20);
            this.txtCustomInformationType.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(262, 305);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Custom Information Type*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exact Data Match Configuration";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(616, 7);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(268, 20);
            this.label15.TabIndex = 32;
            this.label15.Text = "Security and Compliance Credentials";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(616, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "User Name*:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Location = new System.Drawing.Point(8, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 91);
            this.panel1.TabIndex = 33;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.ControlText;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label18.Font = new System.Drawing.Font("Arial", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(601, 10);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(4, 68);
            this.label18.TabIndex = 36;
            this.label18.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(688, 58);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(237, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(622, 61);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "Password*:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(688, 29);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(237, 20);
            this.txtUserName.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Location = new System.Drawing.Point(16, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 194);
            this.panel2.TabIndex = 34;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(3, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(221, 196);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusProcessingStep});
            this.statusStrip.Location = new System.Drawing.Point(0, 586);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(958, 22);
            this.statusStrip.TabIndex = 35;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusProcessingStep
            // 
            this.toolStripStatusProcessingStep.Name = "toolStripStatusProcessingStep";
            this.toolStripStatusProcessingStep.Size = new System.Drawing.Size(96, 17);
            this.toolStripStatusProcessingStep.Text = "Processing Step: ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(16, 386);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(109, 20);
            this.label19.TabIndex = 37;
            this.label19.Text = "Rules Options";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.cboLanguage);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtProximity);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtConfidence);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtMinMatches);
            this.panel3.Controls.Add(this.txtMaxMatches);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Location = new System.Drawing.Point(16, 409);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(227, 159);
            this.panel3.TabIndex = 38;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.actionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(958, 24);
            this.menuStrip1.TabIndex = 39;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createEDMSchemaToolStripMenuItem,
            this.createEDMRulePackToolStripMenuItem,
            this.uploadSchemaAndRulePackToolStripMenuItem,
            this.uploadDataFileToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 22);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // createEDMSchemaToolStripMenuItem
            // 
            this.createEDMSchemaToolStripMenuItem.Name = "createEDMSchemaToolStripMenuItem";
            this.createEDMSchemaToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.createEDMSchemaToolStripMenuItem.Text = "Create EDM Schema";
            this.createEDMSchemaToolStripMenuItem.Click += new System.EventHandler(this.createEDMSchemaToolStripMenuItem_Click);
            // 
            // createEDMRulePackToolStripMenuItem
            // 
            this.createEDMRulePackToolStripMenuItem.Name = "createEDMRulePackToolStripMenuItem";
            this.createEDMRulePackToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.createEDMRulePackToolStripMenuItem.Text = "Create EDM Rule Pack";
            this.createEDMRulePackToolStripMenuItem.Click += new System.EventHandler(this.createEDMRulePackToolStripMenuItem_Click);
            // 
            // uploadSchemaAndRulePackToolStripMenuItem
            // 
            this.uploadSchemaAndRulePackToolStripMenuItem.Name = "uploadSchemaAndRulePackToolStripMenuItem";
            this.uploadSchemaAndRulePackToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.uploadSchemaAndRulePackToolStripMenuItem.Text = "Upload Schema and Rule Pack";
            this.uploadSchemaAndRulePackToolStripMenuItem.Click += new System.EventHandler(this.uploadSchemaAndRulePackToolStripMenuItem_Click);
            // 
            // uploadDataFileToolStripMenuItem
            // 
            this.uploadDataFileToolStripMenuItem.Name = "uploadDataFileToolStripMenuItem";
            this.uploadDataFileToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.uploadDataFileToolStripMenuItem.Text = "Upload Data File";
            this.uploadDataFileToolStripMenuItem.Click += new System.EventHandler(this.uploadDataFileToolStripMenuItem_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(880, 139);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 13);
            this.label20.TabIndex = 37;
            this.label20.Text = "Required (*)";
            // 
            // frmEDM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 608);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtCustomInformationType);
            this.Controls.Add(this.lblPublisherName);
            this.Controls.Add(this.txtPublisherName);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgRules);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtDataStoreName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFileSelected);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmEDM";
            this.Text = "Exact Data Match Configuration";
            this.Load += new System.EventHandler(this.frmEDM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRules)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFileSelected;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDataStoreName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog dlgFile;
        private System.Windows.Forms.ComboBox cboLanguage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProximity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtConfidence;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgRules;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMinMatches;
        private System.Windows.Forms.TextBox txtMaxMatches;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblPublisherName;
        private System.Windows.Forms.TextBox txtPublisherName;
        private System.Windows.Forms.TextBox txtCustomInformationType;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn FieldName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Searchable;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Match;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox txtPassword;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusProcessingStep;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createEDMSchemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createEDMRulePackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadSchemaAndRulePackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadDataFileToolStripMenuItem;
        private System.Windows.Forms.Label label20;
    }
}

