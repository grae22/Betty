namespace Betty
{
  partial class EditShutterDlg
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
      this.uiDescription = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.uiHeight = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.uiWidth = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.uiName = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.uiOk = new System.Windows.Forms.Button();
      this.uiCancel = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.uiDescription);
      this.groupBox1.Controls.Add(this.label6);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.uiHeight);
      this.groupBox1.Controls.Add(this.label5);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.uiWidth);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.uiName);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox1.Location = new System.Drawing.Point(5, 5);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(268, 141);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Shuter Info:";
      // 
      // uiDescription
      // 
      this.uiDescription.Location = new System.Drawing.Point(84, 106);
      this.uiDescription.Name = "uiDescription";
      this.uiDescription.ReadOnly = true;
      this.uiDescription.Size = new System.Drawing.Size(168, 20);
      this.uiDescription.TabIndex = 9;
      this.uiDescription.TabStop = false;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(15, 109);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(63, 13);
      this.label6.TabIndex = 8;
      this.label6.Text = "Description:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(155, 87);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(21, 13);
      this.label4.TabIndex = 7;
      this.label4.Text = "cm";
      // 
      // uiHeight
      // 
      this.uiHeight.Location = new System.Drawing.Point(84, 80);
      this.uiHeight.Name = "uiHeight";
      this.uiHeight.Size = new System.Drawing.Size(65, 20);
      this.uiHeight.TabIndex = 2;
      this.uiHeight.Text = "100";
      this.uiHeight.TextChanged += new System.EventHandler(this.uiHeight_TextChanged);
      this.uiHeight.Enter += new System.EventHandler(this.uiHeight_Enter);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(15, 83);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(41, 13);
      this.label5.TabIndex = 5;
      this.label5.Text = "Height:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(155, 61);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(21, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "cm";
      // 
      // uiWidth
      // 
      this.uiWidth.Location = new System.Drawing.Point(84, 54);
      this.uiWidth.Name = "uiWidth";
      this.uiWidth.Size = new System.Drawing.Size(65, 20);
      this.uiWidth.TabIndex = 1;
      this.uiWidth.Text = "100";
      this.uiWidth.TextChanged += new System.EventHandler(this.uiWidth_TextChanged);
      this.uiWidth.Enter += new System.EventHandler(this.uiWidth_Enter);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(15, 57);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(38, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Width:";
      // 
      // uiName
      // 
      this.uiName.Location = new System.Drawing.Point(84, 28);
      this.uiName.MaxLength = 30;
      this.uiName.Name = "uiName";
      this.uiName.Size = new System.Drawing.Size(94, 20);
      this.uiName.TabIndex = 0;
      this.uiName.Text = "Shutter";
      this.uiName.TextChanged += new System.EventHandler(this.uiName_TextChanged);
      this.uiName.Enter += new System.EventHandler(this.uiName_Enter);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(15, 31);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(38, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Name:";
      // 
      // uiOk
      // 
      this.uiOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.uiOk.Location = new System.Drawing.Point(203, 152);
      this.uiOk.Name = "uiOk";
      this.uiOk.Size = new System.Drawing.Size(70, 28);
      this.uiOk.TabIndex = 3;
      this.uiOk.Text = "OK";
      this.uiOk.UseVisualStyleBackColor = true;
      this.uiOk.Click += new System.EventHandler(this.uiOk_Click);
      // 
      // uiCancel
      // 
      this.uiCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.uiCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.uiCancel.Location = new System.Drawing.Point(127, 152);
      this.uiCancel.Name = "uiCancel";
      this.uiCancel.Size = new System.Drawing.Size(70, 28);
      this.uiCancel.TabIndex = 4;
      this.uiCancel.Text = "Cancel";
      this.uiCancel.UseVisualStyleBackColor = true;
      // 
      // EditShutterDlg
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.uiCancel;
      this.ClientSize = new System.Drawing.Size(278, 186);
      this.ControlBox = false;
      this.Controls.Add(this.uiCancel);
      this.Controls.Add(this.uiOk);
      this.Controls.Add(this.groupBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Name = "EditShutterDlg";
      this.Padding = new System.Windows.Forms.Padding(5, 5, 5, 40);
      this.ShowInTaskbar = false;
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Add/Edit Shutter";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button uiOk;
    private System.Windows.Forms.Button uiCancel;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox uiHeight;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox uiWidth;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox uiName;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox uiDescription;
    private System.Windows.Forms.Label label6;
  }
}