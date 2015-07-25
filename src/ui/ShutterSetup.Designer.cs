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
      this.uiBtnMoveUp = new System.Windows.Forms.Button();
      this.uiBtnMoveDown = new System.Windows.Forms.Button();
      this.uiBtnClose = new System.Windows.Forms.Button();
      this.uiBtnRemove = new System.Windows.Forms.Button();
      this.uiBtnAdd = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // uiLstShutters
      // 
      this.uiLstShutters.FormattingEnabled = true;
      this.uiLstShutters.Location = new System.Drawing.Point(12, 12);
      this.uiLstShutters.Name = "uiLstShutters";
      this.uiLstShutters.Size = new System.Drawing.Size(142, 225);
      this.uiLstShutters.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(160, 12);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(66, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Length (cm):";
      // 
      // uiTxtLength
      // 
      this.uiTxtLength.Location = new System.Drawing.Point(163, 28);
      this.uiTxtLength.Name = "uiTxtLength";
      this.uiTxtLength.Size = new System.Drawing.Size(80, 20);
      this.uiTxtLength.TabIndex = 0;
      // 
      // uiBtnMoveUp
      // 
      this.uiBtnMoveUp.Location = new System.Drawing.Point(163, 135);
      this.uiBtnMoveUp.Name = "uiBtnMoveUp";
      this.uiBtnMoveUp.Size = new System.Drawing.Size(83, 23);
      this.uiBtnMoveUp.TabIndex = 3;
      this.uiBtnMoveUp.Text = "Prioritise";
      this.uiBtnMoveUp.UseVisualStyleBackColor = true;
      this.uiBtnMoveUp.Click += new System.EventHandler(this.uiBtnMoveUp_Click);
      // 
      // uiBtnMoveDown
      // 
      this.uiBtnMoveDown.Location = new System.Drawing.Point(163, 164);
      this.uiBtnMoveDown.Name = "uiBtnMoveDown";
      this.uiBtnMoveDown.Size = new System.Drawing.Size(83, 23);
      this.uiBtnMoveDown.TabIndex = 4;
      this.uiBtnMoveDown.Text = "De-prioritise";
      this.uiBtnMoveDown.UseVisualStyleBackColor = true;
      this.uiBtnMoveDown.Click += new System.EventHandler(this.uiBtnMoveDown_Click);
      // 
      // uiBtnClose
      // 
      this.uiBtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.uiBtnClose.Location = new System.Drawing.Point(163, 214);
      this.uiBtnClose.Name = "uiBtnClose";
      this.uiBtnClose.Size = new System.Drawing.Size(83, 23);
      this.uiBtnClose.TabIndex = 5;
      this.uiBtnClose.Text = "Close";
      this.uiBtnClose.UseVisualStyleBackColor = true;
      this.uiBtnClose.Click += new System.EventHandler(this.uiBtnClose_Click);
      // 
      // uiBtnRemove
      // 
      this.uiBtnRemove.Location = new System.Drawing.Point(160, 89);
      this.uiBtnRemove.Name = "uiBtnRemove";
      this.uiBtnRemove.Size = new System.Drawing.Size(83, 23);
      this.uiBtnRemove.TabIndex = 2;
      this.uiBtnRemove.Text = "Remove";
      this.uiBtnRemove.UseVisualStyleBackColor = true;
      this.uiBtnRemove.Click += new System.EventHandler(this.uiBtnRemove_Click);
      // 
      // uiBtnAdd
      // 
      this.uiBtnAdd.Location = new System.Drawing.Point(160, 60);
      this.uiBtnAdd.Name = "uiBtnAdd";
      this.uiBtnAdd.Size = new System.Drawing.Size(83, 23);
      this.uiBtnAdd.TabIndex = 1;
      this.uiBtnAdd.Text = "Add";
      this.uiBtnAdd.UseVisualStyleBackColor = true;
      this.uiBtnAdd.Click += new System.EventHandler(this.uiBtnAdd_Click);
      // 
      // ShutterSetup
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.uiBtnClose;
      this.ClientSize = new System.Drawing.Size(258, 250);
      this.ControlBox = false;
      this.Controls.Add(this.uiBtnRemove);
      this.Controls.Add(this.uiBtnAdd);
      this.Controls.Add(this.uiBtnClose);
      this.Controls.Add(this.uiBtnMoveDown);
      this.Controls.Add(this.uiBtnMoveUp);
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
    private System.Windows.Forms.Button uiBtnMoveUp;
    private System.Windows.Forms.Button uiBtnMoveDown;
    private System.Windows.Forms.Button uiBtnClose;
    private System.Windows.Forms.Button uiBtnRemove;
    private System.Windows.Forms.Button uiBtnAdd;
  }
}