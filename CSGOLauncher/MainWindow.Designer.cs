namespace CSGOLauncher
{
    partial class MainWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.llNATHowTo = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lPublicIP = new System.Windows.Forms.Label();
            this.lPrivateIP = new System.Windows.Forms.Label();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.tbMap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMapGroup = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbGameMode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbUseRcon = new System.Windows.Forms.CheckBox();
            this.cbUseConsole = new System.Windows.Forms.CheckBox();
            this.cbLanMode = new System.Windows.Forms.CheckBox();
            this.gbInfo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(157, 294);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Save && Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(43, 294);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(108, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // gbInfo
            // 
            this.gbInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInfo.Controls.Add(this.llNATHowTo);
            this.gbInfo.Controls.Add(this.tableLayoutPanel1);
            this.gbInfo.Location = new System.Drawing.Point(13, 13);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(252, 130);
            this.gbInfo.TabIndex = 2;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Info";
            // 
            // llNATHowTo
            // 
            this.llNATHowTo.AutoSize = true;
            this.llNATHowTo.Location = new System.Drawing.Point(6, 72);
            this.llNATHowTo.Name = "llNATHowTo";
            this.llNATHowTo.Size = new System.Drawing.Size(234, 13);
            this.llNATHowTo.TabIndex = 1;
            this.llNATHowTo.TabStop = true;
            this.llNATHowTo.Text = "Need help configuring your Router? Click here...";
            this.llNATHowTo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llNATHowTo_LinkClicked);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lPublicIP, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lPrivateIP, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(236, 50);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Public IP Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Private IP Address:";
            // 
            // lPublicIP
            // 
            this.lPublicIP.AutoSize = true;
            this.lPublicIP.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPublicIP.ForeColor = System.Drawing.Color.Firebrick;
            this.lPublicIP.Location = new System.Drawing.Point(121, 0);
            this.lPublicIP.Name = "lPublicIP";
            this.lPublicIP.Size = new System.Drawing.Size(77, 14);
            this.lPublicIP.TabIndex = 2;
            this.lPublicIP.Text = "Reading...";
            // 
            // lPrivateIP
            // 
            this.lPrivateIP.AutoSize = true;
            this.lPrivateIP.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPrivateIP.ForeColor = System.Drawing.Color.ForestGreen;
            this.lPrivateIP.Location = new System.Drawing.Point(121, 25);
            this.lPrivateIP.Name = "lPrivateIP";
            this.lPrivateIP.Size = new System.Drawing.Size(77, 14);
            this.lPrivateIP.TabIndex = 3;
            this.lPrivateIP.Text = "Reading...";
            // 
            // gbSettings
            // 
            this.gbSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSettings.Controls.Add(this.cbLanMode);
            this.gbSettings.Controls.Add(this.tbMap);
            this.gbSettings.Controls.Add(this.label5);
            this.gbSettings.Controls.Add(this.tbMapGroup);
            this.gbSettings.Controls.Add(this.label4);
            this.gbSettings.Controls.Add(this.cbbGameMode);
            this.gbSettings.Controls.Add(this.label3);
            this.gbSettings.Controls.Add(this.cbUseRcon);
            this.gbSettings.Controls.Add(this.cbUseConsole);
            this.gbSettings.Location = new System.Drawing.Point(13, 112);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(252, 176);
            this.gbSettings.TabIndex = 3;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Settings";
            // 
            // tbMap
            // 
            this.tbMap.Location = new System.Drawing.Point(83, 144);
            this.tbMap.Name = "tbMap";
            this.tbMap.Size = new System.Drawing.Size(121, 20);
            this.tbMap.TabIndex = 7;
            this.tbMap.TextChanged += new System.EventHandler(this.tbMap_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Map:";
            // 
            // tbMapGroup
            // 
            this.tbMapGroup.Location = new System.Drawing.Point(83, 118);
            this.tbMapGroup.Name = "tbMapGroup";
            this.tbMapGroup.Size = new System.Drawing.Size(121, 20);
            this.tbMapGroup.TabIndex = 5;
            this.tbMapGroup.Text = "mg_bomb_se";
            this.tbMapGroup.TextChanged += new System.EventHandler(this.tbMapGroup_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Map Group:";
            // 
            // cbbGameMode
            // 
            this.cbbGameMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGameMode.FormattingEnabled = true;
            this.cbbGameMode.Location = new System.Drawing.Point(83, 91);
            this.cbbGameMode.Name = "cbbGameMode";
            this.cbbGameMode.Size = new System.Drawing.Size(121, 21);
            this.cbbGameMode.TabIndex = 3;
            this.cbbGameMode.SelectedIndexChanged += new System.EventHandler(this.cbbGameMode_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Game Mode:";
            // 
            // cbUseRcon
            // 
            this.cbUseRcon.AutoSize = true;
            this.cbUseRcon.Location = new System.Drawing.Point(12, 42);
            this.cbUseRcon.Name = "cbUseRcon";
            this.cbUseRcon.Size = new System.Drawing.Size(142, 17);
            this.cbUseRcon.TabIndex = 1;
            this.cbUseRcon.Text = "Allow Rcon Connections";
            this.cbUseRcon.UseVisualStyleBackColor = true;
            this.cbUseRcon.CheckedChanged += new System.EventHandler(this.cbUseRcon_CheckedChanged);
            // 
            // cbUseConsole
            // 
            this.cbUseConsole.AutoSize = true;
            this.cbUseConsole.Location = new System.Drawing.Point(12, 19);
            this.cbUseConsole.Name = "cbUseConsole";
            this.cbUseConsole.Size = new System.Drawing.Size(120, 17);
            this.cbUseConsole.TabIndex = 0;
            this.cbUseConsole.Text = "Use Server Console";
            this.cbUseConsole.UseVisualStyleBackColor = true;
            this.cbUseConsole.CheckedChanged += new System.EventHandler(this.cbUseConsole_CheckedChanged);
            // 
            // cbLanMode
            // 
            this.cbLanMode.AutoSize = true;
            this.cbLanMode.Location = new System.Drawing.Point(12, 65);
            this.cbLanMode.Name = "cbLanMode";
            this.cbLanMode.Size = new System.Drawing.Size(173, 17);
            this.cbLanMode.TabIndex = 8;
            this.cbLanMode.Text = "Enable LAN Mode (no Internet)";
            this.cbLanMode.UseVisualStyleBackColor = true;
            this.cbLanMode.CheckedChanged += new System.EventHandler(this.cbLanMode_CheckedChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 329);
            this.Controls.Add(this.gbSettings);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Text = "[CS:GO] Server Launcher";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lPublicIP;
        private System.Windows.Forms.Label lPrivateIP;
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.CheckBox cbUseConsole;
        private System.Windows.Forms.CheckBox cbUseRcon;
        private System.Windows.Forms.ComboBox cbbGameMode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel llNATHowTo;
        private System.Windows.Forms.TextBox tbMap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMapGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbLanMode;
    }
}

