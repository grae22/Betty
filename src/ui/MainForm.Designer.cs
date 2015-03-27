namespace Betty
{
  partial class MainForm
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
      this.uiWallInfo = new System.Windows.Forms.GroupBox();
      this.uiWallName = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.uiTotalWallLength = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.uiSave = new System.Windows.Forms.Button();
      this.uiSetupWallSectionGroups = new System.Windows.Forms.Button();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.uiRemoveWall = new System.Windows.Forms.Button();
      this.uiAddWall = new System.Windows.Forms.Button();
      this.uiWalls = new System.Windows.Forms.ListBox();
      this.uiRemoveWallSection = new System.Windows.Forms.Button();
      this.uiWallFeatures = new System.Windows.Forms.ListBox();
      this.uiAddWallSection = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.uiSectionDistanceFromOrigin = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.uiFeatureType = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.uiWallInfo.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.SuspendLayout();
      // 
      // uiWallInfo
      // 
      this.uiWallInfo.Controls.Add(this.label7);
      this.uiWallInfo.Controls.Add(this.uiSetupWallSectionGroups);
      this.uiWallInfo.Controls.Add(this.uiRemoveWallSection);
      this.uiWallInfo.Controls.Add(this.uiWallFeatures);
      this.uiWallInfo.Controls.Add(this.uiAddWallSection);
      this.uiWallInfo.Controls.Add(this.label3);
      this.uiWallInfo.Controls.Add(this.uiSectionDistanceFromOrigin);
      this.uiWallInfo.Controls.Add(this.label2);
      this.uiWallInfo.Controls.Add(this.uiFeatureType);
      this.uiWallInfo.Controls.Add(this.label1);
      this.uiWallInfo.Controls.Add(this.uiWallName);
      this.uiWallInfo.Controls.Add(this.label6);
      this.uiWallInfo.Controls.Add(this.label5);
      this.uiWallInfo.Controls.Add(this.uiTotalWallLength);
      this.uiWallInfo.Controls.Add(this.label4);
      this.uiWallInfo.Location = new System.Drawing.Point(331, 115);
      this.uiWallInfo.Name = "uiWallInfo";
      this.uiWallInfo.Size = new System.Drawing.Size(384, 326);
      this.uiWallInfo.TabIndex = 1;
      this.uiWallInfo.TabStop = false;
      this.uiWallInfo.Text = "Wall Info:";
      // 
      // uiWallName
      // 
      this.uiWallName.Location = new System.Drawing.Point(59, 27);
      this.uiWallName.Name = "uiWallName";
      this.uiWallName.Size = new System.Drawing.Size(163, 20);
      this.uiWallName.TabIndex = 16;
      this.uiWallName.Click += new System.EventHandler(this.uiWallName_Click);
      this.uiWallName.Enter += new System.EventHandler(this.uiWallName_Enter);
      this.uiWallName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.uiWallName_KeyDown);
      this.uiWallName.Validating += new System.ComponentModel.CancelEventHandler(this.uiWallName_Validating);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(15, 30);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(38, 13);
      this.label6.TabIndex = 17;
      this.label6.Text = "Name:";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(343, 30);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(21, 13);
      this.label5.TabIndex = 7;
      this.label5.Text = "cm";
      // 
      // uiTotalWallLength
      // 
      this.uiTotalWallLength.Location = new System.Drawing.Point(281, 27);
      this.uiTotalWallLength.Name = "uiTotalWallLength";
      this.uiTotalWallLength.Size = new System.Drawing.Size(60, 20);
      this.uiTotalWallLength.TabIndex = 1;
      this.uiTotalWallLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.uiTotalWallLength.Click += new System.EventHandler(this.uiTotalWallLength_Click);
      this.uiTotalWallLength.TextChanged += new System.EventHandler(this.uiWallTotalLength_TextChanged);
      this.uiTotalWallLength.Enter += new System.EventHandler(this.uiTotalWallLength_Enter);
      this.uiTotalWallLength.KeyDown += new System.Windows.Forms.KeyEventHandler(this.uiTotalWallLength_KeyDown);
      this.uiTotalWallLength.Validating += new System.ComponentModel.CancelEventHandler(this.uiTotalWallLength_Validating);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(237, 30);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(34, 13);
      this.label4.TabIndex = 5;
      this.label4.Text = "TWL:";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.uiSave);
      this.groupBox1.Location = new System.Drawing.Point(14, 9);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(311, 100);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Floor Plan:";
      // 
      // uiSave
      // 
      this.uiSave.Location = new System.Drawing.Point(18, 31);
      this.uiSave.Name = "uiSave";
      this.uiSave.Size = new System.Drawing.Size(93, 23);
      this.uiSave.TabIndex = 1;
      this.uiSave.Text = "Save";
      this.uiSave.UseVisualStyleBackColor = true;
      this.uiSave.Click += new System.EventHandler(this.uiSave_Click);
      // 
      // uiSetupWallSectionGroups
      // 
      this.uiSetupWallSectionGroups.Location = new System.Drawing.Point(329, 96);
      this.uiSetupWallSectionGroups.Name = "uiSetupWallSectionGroups";
      this.uiSetupWallSectionGroups.Size = new System.Drawing.Size(35, 20);
      this.uiSetupWallSectionGroups.TabIndex = 0;
      this.uiSetupWallSectionGroups.Text = "...";
      this.uiSetupWallSectionGroups.UseVisualStyleBackColor = true;
      this.uiSetupWallSectionGroups.Click += new System.EventHandler(this.uiSetupWallSectionGroups_Click);
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.uiRemoveWall);
      this.groupBox3.Controls.Add(this.uiAddWall);
      this.groupBox3.Controls.Add(this.uiWalls);
      this.groupBox3.Location = new System.Drawing.Point(14, 115);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(311, 326);
      this.groupBox3.TabIndex = 3;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Walls:";
      // 
      // uiRemoveWall
      // 
      this.uiRemoveWall.Location = new System.Drawing.Point(228, 284);
      this.uiRemoveWall.Name = "uiRemoveWall";
      this.uiRemoveWall.Size = new System.Drawing.Size(63, 24);
      this.uiRemoveWall.TabIndex = 16;
      this.uiRemoveWall.Text = "Remove";
      this.uiRemoveWall.UseVisualStyleBackColor = true;
      // 
      // uiAddWall
      // 
      this.uiAddWall.Location = new System.Drawing.Point(159, 284);
      this.uiAddWall.Name = "uiAddWall";
      this.uiAddWall.Size = new System.Drawing.Size(63, 24);
      this.uiAddWall.TabIndex = 15;
      this.uiAddWall.Text = "Add";
      this.uiAddWall.UseVisualStyleBackColor = true;
      this.uiAddWall.Click += new System.EventHandler(this.uiAddWall_Click);
      // 
      // uiWalls
      // 
      this.uiWalls.FormattingEnabled = true;
      this.uiWalls.Location = new System.Drawing.Point(18, 27);
      this.uiWalls.Name = "uiWalls";
      this.uiWalls.Size = new System.Drawing.Size(273, 251);
      this.uiWalls.TabIndex = 0;
      this.uiWalls.SelectedIndexChanged += new System.EventHandler(this.uiWalls_SelectedIndexChanged);
      // 
      // uiRemoveWallSection
      // 
      this.uiRemoveWallSection.Location = new System.Drawing.Point(299, 125);
      this.uiRemoveWallSection.Name = "uiRemoveWallSection";
      this.uiRemoveWallSection.Size = new System.Drawing.Size(65, 23);
      this.uiRemoveWallSection.TabIndex = 25;
      this.uiRemoveWallSection.Text = "Remove";
      this.uiRemoveWallSection.UseVisualStyleBackColor = true;
      // 
      // uiWallFeatures
      // 
      this.uiWallFeatures.FormattingEnabled = true;
      this.uiWallFeatures.Location = new System.Drawing.Point(18, 157);
      this.uiWallFeatures.Name = "uiWallFeatures";
      this.uiWallFeatures.Size = new System.Drawing.Size(346, 147);
      this.uiWallFeatures.TabIndex = 24;
      // 
      // uiAddWallSection
      // 
      this.uiAddWallSection.Location = new System.Drawing.Point(240, 125);
      this.uiAddWallSection.Name = "uiAddWallSection";
      this.uiAddWallSection.Size = new System.Drawing.Size(51, 23);
      this.uiAddWallSection.TabIndex = 22;
      this.uiAddWallSection.Text = "Add";
      this.uiAddWallSection.UseVisualStyleBackColor = true;
      this.uiAddWallSection.Click += new System.EventHandler(this.uiAddWallSection_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(142, 130);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(21, 13);
      this.label3.TabIndex = 23;
      this.label3.Text = "cm";
      // 
      // uiSectionDistanceFromOrigin
      // 
      this.uiSectionDistanceFromOrigin.Location = new System.Drawing.Point(87, 125);
      this.uiSectionDistanceFromOrigin.Name = "uiSectionDistanceFromOrigin";
      this.uiSectionDistanceFromOrigin.Size = new System.Drawing.Size(49, 20);
      this.uiSectionDistanceFromOrigin.TabIndex = 21;
      this.uiSectionDistanceFromOrigin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.uiSectionDistanceFromOrigin.Click += new System.EventHandler(this.uiSectionDistanceFromOrigin_Click);
      this.uiSectionDistanceFromOrigin.Enter += new System.EventHandler(this.uiSectionDistanceFromOrigin_Enter);
      this.uiSectionDistanceFromOrigin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.uiSectionDistanceFromOrigin_KeyDown);
      this.uiSectionDistanceFromOrigin.Validating += new System.ComponentModel.CancelEventHandler(this.uiSectionDistanceFromOrigin_Validating);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(15, 130);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(32, 13);
      this.label2.TabIndex = 19;
      this.label2.Text = "DFO:";
      // 
      // uiFeatureType
      // 
      this.uiFeatureType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.uiFeatureType.FormattingEnabled = true;
      this.uiFeatureType.Location = new System.Drawing.Point(87, 95);
      this.uiFeatureType.Name = "uiFeatureType";
      this.uiFeatureType.Size = new System.Drawing.Size(236, 21);
      this.uiFeatureType.TabIndex = 20;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(15, 98);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(69, 13);
      this.label1.TabIndex = 18;
      this.label1.Text = "Feature type:";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
      this.label7.Location = new System.Drawing.Point(15, 70);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(97, 13);
      this.label7.TabIndex = 28;
      this.label7.Text = "Add Wall Features:";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(729, 453);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.uiWallInfo);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "MainForm";
      this.Padding = new System.Windows.Forms.Padding(5);
      this.Text = "Betty";
      this.uiWallInfo.ResumeLayout(false);
      this.uiWallInfo.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox3.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox uiWallInfo;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox uiTotalWallLength;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button uiSetupWallSectionGroups;
    private System.Windows.Forms.Button uiSave;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Button uiRemoveWall;
    private System.Windows.Forms.Button uiAddWall;
    private System.Windows.Forms.ListBox uiWalls;
    private System.Windows.Forms.TextBox uiWallName;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Button uiRemoveWallSection;
    private System.Windows.Forms.ListBox uiWallFeatures;
    private System.Windows.Forms.Button uiAddWallSection;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox uiSectionDistanceFromOrigin;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox uiFeatureType;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label7;
  }
}

