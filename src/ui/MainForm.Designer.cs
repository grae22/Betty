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
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.uiBtnShutters = new System.Windows.Forms.Button();
      this.uiSave = new System.Windows.Forms.Button();
      this.uiSetupWallSectionGroups = new System.Windows.Forms.Button();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.uiGrpWallFeatures = new System.Windows.Forms.GroupBox();
      this.uiBtnShutterCombination = new System.Windows.Forms.Button();
      this.uiFeatures = new System.Windows.Forms.ComboBox();
      this.label7 = new System.Windows.Forms.Label();
      this.uiRemoveWallFeature = new System.Windows.Forms.Button();
      this.uiWallFeatures = new System.Windows.Forms.ListBox();
      this.uiAddWallFeature = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.uiFeatureDistanceFromOrigin = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.uiFeatureType = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.uiWallInfo = new System.Windows.Forms.GroupBox();
      this.uiChkExternalWall = new System.Windows.Forms.CheckBox();
      this.uiWallName = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.uiTotalWallLength = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.uiRemoveWall = new System.Windows.Forms.Button();
      this.uiAddWall = new System.Windows.Forms.Button();
      this.uiWalls = new System.Windows.Forms.ListBox();
      this.groupBox1.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.uiGrpWallFeatures.SuspendLayout();
      this.uiWallInfo.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.uiBtnShutters);
      this.groupBox1.Controls.Add(this.uiSave);
      this.groupBox1.Controls.Add(this.uiSetupWallSectionGroups);
      this.groupBox1.Location = new System.Drawing.Point(14, 9);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(311, 71);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Floor Plan:";
      // 
      // uiBtnShutters
      // 
      this.uiBtnShutters.Location = new System.Drawing.Point(203, 31);
      this.uiBtnShutters.Name = "uiBtnShutters";
      this.uiBtnShutters.Size = new System.Drawing.Size(88, 23);
      this.uiBtnShutters.TabIndex = 27;
      this.uiBtnShutters.Text = "Shutters";
      this.uiBtnShutters.UseVisualStyleBackColor = true;
      this.uiBtnShutters.Click += new System.EventHandler(this.uiBtnShutters_Click);
      // 
      // uiSave
      // 
      this.uiSave.Location = new System.Drawing.Point(18, 31);
      this.uiSave.Name = "uiSave";
      this.uiSave.Size = new System.Drawing.Size(68, 23);
      this.uiSave.TabIndex = 1;
      this.uiSave.Text = "Save";
      this.uiSave.UseVisualStyleBackColor = true;
      this.uiSave.Click += new System.EventHandler(this.uiSave_Click);
      // 
      // uiSetupWallSectionGroups
      // 
      this.uiSetupWallSectionGroups.Location = new System.Drawing.Point(92, 31);
      this.uiSetupWallSectionGroups.Name = "uiSetupWallSectionGroups";
      this.uiSetupWallSectionGroups.Size = new System.Drawing.Size(105, 23);
      this.uiSetupWallSectionGroups.TabIndex = 26;
      this.uiSetupWallSectionGroups.Text = "Wall Features";
      this.uiSetupWallSectionGroups.UseVisualStyleBackColor = true;
      this.uiSetupWallSectionGroups.Click += new System.EventHandler(this.uiSetupWallFeatureTypes_Click);
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.uiGrpWallFeatures);
      this.groupBox3.Controls.Add(this.uiWallInfo);
      this.groupBox3.Controls.Add(this.uiRemoveWall);
      this.groupBox3.Controls.Add(this.uiAddWall);
      this.groupBox3.Controls.Add(this.uiWalls);
      this.groupBox3.Location = new System.Drawing.Point(14, 86);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(658, 460);
      this.groupBox3.TabIndex = 3;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Walls:";
      // 
      // uiGrpWallFeatures
      // 
      this.uiGrpWallFeatures.Controls.Add(this.uiBtnShutterCombination);
      this.uiGrpWallFeatures.Controls.Add(this.uiFeatures);
      this.uiGrpWallFeatures.Controls.Add(this.label7);
      this.uiGrpWallFeatures.Controls.Add(this.uiRemoveWallFeature);
      this.uiGrpWallFeatures.Controls.Add(this.uiWallFeatures);
      this.uiGrpWallFeatures.Controls.Add(this.uiAddWallFeature);
      this.uiGrpWallFeatures.Controls.Add(this.label3);
      this.uiGrpWallFeatures.Controls.Add(this.uiFeatureDistanceFromOrigin);
      this.uiGrpWallFeatures.Controls.Add(this.label2);
      this.uiGrpWallFeatures.Controls.Add(this.uiFeatureType);
      this.uiGrpWallFeatures.Controls.Add(this.label1);
      this.uiGrpWallFeatures.Location = new System.Drawing.Point(309, 106);
      this.uiGrpWallFeatures.Name = "uiGrpWallFeatures";
      this.uiGrpWallFeatures.Size = new System.Drawing.Size(331, 339);
      this.uiGrpWallFeatures.TabIndex = 18;
      this.uiGrpWallFeatures.TabStop = false;
      this.uiGrpWallFeatures.Text = "Features:";
      // 
      // uiBtnShutterCombination
      // 
      this.uiBtnShutterCombination.Location = new System.Drawing.Point(178, 302);
      this.uiBtnShutterCombination.Name = "uiBtnShutterCombination";
      this.uiBtnShutterCombination.Size = new System.Drawing.Size(129, 24);
      this.uiBtnShutterCombination.TabIndex = 37;
      this.uiBtnShutterCombination.Text = "Shutter Combination";
      this.uiBtnShutterCombination.UseVisualStyleBackColor = true;
      this.uiBtnShutterCombination.Click += new System.EventHandler(this.uiBtnShutterCombination_Click);
      // 
      // uiFeatures
      // 
      this.uiFeatures.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.uiFeatures.FormattingEnabled = true;
      this.uiFeatures.Location = new System.Drawing.Point(71, 52);
      this.uiFeatures.Name = "uiFeatures";
      this.uiFeatures.Size = new System.Drawing.Size(236, 21);
      this.uiFeatures.TabIndex = 36;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(15, 55);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(46, 13);
      this.label7.TabIndex = 35;
      this.label7.Text = "Feature:";
      // 
      // uiRemoveWallFeature
      // 
      this.uiRemoveWallFeature.Location = new System.Drawing.Point(251, 89);
      this.uiRemoveWallFeature.Name = "uiRemoveWallFeature";
      this.uiRemoveWallFeature.Size = new System.Drawing.Size(56, 23);
      this.uiRemoveWallFeature.TabIndex = 34;
      this.uiRemoveWallFeature.Text = "Remove";
      this.uiRemoveWallFeature.UseVisualStyleBackColor = true;
      this.uiRemoveWallFeature.Click += new System.EventHandler(this.uiRemoveWallFeature_Click);
      // 
      // uiWallFeatures
      // 
      this.uiWallFeatures.FormattingEnabled = true;
      this.uiWallFeatures.Location = new System.Drawing.Point(18, 123);
      this.uiWallFeatures.Name = "uiWallFeatures";
      this.uiWallFeatures.Size = new System.Drawing.Size(289, 173);
      this.uiWallFeatures.TabIndex = 33;
      // 
      // uiAddWallFeature
      // 
      this.uiAddWallFeature.Location = new System.Drawing.Point(189, 89);
      this.uiAddWallFeature.Name = "uiAddWallFeature";
      this.uiAddWallFeature.Size = new System.Drawing.Size(56, 23);
      this.uiAddWallFeature.TabIndex = 31;
      this.uiAddWallFeature.Text = "Add";
      this.uiAddWallFeature.UseVisualStyleBackColor = true;
      this.uiAddWallFeature.Click += new System.EventHandler(this.uiAddWallFeature_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(126, 95);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(21, 13);
      this.label3.TabIndex = 32;
      this.label3.Text = "cm";
      // 
      // uiFeatureDistanceFromOrigin
      // 
      this.uiFeatureDistanceFromOrigin.Location = new System.Drawing.Point(71, 92);
      this.uiFeatureDistanceFromOrigin.Name = "uiFeatureDistanceFromOrigin";
      this.uiFeatureDistanceFromOrigin.Size = new System.Drawing.Size(49, 20);
      this.uiFeatureDistanceFromOrigin.TabIndex = 30;
      this.uiFeatureDistanceFromOrigin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(15, 95);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(32, 13);
      this.label2.TabIndex = 28;
      this.label2.Text = "DFO:";
      // 
      // uiFeatureType
      // 
      this.uiFeatureType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.uiFeatureType.FormattingEnabled = true;
      this.uiFeatureType.Location = new System.Drawing.Point(71, 26);
      this.uiFeatureType.Name = "uiFeatureType";
      this.uiFeatureType.Size = new System.Drawing.Size(236, 21);
      this.uiFeatureType.TabIndex = 29;
      this.uiFeatureType.SelectedIndexChanged += new System.EventHandler(this.uiFeatureType_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(15, 28);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(34, 13);
      this.label1.TabIndex = 27;
      this.label1.Text = "Type:";
      // 
      // uiWallInfo
      // 
      this.uiWallInfo.Controls.Add(this.uiChkExternalWall);
      this.uiWallInfo.Controls.Add(this.uiWallName);
      this.uiWallInfo.Controls.Add(this.label6);
      this.uiWallInfo.Controls.Add(this.label5);
      this.uiWallInfo.Controls.Add(this.uiTotalWallLength);
      this.uiWallInfo.Controls.Add(this.label4);
      this.uiWallInfo.Location = new System.Drawing.Point(309, 21);
      this.uiWallInfo.Name = "uiWallInfo";
      this.uiWallInfo.Size = new System.Drawing.Size(331, 79);
      this.uiWallInfo.TabIndex = 17;
      this.uiWallInfo.TabStop = false;
      this.uiWallInfo.Text = "Info:";
      // 
      // uiChkExternalWall
      // 
      this.uiChkExternalWall.AutoSize = true;
      this.uiChkExternalWall.Location = new System.Drawing.Point(59, 53);
      this.uiChkExternalWall.Name = "uiChkExternalWall";
      this.uiChkExternalWall.Size = new System.Drawing.Size(88, 17);
      this.uiChkExternalWall.TabIndex = 38;
      this.uiChkExternalWall.Text = "External Wall";
      this.uiChkExternalWall.UseVisualStyleBackColor = true;
      // 
      // uiWallName
      // 
      this.uiWallName.Location = new System.Drawing.Point(59, 27);
      this.uiWallName.Name = "uiWallName";
      this.uiWallName.Size = new System.Drawing.Size(119, 20);
      this.uiWallName.TabIndex = 16;
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
      this.label5.Location = new System.Drawing.Point(295, 30);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(21, 13);
      this.label5.TabIndex = 7;
      this.label5.Text = "cm";
      // 
      // uiTotalWallLength
      // 
      this.uiTotalWallLength.Location = new System.Drawing.Point(233, 27);
      this.uiTotalWallLength.Name = "uiTotalWallLength";
      this.uiTotalWallLength.Size = new System.Drawing.Size(60, 20);
      this.uiTotalWallLength.TabIndex = 1;
      this.uiTotalWallLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.uiTotalWallLength.Validating += new System.ComponentModel.CancelEventHandler(this.uiTotalWallLength_Validating);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(193, 30);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(34, 13);
      this.label4.TabIndex = 5;
      this.label4.Text = "TWL:";
      // 
      // uiRemoveWall
      // 
      this.uiRemoveWall.Location = new System.Drawing.Point(228, 421);
      this.uiRemoveWall.Name = "uiRemoveWall";
      this.uiRemoveWall.Size = new System.Drawing.Size(63, 24);
      this.uiRemoveWall.TabIndex = 16;
      this.uiRemoveWall.Text = "Remove";
      this.uiRemoveWall.UseVisualStyleBackColor = true;
      // 
      // uiAddWall
      // 
      this.uiAddWall.Location = new System.Drawing.Point(159, 421);
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
      this.uiWalls.Size = new System.Drawing.Size(273, 381);
      this.uiWalls.TabIndex = 0;
      this.uiWalls.SelectedIndexChanged += new System.EventHandler(this.uiWalls_SelectedIndexChanged);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(680, 554);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "MainForm";
      this.Padding = new System.Windows.Forms.Padding(5);
      this.Text = "Betty";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
      this.groupBox1.ResumeLayout(false);
      this.groupBox3.ResumeLayout(false);
      this.uiGrpWallFeatures.ResumeLayout(false);
      this.uiGrpWallFeatures.PerformLayout();
      this.uiWallInfo.ResumeLayout(false);
      this.uiWallInfo.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button uiSave;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Button uiRemoveWall;
    private System.Windows.Forms.Button uiAddWall;
    private System.Windows.Forms.ListBox uiWalls;
    private System.Windows.Forms.Button uiSetupWallSectionGroups;
    private System.Windows.Forms.Button uiBtnShutters;
    private System.Windows.Forms.GroupBox uiGrpWallFeatures;
    private System.Windows.Forms.ComboBox uiFeatures;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Button uiRemoveWallFeature;
    private System.Windows.Forms.ListBox uiWallFeatures;
    private System.Windows.Forms.Button uiAddWallFeature;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox uiFeatureDistanceFromOrigin;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox uiFeatureType;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.GroupBox uiWallInfo;
    private System.Windows.Forms.CheckBox uiChkExternalWall;
    private System.Windows.Forms.TextBox uiWallName;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox uiTotalWallLength;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button uiBtnShutterCombination;
  }
}

