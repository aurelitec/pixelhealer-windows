//----------------------------------------------------------------------------
//
// <copyright file="RepairForm.cs" company="Aurelitec">
// Copyright (C) 2012-2016 Aurelitec
// </copyright>
//
// Description: The color flashing repair form of PixelHealer.
//
//---------------------------------------------------------------------------

#pragma warning disable SA1124 // DoNotUseRegions

namespace PixelHealer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Timers;
    using System.Windows.Forms;

    /// <summary>
    /// The color flashing repair forms of PixelHealer.
    /// </summary>
    public partial class RepairForm : Form
    {
        #region Fields

        /// <summary>
        /// The high accuracy timer for flashing.
        /// </summary>
        private System.Timers.Timer flashingTimer;

        /// <summary>
        /// The stopwatch that counts the repair form life time.
        /// </summary>
        private Stopwatch flashingStopwatch;

        /// <summary>
        /// The auto close time span.
        /// </summary>
        private TimeSpan autoCloseTimeSpan;

        /// <summary>
        /// The list of flashing colors.
        /// </summary>
        private List<Color> flashingColorsList;

        /// <summary>
        /// The current color index in the list of flashing colors.
        /// </summary>
        private int currentFlashingColorIndex;

        /// <summary>
        /// The associated repair settings form.
        /// </summary>
        private SettingsForm settingsForm;

        /// <summary>
        /// The about form.
        /// </summary>
        private AboutForm aboutForm;

        /// <summary>
        /// Is the moving or resizing of the form performed by the user?
        /// </summary>
        private bool userMoveResize;

        /// <summary>
        /// Backup copy of the previously saved form size.
        /// </summary>
        private Size savedSize;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="RepairForm"/> class.
        /// </summary>
        public RepairForm()
        {
            // Set the form's font to the default operating system font
            this.Font = SystemFonts.MessageBoxFont;

            // Required method for designer support
            this.InitializeComponent();

            // This is the repair form instance
            RepairForm.TheRepairForm = this;

            // Set the previously saved location, and backup the previously saved size to apply at the end of the Load event
            this.Location = new Point((int)Properties.Settings.Default.Left, (int)Properties.Settings.Default.Top);
            this.savedSize = new Size((int)Properties.Settings.Default.Width, (int)Properties.Settings.Default.Height);

            // Handle application settings property changes
            Properties.Settings.Default.PropertyChanged += this.Default_PropertyChanged;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the main form instance.
        /// </summary>
        public static RepairForm TheRepairForm { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the settings form is created (and displayed).
        /// </summary>
        private bool SettingsFormExists
        {
            get { return (this.settingsForm != null) && (!this.settingsForm.IsDisposed); }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Starts flashing if the flashing is stopped, or stop flashing if flashing is running.
        /// </summary>
        public void ToggleFlashing()
        {
            if (!this.flashingTimer.Enabled)
            {
                this.StartFlashing();
            }
            else
            {
                this.StopFlashing();
            }

            // Update the Pause/Resume button text and enable/disable the interval track bar in the settings form, if visible
            if (this.SettingsFormExists)
            {
                this.settingsForm.UpdateToggleFlashingButton(this.flashingTimer.Enabled);
            }
        }

        /// <summary>
        /// Locates the repair form on screen by moving the mouse pointer over it.
        /// </summary>
        public void LocateOnscreen()
        {
            this.BringToFront();
            Cursor.Position = new Point(this.Location.X + (this.Width / 2), this.Location.Y + (this.Height / 2));
        }

        #endregion

        #region Form Initialization

        /// <summary>
        /// Event: Performs important initialization routines when the form is first loaded.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Empty event data.</param>
        private void EventFlashingFormLoad(object sender, EventArgs e)
        {
            // Initialize the flashing timer and stopwatch
            this.flashingTimer = new System.Timers.Timer(Properties.Settings.Default.FlashingInterval)
                { AutoReset = false, SynchronizingObject = this };
            this.flashingTimer.Elapsed += this.EventFlashingTimerElapsed;
            this.flashingStopwatch = new Stopwatch();

            // Initialize the default flashing color list
            this.flashingColorsList = new List<Color>();
            this.currentFlashingColorIndex = 0;
            this.UpdateFlashingColorsList();

            // Update the auto close time
            this.UpdateAutoCloseTime();

            // Set the form size to the previously saved size (to allow even 1x1 saved form sizes)
            this.Size = this.savedSize;

            // Update the notify icon
            this.notifyIcon.Icon = this.Icon;

            // Assign the context menu
            this.ContextMenu = this.contextMenu;
            this.notifyIcon.ContextMenu = this.contextMenu;

            // Make the repair form moveable and resizeable with the mouse
            RestlessControlMaker.Make(this).FullBodyCursor = Cursors.Cross;
        }

        /// <summary>
        /// Event: Shows the Settings form when the repair form is first shown.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Empty event data.</param>
        private void EventRepairFormShown(object sender, EventArgs e)
        {
            this.ShowSettingsForm();
        }

        #endregion

        #region Timer Functionality

        /// <summary>
        /// Event Handler: Flashing Timer -> Elapsed
        /// Periodically flashes (quickly changes) the background of the repair window.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Elapsed event data.</param>
        private void EventFlashingTimerElapsed(object sender, ElapsedEventArgs e)
        {
            if (this.flashingColorsList.Count > 0)
            {
                this.BackColor = this.flashingColorsList[this.currentFlashingColorIndex];
                this.currentFlashingColorIndex = this.currentFlashingColorIndex < this.flashingColorsList.Count - 1 ? this.currentFlashingColorIndex + 1 : 0;
            }

            // To ensure that the flashing timer cannot re-enter this Elapsed event, its AutoReset property is false and
            // now we are manually starting it again, after we finished changing the background color
            this.flashingTimer.Start();
        }

        /// <summary>
        /// Starts flashing by starting the flashing timer and stopwatch.
        /// </summary>
        private void StartFlashing()
        {
            this.flashingTimer.Start();
            this.flashingStopwatch.Start();
        }

        /// <summary>
        /// Stops flashing by stopping the flashing timer and stopwatch.
        /// </summary>
        private void StopFlashing()
        {
            this.flashingTimer.Stop();
            this.flashingStopwatch.Stop();
        }

        /// <summary>
        /// Checks if it's time to close when the auto close timer fires. Also updates the auto close elapsed and remaining timer label
        /// in the Settings form.
        /// </summary>
        /// <param name="sender">The sender of the event.</param>
        /// <param name="e">Empty event data.</param>
        private void AutoCloseTimer_Tick(object sender, EventArgs e)
        {
            // Check if it's autoclose time
            if ((this.autoCloseTimeSpan > TimeSpan.Zero) && (this.flashingStopwatch.Elapsed > this.autoCloseTimeSpan))
            {
                this.Close();
            }

            // Update the settings form
            if (this.SettingsFormExists)
            {
                TimeSpan remaining = this.autoCloseTimeSpan - this.flashingStopwatch.Elapsed;
                this.settingsForm.UpdateTimerLabel(this.flashingStopwatch.Elapsed, remaining);
            }
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Shortcut method to add a color to the flashing colors list, only if it's checked by the user.
        /// </summary>
        /// <param name="isChecked">True if the color is checked by the user, false otherwise.</param>
        /// <param name="color">The color value.</param>
        private void AddCheckedColor(bool isChecked, Color color)
        {
            if (isChecked)
            {
                this.flashingColorsList.Add(color);
            }
        }

        /// <summary>
        /// Updates the flashing color list with a new list of flashing colors.
        /// </summary>
        private void UpdateFlashingColorsList()
        {
            bool wasEnabled = this.flashingTimer.Enabled;
            this.StopFlashing();
            try
            {
                this.flashingColorsList.Clear();
                this.currentFlashingColorIndex = 0;
                this.AddCheckedColor(Properties.Settings.Default.BlackChecked, Color.Black);
                this.AddCheckedColor(Properties.Settings.Default.WhiteChecked, Color.White);
                this.AddCheckedColor(Properties.Settings.Default.RedChecked, Color.Red);
                this.AddCheckedColor(Properties.Settings.Default.GreenChecked, Color.Lime);
                this.AddCheckedColor(Properties.Settings.Default.BlueChecked, Color.Blue);
                this.AddCheckedColor(Properties.Settings.Default.CustomColorChecked, Properties.Settings.Default.CustomColor);
            }
            finally
            {
                if (wasEnabled)
                {
                    this.StartFlashing();
                }
            }
        }

        /// <summary>
        /// Updates the auto close time span.
        /// </summary>
        private void UpdateAutoCloseTime()
        {
            if (Properties.Settings.Default.AutoClose)
            {
                DateTime time = Properties.Settings.Default.AutoCloseTime;
                this.autoCloseTimeSpan = new TimeSpan(time.Hour, time.Minute, time.Second);
            }
            else
            {
                this.autoCloseTimeSpan = TimeSpan.Zero;
            }
        }

        /// <summary>
        /// Creates and shows the settings form. If it's already displayed, focuses it.
        /// </summary>
        private void ShowSettingsForm()
        {
            if (!this.SettingsFormExists)
            {
                this.settingsForm = new SettingsForm();
                this.settingsForm.Show(this);
                this.settingsForm.UpdateToggleFlashingButton(this.flashingTimer.Enabled);
            }
            else
            {
                this.settingsForm.Focus();
            }
        }

        #endregion

        #region Other Form Events

        /// <summary>
        /// Perform important tasks when application settings properties are changes.
        /// </summary>
        /// <param name="sender">The sender of the event.</param>
        /// <param name="e">Property changed event data.</param>
        private void Default_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            // Update the flashing colors list when colors are checked or unchecked, or the custom color is changed
            if (e.PropertyName.Contains("Checked") || e.PropertyName.Equals("CustomColor"))
            {
                this.UpdateFlashingColorsList();
                return;
            }

            // Update the interval of the high accuracy timer for flashing when the flashing interval is changed
            if (e.PropertyName.Equals("FlashingInterval"))
            {
                if (this.flashingTimer != null)
                {
                    this.flashingTimer.Interval = Properties.Settings.Default.FlashingInterval;
                }

                return;
            }

            // Update the auto close time span when the auto close checked setting or the auto close time setting are changed
            if (e.PropertyName.Equals("AutoClose") || e.PropertyName.Equals("AutoCloseTime"))
            {
                this.UpdateAutoCloseTime();

                return;
            }

            // Update the location and size of the form when the left, top, width or height settings change (but not when the user
            // directly moves or resizes the form)
            if (!this.userMoveResize)
            {
                if (e.PropertyName.Equals("Left"))
                {
                    this.Left = (int)Properties.Settings.Default.Left;
                    return;
                }

                if (e.PropertyName.Equals("Top"))
                {
                    this.Top = (int)Properties.Settings.Default.Top;
                    return;
                }

                if (e.PropertyName.Equals("Width"))
                {
                    this.Width = (int)Properties.Settings.Default.Width;
                    return;
                }

                if (e.PropertyName.Equals("Height"))
                {
                    this.Height = (int)Properties.Settings.Default.Height;
                    return;
                }
            }
        }

        /// <summary>
        /// Updates the Left and Top user settings when the user moves the form.
        /// </summary>
        /// <param name="sender">The sender of the event.</param>
        /// <param name="e">Empty event data.</param>
        private void RepairForm_Move(object sender, EventArgs e)
        {
            this.userMoveResize = true;
            Properties.Settings.Default.Left = this.Left;
            Properties.Settings.Default.Top = this.Top;
            this.userMoveResize = false;
        }

        /// <summary>
        /// Updates the Width and Height user settings when the user resizes the form.
        /// </summary>
        /// <param name="sender">The sender of the event.</param>
        /// <param name="e">Empty event data.</param>
        private void RepairForm_Resize(object sender, EventArgs e)
        {
            this.userMoveResize = true;
            Properties.Settings.Default.Width = this.Width;
            Properties.Settings.Default.Height = this.Height;
            this.userMoveResize = false;
        }

        /// <summary>
        /// Shows the settings form when the user presses Escape.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Keyboard event data.</param>
        private void RepairForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.ShowSettingsForm();
            }
        }

        /// <summary>
        /// Toggles (starts or stops) flashing when the user double-clicks the left mouse button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Mouse event data.</param>
        private void RepairForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.ToggleFlashing();
            }
        }

        /// <summary>
        /// Shows the settings form when the user clicks the notify icon.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Mouse event data.</param>
        private void NotifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.ShowSettingsForm();
            }
        }

        #endregion

        #region Context Menu

        /// <summary>
        /// Show the Settings form when the user clicks the Settings context menu item.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An object that contains no event data.</param>
        private void SettingsMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowSettingsForm();
        }

        /// <summary>
        /// Show the About form when the user clicks the About context menu item.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An object that contains no event data.</param>
        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            if (this.aboutForm == null)
            {
                this.aboutForm = new AboutForm();
            }

            if (!this.aboutForm.Visible)
            {
                this.aboutForm.ShowDialog(this);
            }
            else
            {
                this.aboutForm.Focus();
            }
        }

        /// <summary>
        /// Closes the form and the app when the user clicks the Exit context menu item.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An object that contains no event data.</param>
        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Form Closing

        /// <summary>
        /// Saves the user settings when the form is closing.
        /// </summary>
        /// <param name="sender">The sender of the event.</param>
        /// <param name="e">Form closing event data.</param>
        private void RepairForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        #endregion
    }
}
