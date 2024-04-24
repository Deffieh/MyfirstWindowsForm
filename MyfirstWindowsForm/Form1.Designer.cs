namespace MyfirstWindowsForm
{
  partial class Form1
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      button1 = new Button();
      button2 = new Button();
      label1 = new Label();
      inputField = new TextBox();
      SuspendLayout();
      // 
      // button1
      // 
      button1.Location = new Point(183, 171);
      button1.Name = "button1";
      button1.Size = new Size(75, 23);
      button1.TabIndex = 0;
      button1.Text = "Start";
      button1.UseVisualStyleBackColor = true;
      button1.Click += button1_Click;
      // 
      // button2
      // 
      button2.Location = new Point(20, 171);
      button2.Name = "button2";
      button2.Size = new Size(75, 23);
      button2.TabIndex = 0;
      button2.Text = "Cancel";
      button2.UseVisualStyleBackColor = true;
      button2.Click += button2_Click;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(63, 61);
      label1.Name = "label1";
      label1.Size = new Size(153, 15);
      label1.TabIndex = 1;
      label1.Text = "Trying to do cool thing here";
      // 
      // inputField
      // 
      inputField.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      inputField.BackColor = SystemColors.Info;
      inputField.Location = new Point(20, 101);
      inputField.Name = "inputField";
      inputField.Size = new Size(238, 23);
      inputField.TabIndex = 2;
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = SystemColors.ActiveCaption;
      ClientSize = new Size(284, 261);
      Controls.Add(inputField);
      Controls.Add(label1);
      Controls.Add(button1);
      Controls.Add(button2);
      MinimumSize = new Size(300, 300);
      Name = "Form1";
      Text = "Home";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Button button1;
    private Button button2;
    private Label label1;
    private TextBox inputField;
  }
}
