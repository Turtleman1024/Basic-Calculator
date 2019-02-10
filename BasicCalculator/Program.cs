/*
 *  Author: Kenneth M. Murry
 *  Objective: This program creates a Basic GUI Calculator.
 *             The program will us a Windows Form Application format.
 *  Refrences: https://www.youtube.com/watch?v=W6vJ_c9Mt6A&t=1294s
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator
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
            Application.Run(new Form1());
        }
    }
}
