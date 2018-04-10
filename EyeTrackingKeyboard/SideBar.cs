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

    private Keyboard _keyboard = new Keyboard();
    private void SideBarLoad(object sender, EventArgs e)
    {
      Width = 80;
      var x = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
      var y = Screen.PrimaryScreen.WorkingArea.Height / 3;
      TopMost = true;
      Location = new Point(x, y);
      Opacity = 0.9;
      _keyboard.Show();
    }

    private void ButtonCloseClick(object sender, EventArgs e)
    {
      Environment.Exit(1);
    }

    private void ButtonToggleClick(object sender, EventArgs e)
    {
      if (_keyboard.Visible)
      {
        _keyboard.Hide();
      }
      else if (!_keyboard.Visible)
      {
        _keyboard.Show();
      } 
    }

    private int _flag;
    private void ButtonHideClick(object sender, EventArgs e)
    {
      if (_flag == 0)
      {
        var x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 60;
        var y = Screen.PrimaryScreen.WorkingArea.Height / 3;
        Location = new Point(x, y);
        _flag = 1;
      }
      else if (_flag == 1)
      {
        var x = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
        var y = Screen.PrimaryScreen.WorkingArea.Height / 3;
        Location = new Point(x, y);
        _flag = 0;
      }
    }

    double _opacity = .9;
    private void ButtonOpacityClick(object sender, EventArgs e)
    {
      _opacity = _opacity - .2;
      if (_opacity < .1)
      {
        _opacity = .9;
      }
      Opacity = _opacity;
      _keyboard.Opacity = _opacity;
    }
  }
}
