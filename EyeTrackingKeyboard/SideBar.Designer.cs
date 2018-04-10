namespace EyeTrackingKeyboard
{
  partial class SideBar
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
      this.Button_Close = new System.Windows.Forms.Button();
      this.Button_Toggle = new System.Windows.Forms.Button();
      this.Button_Hide = new System.Windows.Forms.Button();
      this.Button_Opacity = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // Button_Close
      // 
      this.Button_Close.BackColor = System.Drawing.Color.DimGray;
      this.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.Button_Close.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold);
      this.Button_Close.ForeColor = System.Drawing.Color.White;
      this.Button_Close.Location = new System.Drawing.Point(6, 261);
      this.Button_Close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Button_Close.Name = "Button_Close";
      this.Button_Close.Size = new System.Drawing.Size(69, 62);
      this.Button_Close.TabIndex = 0;
      this.Button_Close.Text = "Close";
      this.Button_Close.UseVisualStyleBackColor = false;
      this.Button_Close.Click += new System.EventHandler(this.ButtonCloseClick);
      // 
      // Button_Toggle
      // 
      this.Button_Toggle.BackColor = System.Drawing.Color.DimGray;
      this.Button_Toggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.Button_Toggle.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Button_Toggle.ForeColor = System.Drawing.Color.White;
      this.Button_Toggle.Location = new System.Drawing.Point(6, 6);
      this.Button_Toggle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Button_Toggle.Name = "Button_Toggle";
      this.Button_Toggle.Size = new System.Drawing.Size(69, 62);
      this.Button_Toggle.TabIndex = 1;
      this.Button_Toggle.Text = "Toggle";
      this.Button_Toggle.UseVisualStyleBackColor = false;
      this.Button_Toggle.Click += new System.EventHandler(this.ButtonToggleClick);
      // 
      // Button_Hide
      // 
      this.Button_Hide.BackColor = System.Drawing.Color.DimGray;
      this.Button_Hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.Button_Hide.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold);
      this.Button_Hide.ForeColor = System.Drawing.Color.White;
      this.Button_Hide.Location = new System.Drawing.Point(6, 75);
      this.Button_Hide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Button_Hide.Name = "Button_Hide";
      this.Button_Hide.Size = new System.Drawing.Size(69, 62);
      this.Button_Hide.TabIndex = 2;
      this.Button_Hide.Text = "Hide Bar";
      this.Button_Hide.UseVisualStyleBackColor = false;
      this.Button_Hide.Click += new System.EventHandler(this.ButtonHideClick);
      // 
      // Button_Opacity
      // 
      this.Button_Opacity.BackColor = System.Drawing.Color.DimGray;
      this.Button_Opacity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.Button_Opacity.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Button_Opacity.ForeColor = System.Drawing.Color.White;
      this.Button_Opacity.Location = new System.Drawing.Point(6, 144);
      this.Button_Opacity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Button_Opacity.Name = "Button_Opacity";
      this.Button_Opacity.Size = new System.Drawing.Size(69, 62);
      this.Button_Opacity.TabIndex = 3;
      this.Button_Opacity.Text = "Opacity";
      this.Button_Opacity.UseVisualStyleBackColor = false;
      this.Button_Opacity.Click += new System.EventHandler(this.ButtonOpacityClick);
      // 
      // SideBar
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Black;
      this.ClientSize = new System.Drawing.Size(83, 330);
      this.Controls.Add(this.Button_Opacity);
      this.Controls.Add(this.Button_Hide);
      this.Controls.Add(this.Button_Toggle);
      this.Controls.Add(this.Button_Close);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Name = "SideBar";
      this.ShowInTaskbar = false;
      this.Text = "SideBar";
      this.Load += new System.EventHandler(this.SideBarLoad);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button Button_Close;
    private System.Windows.Forms.Button Button_Toggle;
    private System.Windows.Forms.Button Button_Hide;
    private System.Windows.Forms.Button Button_Opacity;
  }
}