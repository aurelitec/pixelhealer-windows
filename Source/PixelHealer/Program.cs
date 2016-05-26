//----------------------------------------------------------------------------
//
// <copyright file="Program.cs" company="Aurelitec">
// Copyright (C) 2012-2016 Aurelitec
// </copyright>
//
// Description: PixelHealer program class.
//
//---------------------------------------------------------------------------

namespace PixelHealer
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// PixelHealer program class.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            SimplerFileSettingsProvider.ApplyProvider(Properties.Settings.Default);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RepairForm());
        }
    }
}
