using System;
using System.Drawing;
using System.Windows.Forms;

namespace EyeTrackingKeyboard
{
  public partial class SideBar : Form
  {
    public SideBar()
    {
      InitializeComponent();
    }

    Keyboard form1 = new Keyboard();
    private void SideBar_Load(object sender, EventArgs e)
    {
      Width = 80;
      int x = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
      int y = Screen.PrimaryScreen.WorkingArea.Height / 3;
      TopMost = true;
      Location = new Point(x, y);
      Opacity = 0.9;
      form1.Show();
    }

    private void Button_Close_Click(object sender, EventArgs e)
    {
      Environment.Exit(1);
    }

    private void Button_Toggle_Click(object sender, EventArgs e)
    {
      if (form1.Visible)
      {
        form1.Hide();
      }
      else if (!form1.Visible)
      {
        form1.Show();
      } 
    }
    int flag = 0;
    private void Button_Hide_Click(object sender, EventArgs e)
    {
      if (flag == 0)
      {
        int x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 60;
        int y = Screen.PrimaryScreen.WorkingArea.Height / 3;
        Location = new Point(x, y);
        flag = 1;
      }
      else if (flag == 1)
      {
        int x = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
        int y = Screen.PrimaryScreen.WorkingArea.Height / 3;
        Location = new Point(x, y);
        flag = 0;
      }
    }

    double opacity = .9;
    private void Button_Opacity_Click(object sender, EventArgs e)
    {
      opacity = opacity - .2;
      if (opacity < .1)
      {
        opacity = .9;
      }

      Opacity = opacity;
      form1.Opacity = opacity;
    }
  }
}
