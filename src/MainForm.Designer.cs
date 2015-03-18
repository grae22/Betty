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
      this.uiShutters = new System.Windows.Forms.ListBox();
      this.uiAddShutter = new System.Windows.Forms.Button();
      this.uiRemoveShutter = new System.Windows.Forms.Button();
      this.uiLowerShutterPriority = new System.Windows.Forms.Button();
      this.uiRaiseShutterPriority = new System.Windows.Forms.Button();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.label1 = new System.Windows.Forms.Label();
      this.uiSectionType = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.uiWallSectionLength = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.uiWallTotalLength = new System.Windows.Forms.TextBox();
      this.uiAddWallSection = new System.Windows.Forms.Button();
      this.uiWallSections = new System.Windows.Forms.ListBox();
      this.label6 = new System.Windows.Forms.Label();
      this.uiWallRemainingLength = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.uiRaiseShutterPriority);
      this.groupBox1.Controls.Add(this.uiLowerShutterPriority);
      this.groupBox1.Controls.Add(this.uiRemoveShutter);
      this.groupBox1.Controls.Add(this.uiAddShutter);
      this.groupBox1.Controls.Add(this.uiShutters);
      this.groupBox1.Location = new System.Drawing.Point(14, 261);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(307, 180);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Add && Prioritise Shutters:";
      // 
      // uiShutters
      // 
      this.uiShutters.FormattingEnabled = true;
      this.uiShutters.Location = new System.Drawing.Point(18, 19);
      this.uiShutters.Name = "uiShutters";
      this.uiShutters.Size = new System.Drawing.Size(200, 147);
      this.uiShutters.TabIndex = 0;
      // 
      // uiAddShutter
      // 
      this.uiAddShutter.Location = new System.Drawing.Point(228, 19);
      this.uiAddShutter.Name = "uiAddShutter";
      this.uiAddShutter.Size = new System.Drawing.Size(63, 24);
      this.uiAddShutter.TabIndex = 1;
      this.uiAddShutter.Text = "Add";
      this.uiAddShutter.UseVisualStyleBackColor = true;
      this.uiAddShutter.Click += new System.EventHandler(this.uiAddShutter_Click);
      // 
      // uiRemoveShutter
      // 
      this.uiRemoveShutter.Location = new System.Drawing.Point(228, 49);
      this.uiRemoveShutter.Name = "uiRemoveShutter";
      this.uiRemoveShutter.Size = new System.Drawing.Size(63, 24);
      this.uiRemoveShutter.TabIndex = 2;
      this.uiRemoveShutter.Text = "Remove";
      this.uiRemoveShutter.UseVisualStyleBackColor = true;
      this.uiRemoveShutter.Click += new System.EventHandler(this.uiRemoveShutter_Click);
      // 
      // uiLowerShutterPriority
      // 
      this.uiLowerShutterPriority.Location = new System.Drawing.Point(228, 142);
      this.uiLowerShutterPriority.Name = "uiLowerShutterPriority";
      this.uiLowerShutterPriority.Size = new System.Drawing.Size(63, 24);
      this.uiLowerShutterPriority.TabIndex = 3;
      this.uiLowerShutterPriority.Text = "Down";
      this.uiLowerShutterPriority.UseVisualStyleBackColor = true;
      this.uiLowerShutterPriority.Click += new System.EventHandler(this.uiLowerShutterPriority_Click);
      // 
      // uiRaiseShutterPriority
      // 
      this.uiRaiseShutterPriority.Location = new System.Drawing.Point(228, 112);
      this.uiRaiseShutterPriority.Name = "uiRaiseShutterPriority";
      this.uiRaiseShutterPriority.Size = new System.Drawing.Size(63, 24);
      this.uiRaiseShutterPriority.TabIndex = 4;
      this.uiRaiseShutterPriority.Text = "Up";
      this.uiRaiseShutterPriority.UseVisualStyleBackColor = true;
      this.uiRaiseShutterPriority.Click += new System.EventHandler(this.uiRaiseShutterPriority_Click);
      // 
      // groupBox2
      // 
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
      this.groupBox2.Location = new System.Drawing.Point(14, 8);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(381, 247);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Build up your wall\'s sections:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(15, 60);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(53, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Section is";
      // 
      // uiSectionType
      // 
      this.uiSectionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.uiSectionType.FormattingEnabled = true;
      this.uiSectionType.Items.AddRange(new object[] {
            "Wall",
            "Window",
            "Door"});
      this.uiSectionType.Location = new System.Drawing.Point(74, 57);
      this.uiSectionType.Name = "uiSectionType";
      this.uiSectionType.Size = new System.Drawing.Size(94, 21);
      this.uiSectionType.TabIndex = 2;
      this.uiSectionType.TextChanged += new System.EventHandler(this.uiSectionType_TextChanged);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(174, 60);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(48, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "of length";
      // 
      // uiWallSectionLength
      // 
      this.uiWallSectionLength.Location = new System.Drawing.Point(228, 57);
      this.uiWallSectionLength.Name = "uiWallSectionLength";
      this.uiWallSectionLength.Size = new System.Drawing.Size(49, 20);
      this.uiWallSectionLength.TabIndex = 3;
      this.uiWallSectionLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.uiWallSectionLength.TextChanged += new System.EventHandler(this.uiWallSectionLength_TextChanged);
      this.uiWallSectionLength.Enter += new System.EventHandler(this.uiWallSectionLength_Enter);
      this.uiWallSectionLength.KeyDown += new System.Windows.Forms.KeyEventHandler(this.uiWallSectionLength_KeyDown);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(283, 60);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(21, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "cm";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(15, 30);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(66, 13);
      this.label4.TabIndex = 5;
      this.label4.Text = "Total length:";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(142, 30);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(21, 13);
      this.label5.TabIndex = 7;
      this.label5.Text = "cm";
      // 
      // uiWallTotalLength
      // 
      this.uiWallTotalLength.Location = new System.Drawing.Point(87, 27);
      this.uiWallTotalLength.Name = "uiWallTotalLength";
      this.uiWallTotalLength.Size = new System.Drawing.Size(49, 20);
      this.uiWallTotalLength.TabIndex = 1;
      this.uiWallTotalLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.uiWallTotalLength.TextChanged += new System.EventHandler(this.uiWallTotalLength_TextChanged);
      // 
      // uiAddWallSection
      // 
      this.uiAddWallSection.Location = new System.Drawing.Point(313, 55);
      this.uiAddWallSection.Name = "uiAddWallSection";
      this.uiAddWallSection.Size = new System.Drawing.Size(51, 23);
      this.uiAddWallSection.TabIndex = 4;
      this.uiAddWallSection.Text = "Add";
      this.uiAddWallSection.UseVisualStyleBackColor = true;
      this.uiAddWallSection.Click += new System.EventHandler(this.uiAddWallSection_Click);
      // 
      // uiWallSections
      // 
      this.uiWallSections.FormattingEnabled = true;
      this.uiWallSections.Location = new System.Drawing.Point(18, 94);
      this.uiWallSections.Name = "uiWallSections";
      this.uiWallSections.Size = new System.Drawing.Size(346, 134);
      this.uiWallSections.TabIndex = 5;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(341, 30);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(21, 13);
      this.label6.TabIndex = 12;
      this.label6.Text = "cm";
      // 
      // uiWallRemainingLength
      // 
      this.uiWallRemainingLength.Location = new System.Drawing.Point(286, 27);
      this.uiWallRemainingLength.Name = "uiWallRemainingLength";
      this.uiWallRemainingLength.ReadOnly = true;
      this.uiWallRemainingLength.Size = new System.Drawing.Size(49, 20);
      this.uiWallRemainingLength.TabIndex = 11;
      this.uiWallRemainingLength.TabStop = false;
      this.uiWallRemainingLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(188, 30);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(92, 13);
      this.label7.TabIndex = 10;
      this.label7.Text = "Remaining length:";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(411, 449);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Name = "MainForm";
      this.Padding = new System.Windows.Forms.Padding(5);
      this.Text = "Betty";
      this.groupBox1.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button uiRaiseShutterPriority;
    private System.Windows.Forms.Button uiLowerShutterPriority;
    private System.Windows.Forms.Button uiRemoveShutter;
    private System.Windows.Forms.Button uiAddShutter;
    private System.Windows.Forms.ListBox uiShutters;
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
  }
}

