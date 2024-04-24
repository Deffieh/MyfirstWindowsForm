using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyfirstWindowsForm
{
  public partial class LoginPage : Form
  {
    public LoginPage()
    {
      InitializeComponent();
    }

    private void AccediBtn_Click(object sender, EventArgs e)
    {
      String UserId = UserBox.Text;
      String Password = PasswordBox.Text;
      Form2 f2 = new Form2();
      this.Hide();
      f2.Show(this);
      //if( UserId == "prova" && Password == "prova" ) {
      //}
      //else
      //{
      //  MessageBox.Show($"I DATI INSERITI SONO ERRATI:" +
      //    $"User: {UserId} " +
      //    $"\nPassword: {Password}");
      //}

    }

    private void ResetBtn_Click(object sender, EventArgs e)
    {
      UserBox.Clear();
      PasswordBox.Clear();
    }

    private void AccediTabBtn_Click(object sender, EventArgs e)
    {
      tabControl1.SelectTab(1);
    }

    private void LogoutTab2_Click(object sender, EventArgs e)
    {
      tabControl1.SelectTab(0);
    }
  }
}
