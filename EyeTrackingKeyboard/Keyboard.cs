using System;
using System.Drawing;
using System.Windows.Forms;

/*Coords For the array of buttons
 * Q(0,0)    W   E   R   T   Y   U   I   O   P
 * A(1,0)    S   D   F   G   H   J   K   L   ;
 * Z(2,0)   X   C   V   B   N   M   ,   .   /(2,9)
 * 
 */
namespace EyeTrackingKeyboard
{
  public partial class Keyboard : Form
  {
    public int BHeight = 3;
    public int BWidth = 10;
    public Button[,] MyButtonArray;

    public Keyboard()
    {
      InitializeComponent();

      MyButtonArray = new[,]
      {
        {buttonQ, buttonW, buttonE, buttonR, buttonT, buttonY, buttonU, buttonI, buttonO, buttonP},
        {buttonA, buttonS, buttonD, buttonF, buttonG, buttonH, buttonJ, buttonK, buttonL, buttonColon},
        {
          buttonZ, buttonX, buttonC, buttonV, buttonB, buttonN, buttonM, buttonLessThen, buttonGreaterThen,
          buttonQuestionMarkSlash
        }
      };
    }

    protected override CreateParams CreateParams
    {
      get
      {
        var param = base.CreateParams;
        param.ExStyle |= 0x08000000;
        return param;
      }
    }

    private void ButtonQClick(object sender, EventArgs e)
    {
      if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
      {
        SendKeys.Send("Q");
        checkBoxLeftShift.Checked = false;
        checkBoxRightShift.Checked = false;
      }
      else
      {
        SendKeys.Send("q");
      }
    }

    private void SizeChangeNeighbor(int x, int y, int direction)
    {
      MyButtonArray[y, x].Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      MyButtonArray[y, x].BringToFront();
      MyButtonArray[y, x].Size = new Size(MyButtonArray[y, x].Size.Width + 25 * direction,
        MyButtonArray[y, x].Size.Height + 25 * direction);
      if (x - 1 >= 0) //left
      {
        MyButtonArray[y, x - 1].Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        MyButtonArray[y, x - 1].BringToFront();
        MyButtonArray[y, x - 1].Size = new Size(MyButtonArray[y, x - 1].Size.Width + 25 * direction,
          MyButtonArray[y, x - 1].Size.Height + 25 * direction);
        MyButtonArray[y, x - 1].Location = new Point(MyButtonArray[y, x - 1].Location.X - 25 * direction,
          MyButtonArray[y, x - 1].Location.Y);
      }

      if (x + 1 < BWidth) //right
      {
        MyButtonArray[y, x + 1].Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        MyButtonArray[y, x + 1].BringToFront();
        MyButtonArray[y, x + 1].Size = new Size(MyButtonArray[y, x + 1].Size.Width + 25 * direction,
          MyButtonArray[y, x + 1].Size.Height + 25 * direction);
        MyButtonArray[y, x + 1].Location = new Point(MyButtonArray[y, x + 1].Location.X + 25 * direction,
          MyButtonArray[y, x + 1].Location.Y);
      }

      if (y - 1 >= 0) //up
      {
        MyButtonArray[y - 1, x].Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        MyButtonArray[y - 1, x].BringToFront();
        MyButtonArray[y - 1, x].Size = new Size(MyButtonArray[y - 1, x].Size.Width + 25 * direction,
          MyButtonArray[y - 1, x].Size.Height + 25 * direction);
        MyButtonArray[y - 1, x].Location = new Point(MyButtonArray[y - 1, x].Location.X,
          MyButtonArray[y - 1, x].Location.Y - 25 * direction);
      }

      if (y + 1 < BHeight) //down
      {
        MyButtonArray[y + 1, x].Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        MyButtonArray[y + 1, x].BringToFront();
        MyButtonArray[y + 1, x].Size = new Size(MyButtonArray[y + 1, x].Size.Width + 25 * direction,
          MyButtonArray[y + 1, x].Size.Height + 25 * direction);
        MyButtonArray[y + 1, x].Location = new Point(MyButtonArray[y + 1, x].Location.X,
          MyButtonArray[y + 1, x].Location.Y + 25 * direction);
      }
    }

