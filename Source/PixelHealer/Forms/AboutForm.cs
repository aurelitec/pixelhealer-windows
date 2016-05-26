//----------------------------------------------------------------------------
// <copyright file="AboutForm.cs" company="Aurelitec">
// Copyright (C) 2012-2016 Aurelitec
// </copyright>
//
// Description: The About form.
//
//---------------------------------------------------------------------------

namespace PixelHealer
{
    using System;
    using System.Diagnostics;
    using System.Drawing;
    using System.Globalization;
    using System.Windows.Forms;

    /// <summary>
    /// The About form.
    /// </summary>
    public partial class AboutForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AboutForm"/> class.
        /// </summary>
        public AboutForm()
        {
            // Fix: set the form's font to the default operating system font
            this.Font = SystemFonts.MessageBoxFont;

            // Required method for designer support
            this.InitializeComponent();

            this.nameLabel.Font = new Font(SystemFonts.MessageBoxFont.FontFamily, 11, FontStyle.Bold);
            this.versionLabel.Text = string.Format(CultureInfo.CurrentCulture, this.versionLabel.Text, Application.ProductVersion);
        }

        /// <summary>
        /// Opens the program url in the default browser.
        /// </summary>
        /// <param name="sender">The sender of the event.</param>
        /// <param name="e">Link event data.</param>
        private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(this.linkLabel.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
