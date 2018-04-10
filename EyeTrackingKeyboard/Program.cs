﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using  System.Windows.Input;

namespace EyeTrackingKeyboard
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //system call to windows on screen keyboard
            //System.Diagnostics.Process.Start("osk.exe");


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var fm = new SideBar();

            //making the form transperent
            fm.Opacity = new Double();
            fm.Opacity = 0.90;

            //making the form(keyboard) alway on top
            fm.TopMost = true;
            Application.Run(fm);
           
             
        }
    }
}