    private void ButtonQMouseEnter(object sender, EventArgs e)
    {
      var x = 0;
      var y = 0;
      SizeChangeNeighbor(x, y, 1);
    }

    private void ButtonQMouseLeave(object sender, EventArgs e)
    {
      var x = 0;
      var y = 0;
      SizeChangeNeighbor(x, y, -1);
    }

    private void ButtonWClick(object sender, EventArgs e)
    {
      if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
      {
        SendKeys.Send("W");
        checkBoxLeftShift.Checked = false;
        checkBoxRightShift.Checked = false;
      }
      else
      {
        SendKeys.Send("w");
      }
    }

    private void ButtonWMouseEnter(object sender, EventArgs e)
    {
      var x = 1;
      var y = 0;
      SizeChangeNeighbor(x, y, 1);
    }

    private void ButtonWMouseLeave(object sender, EventArgs e)
    {
      var x = 1;
      var y = 0;
      SizeChangeNeighbor(x, y, -1);
    }

    private void ButtonEClick(object sender, EventArgs e)
    {
      if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
      {
        SendKeys.Send("E");
        checkBoxLeftShift.Checked = false;
        checkBoxRightShift.Checked = false;
      }
      else
      {
        SendKeys.Send("e");
      }
    }

    private void ButtonEMouseEnter(object sender, EventArgs e)
    {
      var x = 2;
      var y = 0;
      SizeChangeNeighbor(x, y, 1);
    }

    private void ButtonEMouseLeave(object sender, EventArgs e)
    {
      var x = 2;
      var y = 0;
      SizeChangeNeighbor(x, y, -1);
    }

    private void ButtonRClick(object sender, EventArgs e)
    {
      if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
      {
        SendKeys.Send("R");
        checkBoxLeftShift.Checked = false;
        checkBoxRightShift.Checked = false;
      }
      else
      {
        SendKeys.Send("r");
      }
    }

    private void ButtonRMouseEnter(object sender, EventArgs e)
    {
      var x = 3;
      var y = 0;
      SizeChangeNeighbor(x, y, 1);
    }

    private void ButtonRMouseLeave(object sender, EventArgs e)
    {
      var x = 3;
      var y = 0;
      SizeChangeNeighbor(x, y, -1);
    }

    private void ButtonTClick(object sender, EventArgs e)
    {
      if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
      {
        SendKeys.Send("T");
        checkBoxLeftShift.Checked = false;
        checkBoxRightShift.Checked = false;
      }
      else
      {
        SendKeys.Send("t");
      }
    }

    private void ButtonTMouseEnter(object sender, EventArgs e)
    {
      var x = 4;
      var y = 0;
      SizeChangeNeighbor(x, y, 1);
    }

    private void ButtonTMouseLeave(object sender, EventArgs e)
    {
      var x = 4;
      var y = 0;
      SizeChangeNeighbor(x, y, -1);
    }

    private void ButtonYClick(object sender, EventArgs e)
    {
      if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
      {
        SendKeys.Send("Y");
        checkBoxLeftShift.Checked = false;
        checkBoxRightShift.Checked = false;
      }
      else
      {
        SendKeys.Send("y");
      }
    }

    private void ButtonYMouseEnter(object sender, EventArgs e)
    {
      var x = 5;
      var y = 0;
      SizeChangeNeighbor(x, y, 1);
    }

    private void ButtonYMouseLeave(object sender, EventArgs e)
    {
      var x = 5;
      var y = 0;
      SizeChangeNeighbor(x, y, -1);
    }

    private void ButtonUClick(object sender, EventArgs e)
    {
      if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
      {
        SendKeys.Send("U");
        checkBoxLeftShift.Checked = false;
        checkBoxRightShift.Checked = false;
      }
      else
      {
        SendKeys.Send("u");
      }
    }

