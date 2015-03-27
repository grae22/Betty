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
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.uiSectionMoveDown = new System.Windows.Forms.Button();
      this.uiSectionMoveUp = new System.Windows.Forms.Button();
      this.uiRemoveWallSection = new System.Windows.Forms.Button();
      this.uiWallSections = new System.Windows.Forms.ListBox();
      this.uiAddWallSection = new System.Windows.Forms.Button();
      this.label5 = new System.Windows.Forms.Label();
      this.uiTotalWallLength = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.uiSectionDistanceFromOrigin = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.uiSectionType = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.uiSave = new System.Windows.Forms.Button();
      this.uiSetupWallSectionGroups = new System.Windows.Forms.Button();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.uiWalls = new System.Windows.Forms.ListBox();
      this.uiAddWall = new System.Windows.Forms.Button();
      this.uiRemoveWall = new System.Windows.Forms.Button();
      this.uiWallName = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.groupBox2.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.uiWallName);
      this.groupBox2.Controls.Add(this.label6);
      this.groupBox2.Controls.Add(this.uiSectionMoveDown);
      this.groupBox2.Controls.Add(this.uiSectionMoveUp);
      this.groupBox2.Controls.Add(this.uiRemoveWallSection);
      this.groupBox2.Controls.Add(this.uiWallSections);
      this.groupBox2.Controls.Add(this.uiAddWallSection);
      this.groupBox2.Controls.Add(this.label5);
      this.groupBox2.Controls.Add(this.uiTotalWallLength);
      this.groupBox2.Controls.Add(this.label4);
      this.groupBox2.Controls.Add(this.label3);
      this.groupBox2.Controls.Add(this.uiSectionDistanceFromOrigin);
      this.groupBox2.Controls.Add(this.label2);
      this.groupBox2.Controls.Add(this.uiSectionType);
      this.groupBox2.Controls.Add(this.label1);
      this.groupBox2.Location = new System.Drawing.Point(331, 115);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(384, 326);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Wall Info:";
      // 
      // uiSectionMoveDown
      // 
      this.uiSectionMoveDown.Location = new System.Drawing.Point(87, 284);
      this.uiSectionMoveDown.Name = "uiSectionMoveDown";
      this.uiSectionMoveDown.Size = new System.Drawing.Size(63, 24);
      this.uiSectionMoveDown.TabIndex = 15;
      this.uiSectionMoveDown.Text = "Down";
      this.uiSectionMoveDown.UseVisualStyleBackColor = true;
      this.uiSectionMoveDown.Click += new System.EventHandler(this.uiSectionMoveDown_Click);
      // 
      // uiSectionMoveUp
      // 
      this.uiSectionMoveUp.Location = new System.Drawing.Point(18, 284);
      this.uiSectionMoveUp.Name = "uiSectionMoveUp";
      this.uiSectionMoveUp.Size = new System.Drawing.Size(63, 24);
      this.uiSectionMoveUp.TabIndex = 14;
      this.uiSectionMoveUp.Text = "Up";
      this.uiSectionMoveUp.UseVisualStyleBackColor = true;
      this.uiSectionMoveUp.Click += new System.EventHandler(this.uiSectionMoveUp_Click);
      // 
      // uiRemoveWallSection
      // 
      this.uiRemoveWallSection.Location = new System.Drawing.Point(299, 284);
      this.uiRemoveWallSection.Name = "uiRemoveWallSection";
      this.uiRemoveWallSection.Size = new System.Drawing.Size(65, 23);
      this.uiRemoveWallSection.TabIndex = 13;
      this.uiRemoveWallSection.Text = "Remove";
      this.uiRemoveWallSection.UseVisualStyleBackColor = true;
      this.uiRemoveWallSection.Click += new System.EventHandler(this.uiRemoveWallSection_Click);
      // 
      // uiWallSections
      // 
      this.uiWallSections.FormattingEnabled = true;
      this.uiWallSections.Location = new System.Drawing.Point(18, 131);
      this.uiWallSections.Name = "uiWallSections";
      this.uiWallSections.Size = new System.Drawing.Size(346, 147);
      this.uiWallSections.TabIndex = 5;
      // 
      // uiAddWallSection
      // 
      this.uiAddWallSection.Location = new System.Drawing.Point(313, 93);
      this.uiAddWallSection.Name = "uiAddWallSection";
      this.uiAddWallSection.Size = new System.Drawing.Size(51, 23);
      this.uiAddWallSection.TabIndex = 4;
      this.uiAddWallSection.Text = "Add";
      this.uiAddWallSection.UseVisualStyleBackColor = true;
      this.uiAddWallSection.Click += new System.EventHandler(this.uiAddWallSection_Click);
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
      this.uiTotalWallLength.TextChanged += new System.EventHandler(this.uiWallTotalLength_TextChanged);
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
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(279, 98);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(21, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "cm";
      // 
      // uiSectionDistanceFromOrigin
      // 
      this.uiSectionDistanceFromOrigin.Location = new System.Drawing.Point(228, 95);
      this.uiSectionDistanceFromOrigin.Name = "uiSectionDistanceFromOrigin";
      this.uiSectionDistanceFromOrigin.Size = new System.Drawing.Size(49, 20);
      this.uiSectionDistanceFromOrigin.TabIndex = 3;
      this.uiSectionDistanceFromOrigin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.uiSectionDistanceFromOrigin.TextChanged += new System.EventHandler(this.uiWallSectionLength_TextChanged);
      this.uiSectionDistanceFromOrigin.Enter += new System.EventHandler(this.uiWallSectionLength_Enter);
      this.uiSectionDistanceFromOrigin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.uiWallSectionLength_KeyDown);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(190, 98);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(32, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "DFO:";
      // 
      // uiSectionType
      // 
      this.uiSectionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.uiSectionType.FormattingEnabled = true;
      this.uiSectionType.Items.AddRange(new object[] {
            "Wall",
            "Window",
            "Door"});
      this.uiSectionType.Location = new System.Drawing.Point(74, 95);
      this.uiSectionType.Name = "uiSectionType";
      this.uiSectionType.Size = new System.Drawing.Size(94, 21);
      this.uiSectionType.TabIndex = 2;
      this.uiSectionType.TextChanged += new System.EventHandler(this.uiSectionType_TextChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(15, 98);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(53, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Section is";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.uiSave);
      this.groupBox1.Controls.Add(this.uiSetupWallSectionGroups);
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
      this.uiSetupWallSectionGroups.Location = new System.Drawing.Point(18, 60);
      this.uiSetupWallSectionGroups.Name = "uiSetupWallSectionGroups";
      this.uiSetupWallSectionGroups.Size = new System.Drawing.Size(93, 23);
      this.uiSetupWallSectionGroups.TabIndex = 0;
      this.uiSetupWallSectionGroups.Text = "Setup Groups";
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
      // uiWalls
      // 
      this.uiWalls.FormattingEnabled = true;
      this.uiWalls.Location = new System.Drawing.Point(18, 27);
      this.uiWalls.Name = "uiWalls";
      this.uiWalls.Size = new System.Drawing.Size(273, 251);
      this.uiWalls.TabIndex = 0;
      // 
      // uiAddWall
      // 
      this.uiAddWall.Location = new System.Drawing.Point(159, 284);
      this.uiAddWall.Name = "uiAddWall";
      this.uiAddWall.Size = new System.Drawing.Size(63, 24);
      this.uiAddWall.TabIndex = 15;
      this.uiAddWall.Text = "Add";
      this.uiAddWall.UseVisualStyleBackColor = true;
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
      // uiWallName
      // 
      this.uiWallName.Location = new System.Drawing.Point(59, 27);
      this.uiWallName.Name = "uiWallName";
      this.uiWallName.Size = new System.Drawing.Size(163, 20);
      this.uiWallName.TabIndex = 16;
      this.uiWallName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(734, 453);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.groupBox2);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "MainForm";
      this.Padding = new System.Windows.Forms.Padding(5);
      this.Text = "Betty";
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox3.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.ComboBox uiSectionType;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox uiTotalWallLength;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox uiSectionDistanceFromOrigin;
    private System.Windows.Forms.Button uiAddWallSection;
    private System.Windows.Forms.ListBox uiWallSections;
    private System.Windows.Forms.Button uiRemoveWallSection;
    private System.Windows.Forms.Button uiSectionMoveDown;
    private System.Windows.Forms.Button uiSectionMoveUp;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button uiSetupWallSectionGroups;
    private System.Windows.Forms.Button uiSave;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Button uiRemoveWall;
    private System.Windows.Forms.Button uiAddWall;
    private System.Windows.Forms.ListBox uiWalls;
    private System.Windows.Forms.TextBox uiWallName;
    private System.Windows.Forms.Label label6;
  }
}

