﻿// written by: Marc Tabago
// tested by: Marc Tabago
// debugged by: Marc Tabago
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace KinEmote
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