    private void ButtonUMouseEnter(object sender, EventArgs e)
    {
      var x = 6;
      var y = 0;
      SizeChangeNeighbor(x, y, 1);
    }

    private void ButtonUMouseLeave(object sender, EventArgs e)
    {
      var x = 6;
      var y = 0;
      SizeChangeNeighbor(x, y, -1);
    }

    private void ButtonIClick(object sender, EventArgs e)
    {
      if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
      {
        SendKeys.Send("I");
        checkBoxLeftShift.Checked = false;
        checkBoxRightShift.Checked = false;
      }
      else
      {
        SendKeys.Send("i");
      }
    }

    private void ButtonIMouseEnter(object sender, EventArgs e)
    {
      var x = 7;
      var y = 0;
      SizeChangeNeighbor(x, y, 1);
    }

    private void ButtonIMouseLeave(object sender, EventArgs e)
    {
      var x = 7;
      var y = 0;
      SizeChangeNeighbor(x, y, -1);
    }

    private void ButtonOClick(object sender, EventArgs e)
    {
      if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
      {
        SendKeys.Send("O");
        checkBoxLeftShift.Checked = false;
        checkBoxRightShift.Checked = false;
      }
      else
      {
        SendKeys.Send("o");
      }
    }

    private void ButtonOMouseEnter(object sender, EventArgs e)
    {
      var x = 8;
      var y = 0;
      SizeChangeNeighbor(x, y, 1);
    }

    private void ButtonOMouseLeave(object sender, EventArgs e)
    {
      var x = 8;
      var y = 0;
      SizeChangeNeighbor(x, y, -1);
    }

    private void ButtonPClick(object sender, EventArgs e)
    {
      if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
      {
        SendKeys.Send("P");
        checkBoxLeftShift.Checked = false;
        checkBoxRightShift.Checked = false;
      }
      else
      {
        SendKeys.Send("p");
      }
    }

    private void ButtonPMouseEnter(object sender, EventArgs e)
    {
      var x = 9;
      var y = 0;
      SizeChangeNeighbor(x, y, 1);
    }

    private void ButtonPMouseLeave(object sender, EventArgs e)
    {
      var x = 9;
      var y = 0;
      SizeChangeNeighbor(x, y, -1);
    }

    private void ButtonAClick(object sender, EventArgs e)
    {
      if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
      {
        SendKeys.Send("A");
        checkBoxLeftShift.Checked = false;
        checkBoxRightShift.Checked = false;
      }
      else
      {
        SendKeys.Send("a");
      }
    }

    private void ButtonAMouseEnter(object sender, EventArgs e)
    {
      var x = 0;
      var y = 1;
      SizeChangeNeighbor(x, y, 1);
    }

    private void ButtonAMouseLeave(object sender, EventArgs e)
    {
      var x = 0;
      var y = 1;
      SizeChangeNeighbor(x, y, -1);
    }

    private void ButtonSClick(object sender, EventArgs e)
    {
      if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
      {
        SendKeys.Send("S");
        checkBoxLeftShift.Checked = false;
        checkBoxRightShift.Checked = false;
      }
      else
      {
        SendKeys.Send("s");
      }
    }

    private void ButtonSMouseEnter(object sender, EventArgs e)
    {
      var x = 1;
      var y = 1;
      SizeChangeNeighbor(x, y, 1);
    }

    private void ButtonSMouseLeave(object sender, EventArgs e)
    {
      var x = 1;
      var y = 1;
      SizeChangeNeighbor(x, y, -1);
    }

    private void ButtonFClick(object sender, EventArgs e)
    {
      if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
      {
        SendKeys.Send("F");
        checkBoxLeftShift.Checked = false;
        checkBoxRightShift.Checked = false;
      }
      else
      {
        SendKeys.Send("f");
      }
    }

    private void ButtonFMouseEnter(object sender, EventArgs e)
    {
      var x = 3;
      var y = 1;
      SizeChangeNeighbor(x, y, 1);
    }

