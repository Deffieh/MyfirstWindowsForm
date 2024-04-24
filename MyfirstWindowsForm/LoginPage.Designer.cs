namespace MyfirstWindowsForm
{
  partial class LoginPage
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
      label1 = new Label();
      UserBox = new TextBox();
      PasswordBox = new TextBox();
      label2 = new Label();
      AccediBtn = new Button();
      ResetBtn = new Button();
      tabControl1 = new TabControl();
      tabPage1 = new TabPage();
      AccediTabBtn = new Button();
      tabPage2 = new TabPage();
      LogoutTab2 = new Button();
      tabControl1.SuspendLayout();
      tabPage1.SuspendLayout();
      tabPage2.SuspendLayout();
      SuspendLayout();
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Cursor = Cursors.IBeam;
      label1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
      label1.Location = new Point(70, 45);
      label1.Name = "label1";
      label1.Size = new Size(120, 37);
      label1.TabIndex = 0;
      label1.Text = "User ID :";
      // 
      // UserBox
      // 
      UserBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      UserBox.Font = new Font("Segoe UI", 18F);
      UserBox.Location = new Point(221, 45);
      UserBox.Name = "UserBox";
      UserBox.Size = new Size(394, 39);
      UserBox.TabIndex = 1;
      // 
      // PasswordBox
      // 
      PasswordBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      PasswordBox.Font = new Font("Segoe UI", 18F);
      PasswordBox.Location = new Point(221, 118);
      PasswordBox.Name = "PasswordBox";
      PasswordBox.PasswordChar = '*';
      PasswordBox.Size = new Size(394, 39);
      PasswordBox.TabIndex = 3;
      PasswordBox.UseSystemPasswordChar = true;
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Cursor = Cursors.IBeam;
      label2.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
      label2.Location = new Point(70, 118);
      label2.Name = "label2";
      label2.Size = new Size(146, 37);
      label2.TabIndex = 2;
      label2.Text = "Password :";
      // 
      // AccediBtn
      // 
      AccediBtn.BackColor = Color.Green;
      AccediBtn.Cursor = Cursors.Hand;
      AccediBtn.FlatAppearance.BorderColor = Color.Black;
      AccediBtn.FlatAppearance.BorderSize = 10;
      AccediBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
      AccediBtn.ForeColor = Color.White;
      AccediBtn.Location = new Point(412, 187);
      AccediBtn.Name = "AccediBtn";
      AccediBtn.RightToLeft = RightToLeft.No;
      AccediBtn.Size = new Size(139, 62);
      AccediBtn.TabIndex = 4;
      AccediBtn.Text = "Accedi";
      AccediBtn.UseVisualStyleBackColor = false;
      AccediBtn.Click += AccediBtn_Click;
      // 
      // ResetBtn
      // 
      ResetBtn.BackColor = Color.DarkGoldenrod;
      ResetBtn.Cursor = Cursors.Hand;
      ResetBtn.FlatAppearance.BorderColor = Color.Black;
      ResetBtn.FlatAppearance.BorderSize = 10;
      ResetBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
      ResetBtn.ForeColor = Color.White;
      ResetBtn.Location = new Point(70, 187);
      ResetBtn.Name = "ResetBtn";
      ResetBtn.RightToLeft = RightToLeft.No;
      ResetBtn.Size = new Size(139, 62);
      ResetBtn.TabIndex = 5;
      ResetBtn.Text = "Reset";
      ResetBtn.UseVisualStyleBackColor = false;
      ResetBtn.Click += ResetBtn_Click;
      // 
      // tabControl1
      // 
      tabControl1.Controls.Add(tabPage1);
      tabControl1.Controls.Add(tabPage2);
      tabControl1.Dock = DockStyle.Fill;
      tabControl1.ItemSize = new Size(1, 1);
      tabControl1.Location = new Point(0, 0);
      tabControl1.Margin = new Padding(0);
      tabControl1.Name = "tabControl1";
      tabControl1.SelectedIndex = 0;
      tabControl1.Size = new Size(734, 392);
      tabControl1.SizeMode = TabSizeMode.Fixed;
      tabControl1.TabIndex = 2;
      // 
      // tabPage1
      // 
      tabPage1.Controls.Add(AccediTabBtn);
      tabPage1.Controls.Add(UserBox);
      tabPage1.Controls.Add(ResetBtn);
      tabPage1.Controls.Add(label1);
      tabPage1.Controls.Add(AccediBtn);
      tabPage1.Controls.Add(label2);
      tabPage1.Controls.Add(PasswordBox);
      tabPage1.Location = new Point(4, 5);
      tabPage1.Name = "tabPage1";
      tabPage1.Padding = new Padding(3);
      tabPage1.Size = new Size(726, 383);
      tabPage1.TabIndex = 0;
      tabPage1.Text = "tabPage1";
      tabPage1.UseVisualStyleBackColor = true;
      // 
      // AccediTabBtn
      // 
      AccediTabBtn.BackColor = Color.Green;
      AccediTabBtn.Cursor = Cursors.Hand;
      AccediTabBtn.FlatAppearance.BorderColor = Color.Black;
      AccediTabBtn.FlatAppearance.BorderSize = 10;
      AccediTabBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
      AccediTabBtn.ForeColor = Color.White;
      AccediTabBtn.Location = new Point(412, 266);
      AccediTabBtn.Name = "AccediTabBtn";
      AccediTabBtn.RightToLeft = RightToLeft.No;
      AccediTabBtn.Size = new Size(139, 62);
      AccediTabBtn.TabIndex = 6;
      AccediTabBtn.Text = "AccediTab";
      AccediTabBtn.UseVisualStyleBackColor = false;
      AccediTabBtn.Click += AccediTabBtn_Click;
      // 
      // tabPage2
      // 
      tabPage2.Controls.Add(LogoutTab2);
      tabPage2.Location = new Point(4, 5);
      tabPage2.Name = "tabPage2";
      tabPage2.Padding = new Padding(3);
      tabPage2.Size = new Size(726, 383);
      tabPage2.TabIndex = 1;
      tabPage2.Text = "tabPage2";
      tabPage2.UseVisualStyleBackColor = true;
      // 
      // LogoutTab2
      // 
      LogoutTab2.Location = new Point(236, 153);
      LogoutTab2.Name = "LogoutTab2";
      LogoutTab2.Size = new Size(144, 76);
      LogoutTab2.TabIndex = 0;
      LogoutTab2.Text = "LogoutTab2";
      LogoutTab2.UseVisualStyleBackColor = true;
      LogoutTab2.Click += LogoutTab2_Click;
      // 
      // LoginPage
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(734, 392);
      Controls.Add(tabControl1);
      FormBorderStyle = FormBorderStyle.None;
      Name = "LoginPage";
      StartPosition = FormStartPosition.CenterScreen;
      Text = "LoginPage";
      tabControl1.ResumeLayout(false);
      tabPage1.ResumeLayout(false);
      tabPage1.PerformLayout();
      tabPage2.ResumeLayout(false);
      ResumeLayout(false);
    }

    #endregion

    private Label label1;
    private TextBox UserBox;
    private TextBox PasswordBox;
    private Label label2;
    private Button AccediBtn;
    private Button ResetBtn;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private Button AccediTabBtn;
    private Button LogoutTab2;
  }
}