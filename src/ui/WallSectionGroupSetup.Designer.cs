namespace Betty
{
  partial class WallSectionGroupSetup
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
      this.uiGroupsAndSections = new System.Windows.Forms.TreeView();
      this.label1 = new System.Windows.Forms.Label();
      this.uiLength = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.uiUnit = new System.Windows.Forms.Label();
      this.uiHeight = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.uiAdd = new System.Windows.Forms.Button();
      this.uiRemove = new System.Windows.Forms.Button();
      this.uiPrioritise = new System.Windows.Forms.Button();
      this.uiDeprioritise = new System.Windows.Forms.Button();
      this.uiClose = new System.Windows.Forms.Button();
      this.uiGroupName = new System.Windows.Forms.ComboBox();
      this.SuspendLayout();
      // 
      // uiGroupsAndSections
      // 
      this.uiGroupsAndSections.HideSelection = false;
      this.uiGroupsAndSections.Location = new System.Drawing.Point(12, 12);
      this.uiGroupsAndSections.Name = "uiGroupsAndSections";
      this.uiGroupsAndSections.ShowPlusMinus = false;
      this.uiGroupsAndSections.ShowRootLines = false;
      this.uiGroupsAndSections.Size = new System.Drawing.Size(266, 452);
      this.uiGroupsAndSections.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(284, 12);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(70, 13);
      this.label1.TabIndex = 18;
      this.label1.Text = "Group Name:";
      // 
      // uiLength
      // 
      this.uiLength.Location = new System.Drawing.Point(287, 79);
      this.uiLength.Name = "uiLength";
      this.uiLength.Size = new System.Drawing.Size(67, 20);
      this.uiLength.TabIndex = 2;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(284, 63);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(82, 13);
      this.label2.TabIndex = 22;
      this.label2.Text = "Length x Height";
      // 
      // uiUnit
      // 
      this.uiUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.uiUnit.AutoSize = true;
      this.uiUnit.Location = new System.Drawing.Point(427, 63);
      this.uiUnit.Name = "uiUnit";
      this.uiUnit.Size = new System.Drawing.Size(21, 13);
      this.uiUnit.TabIndex = 24;
      this.uiUnit.Text = "cm";
      this.uiUnit.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // uiHeight
      // 
      this.uiHeight.Location = new System.Drawing.Point(381, 79);
      this.uiHeight.Name = "uiHeight";
      this.uiHeight.Size = new System.Drawing.Size(67, 20);
      this.uiHeight.TabIndex = 3;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(360, 82);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(12, 13);
      this.label3.TabIndex = 26;
      this.label3.Text = "x";
      // 
      // uiAdd
      // 
      this.uiAdd.Location = new System.Drawing.Point(330, 181);
      this.uiAdd.Name = "uiAdd";
      this.uiAdd.Size = new System.Drawing.Size(75, 23);
      this.uiAdd.TabIndex = 4;
      this.uiAdd.Text = "Add";
      this.uiAdd.UseVisualStyleBackColor = true;
      this.uiAdd.Click += new System.EventHandler(this.uiAdd_Click);
      // 
      // uiRemove
      // 
      this.uiRemove.Location = new System.Drawing.Point(330, 210);
      this.uiRemove.Name = "uiRemove";
      this.uiRemove.Size = new System.Drawing.Size(75, 23);
      this.uiRemove.TabIndex = 5;
      this.uiRemove.Text = "Remove";
      this.uiRemove.UseVisualStyleBackColor = true;
      this.uiRemove.Click += new System.EventHandler(this.uiRemove_Click);
      // 
      // uiPrioritise
      // 
      this.uiPrioritise.Location = new System.Drawing.Point(330, 239);
      this.uiPrioritise.Name = "uiPrioritise";
      this.uiPrioritise.Size = new System.Drawing.Size(75, 23);
      this.uiPrioritise.TabIndex = 6;
      this.uiPrioritise.Text = "Prioritise";
      this.uiPrioritise.UseVisualStyleBackColor = true;
      this.uiPrioritise.Click += new System.EventHandler(this.uiPrioritise_Click);
      // 
      // uiDeprioritise
      // 
      this.uiDeprioritise.Location = new System.Drawing.Point(330, 268);
      this.uiDeprioritise.Name = "uiDeprioritise";
      this.uiDeprioritise.Size = new System.Drawing.Size(75, 23);
      this.uiDeprioritise.TabIndex = 7;
      this.uiDeprioritise.Text = "Deprioritise";
      this.uiDeprioritise.UseVisualStyleBackColor = true;
      this.uiDeprioritise.Click += new System.EventHandler(this.uiDeprioritise_Click);
      // 
      // uiClose
      // 
      this.uiClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.uiClose.Location = new System.Drawing.Point(373, 440);
      this.uiClose.Name = "uiClose";
      this.uiClose.Size = new System.Drawing.Size(75, 23);
      this.uiClose.TabIndex = 8;
      this.uiClose.Text = "Close";
      this.uiClose.UseVisualStyleBackColor = true;
      // 
      // uiGroupName
      // 
      this.uiGroupName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
      this.uiGroupName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.uiGroupName.FormattingEnabled = true;
      this.uiGroupName.Location = new System.Drawing.Point(287, 29);
      this.uiGroupName.Name = "uiGroupName";
      this.uiGroupName.Size = new System.Drawing.Size(161, 21);
      this.uiGroupName.TabIndex = 1;
      // 
      // WallSectionGroupSetup
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.uiClose;
      this.ClientSize = new System.Drawing.Size(460, 475);
      this.ControlBox = false;
      this.Controls.Add(this.uiGroupName);
      this.Controls.Add(this.uiClose);
      this.Controls.Add(this.uiDeprioritise);
      this.Controls.Add(this.uiPrioritise);
      this.Controls.Add(this.uiRemove);
      this.Controls.Add(this.uiAdd);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.uiHeight);
      this.Controls.Add(this.uiUnit);
      this.Controls.Add(this.uiLength);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.uiGroupsAndSections);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Name = "WallSectionGroupSetup";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Wall Section Groups Setup";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TreeView uiGroupsAndSections;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox uiLength;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label uiUnit;
    private System.Windows.Forms.TextBox uiHeight;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button uiAdd;
    private System.Windows.Forms.Button uiRemove;
    private System.Windows.Forms.Button uiPrioritise;
    private System.Windows.Forms.Button uiDeprioritise;
    private System.Windows.Forms.Button uiClose;
    private System.Windows.Forms.ComboBox uiGroupName;
  }
}