    private void ButtonFMouseLeave(object sender, EventArgs e)
    {
      var x = 3;
      var y = 1;
      SizeChangeNeighbor(x, y, -1);
    }

    private void ButtonGClick(object sender, EventArgs e)
    {
      if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
      {
        SendKeys.Send("G");
        checkBoxLeftShift.Checked = false;
        checkBoxRightShift.Checked = false;
      }
      else
      {
        SendKeys.Send("g");
      }
    }

    private void ButtonGMouseEnter(object sender, EventArgs e)
    {
      var x = 4;
      var y = 1;
      SizeChangeNeighbor(x, y, 1);
    }

    private void ButtonGMouseLeave(object sender, EventArgs e)
    {
      var x = 4;
      var y = 1;
      SizeChangeNeighbor(x, y, -1);
    }

    private void ButtonHClick(object sender, EventArgs e)
    {
      if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
      {
        SendKeys.Send("H");
        checkBoxLeftShift.Checked = false;
        checkBoxRightShift.Checked = false;
      }
      else
      {
        SendKeys.Send("h");
      }
    }

    private void ButtonHMouseEnter(object sender, EventArgs e)
    {
      var x = 5;
      var y = 1;
      SizeChangeNeighbor(x, y, 1);
    }

    private void ButtonHMouseLeave(object sender, EventArgs e)
    {
      var x = 5;
      var y = 1;
      SizeChangeNeighbor(x, y, -1);
    }

    private void ButtonJClick(object sender, EventArgs e)
    {
      if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
      {
        SendKeys.Send("J");
        checkBoxLeftShift.Checked = false;
        checkBoxRightShift.Checked = false;
      }
      else
      {
        SendKeys.Send("j");
      }
    }

    private void ButtonJMouseEnter(object sender, EventArgs e)
    {
      var x = 6;
      var y = 1;
      SizeChangeNeighbor(x, y, 1);
    }

    private void ButtonJMouseLeave(object sender, EventArgs e)
    {
      var x = 6;
      var y = 1;
      SizeChangeNeighbor(x, y, -1);
    }

    private void ButtonKClick(object sender, EventArgs e)
    {
      if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
      {
        SendKeys.Send("K");
        checkBoxLeftShift.Checked = false;
        checkBoxRightShift.Checked = false;
      }
      else
      {
        SendKeys.Send("k");
      }
    }

    private void ButtonKMouseEnter(object sender, EventArgs e)
    {
      var x = 7;
      var y = 1;
      SizeChangeNeighbor(x, y, 1);
    }

    private void ButtonKMouseLeave(object sender, EventArgs e)
    {
      var x = 7;
      var y = 1;
      SizeChangeNeighbor(x, y, -1);
    }

    private void ButtonLClick(object sender, EventArgs e)
    {
      if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
      {
        SendKeys.Send("L");
        checkBoxLeftShift.Checked = false;
        checkBoxRightShift.Checked = false;
      }
      else
      {
        SendKeys.Send("l");
      }
    }

    private void ButtonLMouseEnter(object sender, EventArgs e)
    {
      var x = 8;
      var y = 1;
      SizeChangeNeighbor(x, y, 1);
    }

    private void ButtonLMouseLeave(object sender, EventArgs e)
    {
      var x = 8;
      var y = 1;
      SizeChangeNeighbor(x, y, -1);
    }

    private void ButtonZClick(object sender, EventArgs e)
    {
      if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
      {
        SendKeys.Send("Z");
        checkBoxLeftShift.Checked = false;
        checkBoxRightShift.Checked = false;
      }
      else
      {
        SendKeys.Send("z");
      }
    }

    private void ButtonZMouseEnter(object sender, EventArgs e)
    {
      var x = 0;
      var y = 2;
      SizeChangeNeighbor(x, y, 1);
    }

    private void ButtonZMouseLeave(object sender, EventArgs e)
    {
      var x = 0;
      var y = 2;
      SizeChangeNeighbor(x, y, -1);
    }

