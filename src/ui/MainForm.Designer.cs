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
      this.label6 = new System.Windows.Forms.Label();
      this.uiWallRemainingLength = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.uiWallSections = new System.Windows.Forms.ListBox();
      this.uiAddWallSection = new System.Windows.Forms.Button();
      this.label5 = new System.Windows.Forms.Label();
      this.uiWallTotalLength = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.uiWallSectionLength = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.uiSectionType = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.uiSetupWallSectionGroups = new System.Windows.Forms.Button();
      this.uiSave = new System.Windows.Forms.Button();
      this.groupBox2.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.uiSectionMoveDown);
      this.groupBox2.Controls.Add(this.uiSectionMoveUp);
      this.groupBox2.Controls.Add(this.uiRemoveWallSection);
      this.groupBox2.Controls.Add(this.label6);
      this.groupBox2.Controls.Add(this.uiWallRemainingLength);
      this.groupBox2.Controls.Add(this.label7);
      this.groupBox2.Controls.Add(this.uiWallSections);
      this.groupBox2.Controls.Add(this.uiAddWallSection);
      this.groupBox2.Controls.Add(this.label5);
      this.groupBox2.Controls.Add(this.uiWallTotalLength);
      this.groupBox2.Controls.Add(this.label4);
      this.groupBox2.Controls.Add(this.label3);
      this.groupBox2.Controls.Add(this.uiWallSectionLength);
      this.groupBox2.Controls.Add(this.label2);
      this.groupBox2.Controls.Add(this.uiSectionType);
      this.groupBox2.Controls.Add(this.label1);
      this.groupBox2.Location = new System.Drawing.Point(14, 119);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(715, 377);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Build up your wall\'s sections:";
      // 
      // uiSectionMoveDown
      // 
      this.uiSectionMoveDown.Location = new System.Drawing.Point(87, 266);
      this.uiSectionMoveDown.Name = "uiSectionMoveDown";
      this.uiSectionMoveDown.Size = new System.Drawing.Size(63, 24);
      this.uiSectionMoveDown.TabIndex = 15;
      this.uiSectionMoveDown.Text = "Down";
      this.uiSectionMoveDown.UseVisualStyleBackColor = true;
      this.uiSectionMoveDown.Click += new System.EventHandler(this.uiSectionMoveDown_Click);
      // 
      // uiSectionMoveUp
      // 
      this.uiSectionMoveUp.Location = new System.Drawing.Point(18, 267);
      this.uiSectionMoveUp.Name = "uiSectionMoveUp";
      this.uiSectionMoveUp.Size = new System.Drawing.Size(63, 24);
      this.uiSectionMoveUp.TabIndex = 14;
      this.uiSectionMoveUp.Text = "Up";
      this.uiSectionMoveUp.UseVisualStyleBackColor = true;
      this.uiSectionMoveUp.Click += new System.EventHandler(this.uiSectionMoveUp_Click);
      // 
      // uiRemoveWallSection
      // 
      this.uiRemoveWallSection.Location = new System.Drawing.Point(299, 267);
      this.uiRemoveWallSection.Name = "uiRemoveWallSection";
      this.uiRemoveWallSection.Size = new System.Drawing.Size(65, 23);
      this.uiRemoveWallSection.TabIndex = 13;
      this.uiRemoveWallSection.Text = "Remove";
      this.uiRemoveWallSection.UseVisualStyleBackColor = true;
      this.uiRemoveWallSection.Click += new System.EventHandler(this.uiRemoveWallSection_Click);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(225, 56);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(21, 13);
      this.label6.TabIndex = 12;
      this.label6.Text = "cm";
      // 
      // uiWallRemainingLength
      // 
      this.uiWallRemainingLength.Location = new System.Drawing.Point(117, 53);
      this.uiWallRemainingLength.Name = "uiWallRemainingLength";
      this.uiWallRemainingLength.ReadOnly = true;
      this.uiWallRemainingLength.Size = new System.Drawing.Size(105, 20);
      this.uiWallRemainingLength.TabIndex = 11;
      this.uiWallRemainingLength.TabStop = false;
      this.uiWallRemainingLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(15, 56);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(96, 13);
      this.label7.TabIndex = 10;
      this.label7.Text = "Used / Remaining:";
      // 
      // uiWallSections
      // 
      this.uiWallSections.FormattingEnabled = true;
      this.uiWallSections.Location = new System.Drawing.Point(18, 114);
      this.uiWallSections.Name = "uiWallSections";
      this.uiWallSections.Size = new System.Drawing.Size(346, 147);
      this.uiWallSections.TabIndex = 5;
      // 
      // uiAddWallSection
      // 
      this.uiAddWallSection.Location = new System.Drawing.Point(313, 82);
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
      this.label5.Location = new System.Drawing.Point(172, 30);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(21, 13);
      this.label5.TabIndex = 7;
      this.label5.Text = "cm";
      // 
      // uiWallTotalLength
      // 
      this.uiWallTotalLength.Location = new System.Drawing.Point(117, 27);
      this.uiWallTotalLength.Name = "uiWallTotalLength";
      this.uiWallTotalLength.Size = new System.Drawing.Size(49, 20);
      this.uiWallTotalLength.TabIndex = 1;
      this.uiWallTotalLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.uiWallTotalLength.TextChanged += new System.EventHandler(this.uiWallTotalLength_TextChanged);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(15, 30);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(87, 13);
      this.label4.TabIndex = 5;
      this.label4.Text = "Total wall length:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(283, 87);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(21, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "cm";
      // 
      // uiWallSectionLength
      // 
      this.uiWallSectionLength.Location = new System.Drawing.Point(228, 84);
      this.uiWallSectionLength.Name = "uiWallSectionLength";
      this.uiWallSectionLength.Size = new System.Drawing.Size(49, 20);
      this.uiWallSectionLength.TabIndex = 3;
      this.uiWallSectionLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.uiWallSectionLength.TextChanged += new System.EventHandler(this.uiWallSectionLength_TextChanged);
      this.uiWallSectionLength.Enter += new System.EventHandler(this.uiWallSectionLength_Enter);
      this.uiWallSectionLength.KeyDown += new System.Windows.Forms.KeyEventHandler(this.uiWallSectionLength_KeyDown);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(174, 87);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(48, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "of length";
      // 
      // uiSectionType
      // 
      this.uiSectionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.uiSectionType.FormattingEnabled = true;
      this.uiSectionType.Items.AddRange(new object[] {
            "Wall",
            "Window",
            "Door"});
      this.uiSectionType.Location = new System.Drawing.Point(74, 84);
      this.uiSectionType.Name = "uiSectionType";
      this.uiSectionType.Size = new System.Drawing.Size(94, 21);
      this.uiSectionType.TabIndex = 2;
      this.uiSectionType.TextChanged += new System.EventHandler(this.uiSectionType_TextChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(15, 87);
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
      this.groupBox1.Size = new System.Drawing.Size(222, 100);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Floor Plan:";
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
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(737, 504);
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
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.ComboBox uiSectionType;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox uiWallTotalLength;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox uiWallSectionLength;
    private System.Windows.Forms.Button uiAddWallSection;
    private System.Windows.Forms.ListBox uiWallSections;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox uiWallRemainingLength;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Button uiRemoveWallSection;
    private System.Windows.Forms.Button uiSectionMoveDown;
    private System.Windows.Forms.Button uiSectionMoveUp;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button uiSetupWallSectionGroups;
    private System.Windows.Forms.Button uiSave;
  }
}

