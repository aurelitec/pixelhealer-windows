//----------------------------------------------------------------------------
//
// <copyright file="SettingsForm.cs" company="Aurelitec">
// Copyright (C) 2012-2016 Aurelitec
// </copyright>
//
// Description: The settings form for a PixelHealer repair form.
//
//---------------------------------------------------------------------------

#pragma warning disable SA1124 // DoNotUseRegions

namespace PixelHealer
{
    using System;
    using System.Drawing;
    using System.Globalization;
    using System.Text;
    using System.Windows.Forms;

    /// <summary>
    /// The settings form for a PixelHealer repair form.
    /// </summary>
    public partial class SettingsForm : Form
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsForm"/> class.
        /// </summary>
        public SettingsForm()
        {
            // Fix: set the form's font to the default operating system font
            this.Font = SystemFonts.MessageBoxFont;

            // Required method for designer support
            this.InitializeComponent();
        }

        #endregion

        #region Public Functionality Methods

        /// <summary>
        /// Updates the text of the Start/Stop Flashing button.
        /// </summary>
        /// <param name="isFlashing">True if the repair form is currently flashing, false otherwise.</param>
        public void UpdateToggleFlashingButton(bool isFlashing)
        {
            this.toggleFlashingButton.Text = isFlashing ? Properties.Resources.StopFlashing : Properties.Resources.StartFlashing;
        }

        /// <summary>
        /// Updates the auto close timer label with the current elapsed and remaining times.
        /// </summary>
        /// <param name="elapsed">The elapsed time so far.</param>
        /// <param name="remaining">The remaining time, if the auto close setting is on.</param>
        public void UpdateTimerLabel(TimeSpan elapsed, TimeSpan remaining)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(CultureInfo.CurrentCulture, Properties.Resources.ElapsedTime, elapsed.Hours, elapsed.Minutes, elapsed.Seconds);
            if (remaining > TimeSpan.Zero)
            {
                sb.AppendFormat(
                    CultureInfo.CurrentCulture, Properties.Resources.RemainingTime, remaining.Hours, remaining.Minutes, remaining.Seconds);
            }

            this.autoCloseElapsedLabel.Text = sb.ToString();
        }

        #endregion

        #region Private Functionality Methods

        /// <summary>
        /// Updates the flashing interval label.
        /// </summary>
        private void UpdateFlashingIntervalLabel()
        {
            this.intervalLabel.Text = string.Format(CultureInfo.CurrentCulture, Properties.Resources.Interval, this.intervalTrackBar.Value);
        }

        #endregion

        #region Form Initialization

        /// <summary>
        /// Performs some initialization routines when the form is first loaded.
        /// </summary>
        /// <param name="sender">The sender of the event.</param>
        /// <param name="e">Empty event data.</param>
        private void SettingsForm_Load(object sender, EventArgs e)
        {
            // Displays the current flashing interval
            this.UpdateFlashingIntervalLabel();

            // Perform some UI fixes
            this.warningLabel.Font = new Font(this.warningLabel.Font, FontStyle.Bold);
            this.locateButton.Height = this.heightNumericUpDown.Height;
            this.intervalTrackBar.Width = this.colorsFlowLayoutPanel.Width;

            // For some reason, setting the margin on NumericUpDown controls at design time moves them too far apart
            this.topNumericUpDown.Margin = this.widthNumericUpDown.Margin = this.heightNumericUpDown.Margin = this.locateButton.Margin =
                new Padding(15, 0, 0, 0);
        }

        #endregion

        #region Settings Controls Events

        /// <summary>
        /// Starts or stops flashing when the user clicks the Start/Stop Flashing button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An object that contains no event data.</param>
        private void ToggleFlashingButton_Click(object sender, EventArgs e)
        {
            RepairForm.TheRepairForm.ToggleFlashing();
        }

        /// <summary>
        /// Opens the Color Picker dialog box when the user clicks the Pick button.
        /// </summary>
        /// <param name="sender">The sender of the event.</param>
        /// <param name="e">Empty event data.</param>
        private void PickCustomColorButton_Click(object sender, EventArgs e)
        {
            this.colorDialog.Color = this.customColorCheckBox.BackColor;
            if (this.colorDialog.ShowDialog(this) == DialogResult.OK)
            {
                this.customColorCheckBox.BackColor = this.colorDialog.Color;
            }
        }

        /// <summary>
        /// Locates the repair form on the screen when the user clicks the Locate button.
        /// </summary>
        /// <param name="sender">The sender of the event.</param>
        /// <param name="e">Empty event data.</param>
        private void LocateButton_Click(object sender, EventArgs e)
        {
            RepairForm.TheRepairForm.LocateOnscreen();
        }

        /// <summary>
        /// Updates the flashing interval label when the user scrolls the interval track bar.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An object that contains no event data.</param>
        private void IntervalTrackBar_Scroll(object sender, EventArgs e)
        {
            this.UpdateFlashingIntervalLabel();
        }

        #endregion

        #region Other Form Events

        /// <summary>
        /// Close the settings form when the user presses the Escape key.
        /// </summary>
        /// <param name="sender">The sender of the event.</param>
        /// <param name="e">Key event data.</param>
        private void SettingsForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        #endregion
    }
}