    private void ButtonXClick(object sender, EventArgs e)
    {
      if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
      {
        SendKeys.Send("X");
        checkBoxLeftShift.Checked = false;
        checkBoxRightShift.Checked = false;
      }
      else
      {
        SendKeys.Send("x");
      }
    }

    private void ButtonXMouseEnter(object sender, EventArgs e)
    {
      var x = 1;
      var y = 2;
      SizeChangeNeighbor(x, y, 1);
    }

    private void ButtonXMouseLeave(object sender, EventArgs e)
    {
      var x = 1;
      var y = 2;
      SizeChangeNeighbor(x, y, -1);
    }

    private void ButtonCClick(object sender, EventArgs e)
    {
      if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
      {
        SendKeys.Send("C");
        checkBoxLeftShift.Checked = false;
        checkBoxRightShift.Checked = false;
      }
      else
      {
        SendKeys.Send("c");
      }
    }

    private void ButtonCMouseEnter(object sender, EventArgs e)
    {
      var x = 2;
      var y = 2;
      SizeChangeNeighbor(x, y, 1);
    }

    private void ButtonCMouseLeave(object sender, EventArgs e)
    {
      var x = 2;
      var y = 2;
      SizeChangeNeighbor(x, y, -1);
    }

    private void ButtonVClick(object sender, EventArgs e)
    {
      if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
      {
        SendKeys.Send("V");
        checkBoxLeftShift.Checked = false;
        checkBoxRightShift.Checked = false;
      }
      else
      {
        SendKeys.Send("v");
      }
    }

    private void ButtonVMouseEnter(object sender, EventArgs e)
    {
      var x = 3;
      var y = 2;
      SizeChangeNeighbor(x, y, 1);
    }

    private void ButtonVMouseLeave(object sender, EventArgs e)
    {
      var x = 3;
      var y = 2;
      SizeChangeNeighbor(x, y, -1);
    }

    private void ButtonBClick(object sender, EventArgs e)
    {
      if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
      {
        SendKeys.Send("B");
        checkBoxLeftShift.Checked = false;
        checkBoxRightShift.Checked = false;
      }
      else
      {
        SendKeys.Send("b");
      }
    }

    private void ButtonBMouseEnter(object sender, EventArgs e)
    {
      var x = 4;
      var y = 2;
      SizeChangeNeighbor(x, y, 1);
    }

    private void ButtonBMouseLeave(object sender, EventArgs e)
    {
      var x = 4;
      var y = 2;
      SizeChangeNeighbor(x, y, -1);
    }

    private void ButtonNClick(object sender, EventArgs e)
    {
      if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
      {
        SendKeys.Send("N");
        checkBoxLeftShift.Checked = false;
        checkBoxRightShift.Checked = false;
      }
      else
      {
        SendKeys.Send("n");
      }
    }

    private void ButtonNMouseEnter(object sender, EventArgs e)
    {
      var x = 5;
      var y = 2;
      SizeChangeNeighbor(x, y, 1);
    }

    private void ButtonNMouseLeave(object sender, EventArgs e)
    {
      var x = 5;
      var y = 2;
      SizeChangeNeighbor(x, y, -1);
    }

    private void ButtonMClick(object sender, EventArgs e)
    {
      if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
      {
        SendKeys.Send("M");
        checkBoxLeftShift.Checked = false;
        checkBoxRightShift.Checked = false;
      }
      else
      {
        SendKeys.Send("m");
      }
    }

    private void ButtonMMouseEnter(object sender, EventArgs e)
    {
      var x = 6;
      var y = 2;
      SizeChangeNeighbor(x, y, 1);
    }

    private void ButtonMMouseLeave(object sender, EventArgs e)
    {
      var x = 6;
      var y = 2;
      SizeChangeNeighbor(x, y, -1);
    }

    private void ButtonDClick(object sender, EventArgs e)
    {
      if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
      {
        SendKeys.Send("D");
        checkBoxLeftShift.Checked = false;
        checkBoxRightShift.Checked = false;
      }
      else
      {
        SendKeys.Send("d");
      }
    }

