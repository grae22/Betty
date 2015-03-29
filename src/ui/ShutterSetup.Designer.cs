namespace Betty
{
  partial class ShutterSetup
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose( bool disposing )
    {
      if( disposing && ( components != null ) )
      {
        components.Dispose();
      }
      base.Dispose( disposing );
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.uiLstShutters = new System.Windows.Forms.ListBox();
      this.label1 = new System.Windows.Forms.Label();
      this.uiTxtLength = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.uiBtnMoveUp = new System.Windows.Forms.Button();
      this.uiBtnMoveDown = new System.Windows.Forms.Button();
      this.uiBtnClose = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // uiLstShutters
      // 
      this.uiLstShutters.FormattingEnabled = true;
      this.uiLstShutters.Location = new System.Drawing.Point(12, 12);
      this.uiLstShutters.Name = "uiLstShutters";
      this.uiLstShutters.Size = new System.Drawing.Size(142, 173);
      this.uiLstShutters.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(160, 12);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(43, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Length:";
      // 
      // uiTxtLength
      // 
      this.uiTxtLength.Location = new System.Drawing.Point(163, 28);
      this.uiTxtLength.Name = "uiTxtLength";
      this.uiTxtLength.Size = new System.Drawing.Size(71, 20);
      this.uiTxtLength.TabIndex = 2;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(235, 31);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(21, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "cm";
      // 
      // uiBtnMoveUp
      // 
      this.uiBtnMoveUp.Location = new System.Drawing.Point(163, 74);
      this.uiBtnMoveUp.Name = "uiBtnMoveUp";
      this.uiBtnMoveUp.Size = new System.Drawing.Size(71, 23);
      this.uiBtnMoveUp.TabIndex = 4;
      this.uiBtnMoveUp.Text = "Move Up";
      this.uiBtnMoveUp.UseVisualStyleBackColor = true;
      // 
      // uiBtnMoveDown
      // 
      this.uiBtnMoveDown.Location = new System.Drawing.Point(163, 103);
      this.uiBtnMoveDown.Name = "uiBtnMoveDown";
      this.uiBtnMoveDown.Size = new System.Drawing.Size(71, 23);
      this.uiBtnMoveDown.TabIndex = 5;
      this.uiBtnMoveDown.Text = "Move Down";
      this.uiBtnMoveDown.UseVisualStyleBackColor = true;
      // 
      // uiBtnClose
      // 
      this.uiBtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.uiBtnClose.Location = new System.Drawing.Point(163, 162);
      this.uiBtnClose.Name = "uiBtnClose";
      this.uiBtnClose.Size = new System.Drawing.Size(71, 23);
      this.uiBtnClose.TabIndex = 6;
      this.uiBtnClose.Text = "Close";
      this.uiBtnClose.UseVisualStyleBackColor = true;
      this.uiBtnClose.Click += new System.EventHandler(this.uiBtnClose_Click);
      // 
      // ShutterSetup
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.uiBtnClose;
      this.ClientSize = new System.Drawing.Size(264, 200);
      this.ControlBox = false;
      this.Controls.Add(this.uiBtnClose);
      this.Controls.Add(this.uiBtnMoveDown);
      this.Controls.Add(this.uiBtnMoveUp);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.uiTxtLength);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.uiLstShutters);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Name = "ShutterSetup";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Shutter Setup";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox uiLstShutters;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox uiTxtLength;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button uiBtnMoveUp;
    private System.Windows.Forms.Button uiBtnMoveDown;
    private System.Windows.Forms.Button uiBtnClose;
  }
}