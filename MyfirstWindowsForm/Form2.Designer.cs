namespace MyfirstWindowsForm
{
  partial class Form2
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
      Logout = new Button();
      tabControl1 = new TabControl();
      tabPage1 = new TabPage();
      button1 = new Button();
      tabPage2 = new TabPage();
      tabControl1.SuspendLayout();
      tabPage1.SuspendLayout();
      SuspendLayout();
      // 
      // Logout
      // 
      Logout.Location = new Point(8, 335);
      Logout.Name = "Logout";
      Logout.Size = new Size(75, 23);
      Logout.TabIndex = 0;
      Logout.Text = "Logout";
      Logout.UseVisualStyleBackColor = true;
      Logout.Click += Logout_Click;
      // 
      // tabControl1
      // 
      tabControl1.Controls.Add(tabPage1);
      tabControl1.Controls.Add(tabPage2);
      tabControl1.Dock = DockStyle.Fill;
      tabControl1.Location = new Point(0, 0);
      tabControl1.Name = "tabControl1";
      tabControl1.SelectedIndex = 0;
      tabControl1.Size = new Size(782, 394);
      tabControl1.TabIndex = 1;
      // 
      // tabPage1
      // 
      tabPage1.Controls.Add(button1);
      tabPage1.Controls.Add(Logout);
      tabPage1.Location = new Point(4, 24);
      tabPage1.Name = "tabPage1";
      tabPage1.Padding = new Padding(3);
      tabPage1.Size = new Size(774, 366);
      tabPage1.TabIndex = 0;
      tabPage1.Text = "tabPage1";
      tabPage1.UseVisualStyleBackColor = true;
      // 
      // button1
      // 
      button1.Location = new Point(691, 335);
      button1.Name = "button1";
      button1.Size = new Size(75, 23);
      button1.TabIndex = 1;
      button1.Text = "next";
      button1.UseVisualStyleBackColor = true;
      // 
      // tabPage2
      // 
      tabPage2.Location = new Point(4, 24);
      tabPage2.Name = "tabPage2";
      tabPage2.Padding = new Padding(3);
      tabPage2.Size = new Size(774, 366);
      tabPage2.TabIndex = 1;
      tabPage2.Text = "tabPage2";
      tabPage2.UseVisualStyleBackColor = true;
      // 
      // Form2
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(782, 394);
      Controls.Add(tabControl1);
      Name = "Form2";
      StartPosition = FormStartPosition.CenterParent;
      Text = "Form2";
      tabControl1.ResumeLayout(false);
      tabPage1.ResumeLayout(false);
      ResumeLayout(false);
    }

    #endregion
    private Button Logout;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private Button button1;
  }
}