    private void ButtonDMouseEnter(object sender, EventArgs e)
    {
      var x = 2;
      var y = 1;
      SizeChangeNeighbor(x, y, 1);
    }

    private void ButtonDMouseLeave(object sender, EventArgs e)
    {
      var x = 2;
      var y = 1;
      SizeChangeNeighbor(x, y, -1);
    }

    private void ButtonCurlyBracketOpenClick(object sender, EventArgs e)
    {
      if (checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
      {
        SendKeys.Send("{{}");
        checkBoxLeftShift.Checked = false;
        checkBoxRightShift.Checked = false;
      }
      else
      {
        SendKeys.Send("[");
      }
    }

    private void ButtonCurlyBracketCloseClick(object sender, EventArgs e)
    {
      if (checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
      {
        SendKeys.Send("{}}");
        checkBoxLeftShift.Checked = false;
        checkBoxRightShift.Checked = false;
      }
      else
      {
        SendKeys.Send("]");
      }
    }

    //
    //Implementation of Enter, esc, Fs
    //
    private void ButtonEnterClick(object sender, EventArgs e)
    {
      SendKeys.Send("{ENTER}");
    }

    private void ButtonEscClick(object sender, EventArgs e)
    {
      SendKeys.Send("{ESC}");
    }

    //setting up all function keys
    private void ButtonF1Click(object sender, EventArgs e)
    {
      SendKeys.Send("{F1}");
    }

    private void ButtonF2Click(object sender, EventArgs e)
    {
      SendKeys.Send("{F2}");
    }

    private void ButtonF3Click(object sender, EventArgs e)
    {
      SendKeys.Send("{F3}");
    }

    private void ButtonF4Click(object sender, EventArgs e)
    {
      SendKeys.Send("{F4}");
    }

    private void ButtonF5Click(object sender, EventArgs e)
    {
      SendKeys.Send("{F5}");
    }

    private void ButtonF6Click(object sender, EventArgs e)
    {
      SendKeys.Send("{F6}");
    }

    private void ButtonF7Click(object sender, EventArgs e)
    {
      SendKeys.Send("{F7}");
    }

    private void ButtonF8Click(object sender, EventArgs e)
    {
      SendKeys.Send("{F8}");
    }

    private void ButtonF9Click(object sender, EventArgs e)
    {
      SendKeys.Send("{F9}");
    }

    private void ButtonF10Click(object sender, EventArgs e)
    {
      SendKeys.Send("{F10}");
    }

    private void ButtonF11Click(object sender, EventArgs e)
    {
      SendKeys.Send("{F11}");
    }

    private void ButtonF12Click(object sender, EventArgs e)
    {
      SendKeys.Send("{F12}");
    }

    private void ButtonPrntScrClick(object sender, EventArgs e)
    {
      SendKeys.Send("{PRTSC}");
    }


    private void ButtonPageUpClick(object sender, EventArgs e)
    {
      SendKeys.Send("{PGUP}");
    }

    private void ButtonPageDownClick(object sender, EventArgs e)
    {
      SendKeys.Send("{PGDN}");
    }

    private void ButtonBackSpaceClick(object sender, EventArgs e)
    {
      SendKeys.Send("{BACKSPACE}");
    }

    private void ButtonTabClick(object sender, EventArgs e)
    {
      SendKeys.Send("{TAB}");
    }

    private void ButtonSpaceClick(object sender, EventArgs e)
    {
      SendKeys.Send(" ");
    }

    private void ButtonLessThenClick(object sender, EventArgs e)
    {
      if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
      {
        SendKeys.Send("<");
        checkBoxLeftShift.Checked = false;
        checkBoxRightShift.Checked = false;
      }
      else
      {
        SendKeys.Send(",");
      }
    }

    private void ButtonLessThenMouseEnter(object sender, EventArgs e)
    {
      var x = 7;
      var y = 2;
      SizeChangeNeighbor(x, y, 1);
    }

    private void ButtonLessThenMouseLeave(object sender, EventArgs e)
    {
      var x = 7;
      var y = 2;
      SizeChangeNeighbor(x, y, -1);
    }


    private void ButtonGreaterThenClick(object sender, EventArgs e)
    {
      if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
      {
        SendKeys.Send(">");
        checkBoxLeftShift.Checked = false;
        checkBoxRightShift.Checked = false;
      }
      else
      {
        SendKeys.Send(".");
      }
    }

    private void ButtonGreaterThenMouseEnter(object sender, EventArgs e)
    {
      var x = 8;
      var y = 2;
      SizeChangeNeighbor(x, y, 1);
    }

    private void ButtonGreaterThenMouseLeave(object sender, EventArgs e)
    {
      var x = 8;
      var y = 2;
      SizeChangeNeighbor(x, y, -1);
    }

    private void ButtonQuestionMarkSlashClick(object sender, EventArgs e)
    {
      if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
      {
        SendKeys.Send("?");
        checkBoxLeftShift.Checked = false;
        checkBoxRightShift.Checked = false;
      }
      else
      {
        SendKeys.Send("{/}");
      }
    }

    private void ButtonQuestionMarkSlashMouseEnter(object sender, EventArgs e)
    {
      var x = 9;
      var y = 2;
      SizeChangeNeighbor(x, y, 1);
    }

    private void ButtonQuestionMarkSlashMouseLeave(object sender, EventArgs e)
    {
      var x = 9;
      var y = 2;
      SizeChangeNeighbor(x, y, -1);
    }

    private void ButtonColonClick(object sender, EventArgs e)
    {
      if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
      {
        SendKeys.Send(":");
        checkBoxLeftShift.Checked = false;
        checkBoxRightShift.Checked = false;
      }
      else
      {
        SendKeys.Send(";");
      }
    }

    private void ButtonColonMouseEnter(object sender, EventArgs e)
    {
      var x = 9;
      var y = 1;
      SizeChangeNeighbor(x, y, 1);
    }

    private void ButtonColonMouseLeave(object sender, EventArgs e)
    {
      var x = 9;
      var y = 1;
      SizeChangeNeighbor(x, y, -1);
    }

    private void ButtonQuotesComaRightClick(object sender, EventArgs e)
    {
      if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
      {
        SendKeys.Send("\"");
        checkBoxLeftShift.Checked = false;
        checkBoxRightShift.Checked = false;
      }
      else
      {
        SendKeys.Send("'");
      }
    }

    private void ButtonVerticalBarRigthSlashClick(object sender, EventArgs e)
    {
      if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
      {
        SendKeys.Send("|");
        checkBoxLeftShift.Checked = false;
        checkBoxRightShift.Checked = false;
      }
      else
      {
        SendKeys.Send("\\");
      }
    }

    private void ButtonTildeCommaClick(object sender, EventArgs e)
    {
      if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
      {
        SendKeys.Send("{~}");
        checkBoxLeftShift.Checked = false;
        checkBoxRightShift.Checked = false;
      }
      else
      {
        SendKeys.Send("`");
      }
    }

    private void ButtonNumOneClick(object sender, EventArgs e)
    {
      if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
      {
        SendKeys.Send("!");
        checkBoxLeftShift.Checked = false;
        checkBoxRightShift.Checked = false;
      }
      else
      {
        SendKeys.Send("{1}");
      }
    }

    private void ButtonNumTwoClick(object sender, EventArgs e)
    {
      if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
      {
        SendKeys.Send("@");
        checkBoxLeftShift.Checked = false;
        checkBoxRightShift.Checked = false;
      }
      else
      {
        SendKeys.Send("{2}");
      }
    }

    private void ButtonNumThreeClick(object sender, EventArgs e)
    {
      if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
      {
        SendKeys.Send("#");
        checkBoxLeftShift.Checked = false;
        checkBoxRightShift.Checked = false;
      }
      else
      {
        SendKeys.Send("{3}");
      }
    }

    private void ButtonNumFourClick(object sender, EventArgs e)
    {
      if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
      {
        SendKeys.Send("$");
        checkBoxLeftShift.Checked = false;
        checkBoxRightShift.Checked = false;
      }
      else
      {
        SendKeys.Send("{4}");
      }
    }

    private void ButtonNumFiveClick(object sender, EventArgs e)
    {
      if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
      {
        SendKeys.Send("{%}");
        checkBoxLeftShift.Checked = false;
        checkBoxRightShift.Checked = false;
      }
      else
      {
        SendKeys.Send("{5}");
      }
    }

    private void ButtonNumSixClick(object sender, EventArgs e)
    {
      if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
      {
        SendKeys.Send("{^}");
        checkBoxLeftShift.Checked = false;
        checkBoxRightShift.Checked = false;
      }
      else
      {
        SendKeys.Send("{6}");
      }
    }

    private void ButtonNumSevenClick(object sender, EventArgs e)
    {
      if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
      {
        SendKeys.Send("&");
        checkBoxLeftShift.Checked = false;
        checkBoxRightShift.Checked = false;
      }
      else
      {
        SendKeys.Send("{7}");
      }
    }

    private void ButtonNumEightClick(object sender, EventArgs e)
    {
      if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
      {
        SendKeys.Send("{*}");
        checkBoxLeftShift.Checked = false;
        checkBoxRightShift.Checked = false;
      }
      else
      {
        SendKeys.Send("{8}");
      }
    }

    private void ButtonNUmNineClick(object sender, EventArgs e)
    {
      if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
      {
        SendKeys.Send("{(}");
        checkBoxLeftShift.Checked = false;
        checkBoxRightShift.Checked = false;
      }
      else
      {
        SendKeys.Send("{9}");
      }
    }

    private void ButtonNumZeroClick(object sender, EventArgs e)
    {
      if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
      {
        SendKeys.Send("{)}");
        checkBoxLeftShift.Checked = false;
        checkBoxRightShift.Checked = false;
      }
      else
      {
        SendKeys.Send("{0}");
      }
    }

    private void ButtonMinusClick(object sender, EventArgs e)
    {
      if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
      {
        SendKeys.Send("_");
        checkBoxLeftShift.Checked = false;
        checkBoxRightShift.Checked = false;
      }
      else
      {
        SendKeys.Send("{-}");
      }
    }

    private void ButtonPlusClick(object sender, EventArgs e)
    {
      if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
      {
        SendKeys.Send("{+}");
        checkBoxLeftShift.Checked = false;
        checkBoxRightShift.Checked = false;
      }
      else
      {
        SendKeys.Send("=");
      }
    }

    private void ButtonDelClick(object sender, EventArgs e)
    {
      SendKeys.Send("{DELETE}");
    }

    private void Form1Load(object sender, EventArgs e)
    {
      var x = Screen.PrimaryScreen.WorkingArea.Width / 2 - Width / 2;
      var y = Screen.PrimaryScreen.WorkingArea.Height - Height;
      Location = new Point(x, y);
      TopMost = true;
      Opacity = 0.9;
    }

    private void CheckBoxRightShiftCheckedChanged(object sender, EventArgs e)
    {
    }

    private void ButtonStartRightClick(object sender, EventArgs e)
    {
    }

    private void ButtonCtrlRightClick(object sender, EventArgs e)
    {
    }

    private void ButtonAltRightClick(object sender, EventArgs e)
    {
    }

    private void ButtonAltLeftClick(object sender, EventArgs e)
    {
    }

    private void ButtonStartLeftClick(object sender, EventArgs e)
    {
    }

    private void CheckBoxCtrlLeftCheckedChanged(object sender, EventArgs e)
    {
    }

    private void CheckBoxLeftShiftCheckedChanged(object sender, EventArgs e)
    {
    }

    private void CheckBoxCapLockCheckedChanged(object sender, EventArgs e)
    {
    }


    //helpful:

    //SendKeys.Send("{HOME}");
    //SendKeys.Send("{END}");
  }
}