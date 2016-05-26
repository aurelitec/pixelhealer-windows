//-------------------------------------------------------------------------------------------------
//
// <copyright file="SimplerFileSettingsProvider.cs" company="Aurelitec">
// Copyright (C) 2012-2016 Aurelitec
// </copyright>
//
// This file is based on the PortableSettingsProvider class by Jim Radford
// https://git.io/vr1s8
//
//-------------------------------------------------------------------------------------------------

namespace PixelHealer
{
    using System;
    using System.Configuration;
    using System.Globalization;
    using System.IO;
    using System.Windows.Forms;
    using System.Xml;

    /// <summary>
    /// A simpler alternative to LocalFileSettingsProvider that provides persistence for application settings classes, supporting both
    /// portable and roaming application data settings.
    /// </summary>
    public class SimplerFileSettingsProvider : SettingsProvider
    {
        private const string ClassName = "SimplerFileSettingsProvider";
        private const string SettingsRoot = "Settings";

        private XmlDocument settingsXml;

        /// <summary>
        /// Gets the file path of the portable settings file.
        /// </summary>
        public static string FilePath
        {
            get
            {
                // First check if we have a settings file in the folder of the main executable file (to support portable programs)
                string filePath = Path.Combine(
                    Path.GetDirectoryName(Application.ExecutablePath),
                    string.Format(CultureInfo.InvariantCulture, "{0}.settings", Application.ProductName));

                // If no portable settings file is found, use a settings file in the roaming application data folder
                if (!File.Exists(filePath))
                {
                    string appDataDirectory = Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                        string.Format(CultureInfo.InvariantCulture, @"{0}\{1}", Application.CompanyName, Application.ProductName));
                    Directory.CreateDirectory(appDataDirectory);

                    filePath = Path.Combine(appDataDirectory, string.Format(CultureInfo.InvariantCulture, @"{0}.settings", Application.ProductName));
                }

                return filePath;
            }
        }

        /// <summary>
        /// Gets the friendly name used to refer to the provider during configuration.
        /// </summary>
        public override string Name
        {
            get { return ClassName; }
        }

        /// <summary>
        /// Gets or sets the name of the currently running application.
        /// </summary>
        public override string ApplicationName
        {
            get { return Application.ProductName; }
            set { }
        }

        /// <summary>
        /// Gets the Settings XML document.
        /// </summary>
        private XmlDocument SettingsXml
        {
            get
            {
                // If we dont hold an xml document, try opening one.
                // If it doesnt exist then create a new one ready.
                if (this.settingsXml == null)
                {
                    this.settingsXml = new XmlDocument();
                    try
                    {
                        this.settingsXml.Load(FilePath);
                    }
                    catch (Exception)
                    {
                        // Create new document
                        XmlDeclaration declaration = this.settingsXml.CreateXmlDeclaration("1.0", "utf-8", string.Empty);
                        this.settingsXml.AppendChild(declaration);
                        XmlNode nodeRoot = this.settingsXml.CreateNode(XmlNodeType.Element, SettingsRoot, string.Empty);
                        this.settingsXml.AppendChild(nodeRoot);
                    }
                }

                return this.settingsXml;
            }
        }

        /// <summary>
        /// Sets the settings provider of the specified settings to an instance of the SimplerFileSettingsProvider class.
        /// </summary>
        /// <param name="settings">The settings that will use the SimplerFileSettingsProvider.</param>
        public static void ApplyProvider(ApplicationSettingsBase settings)
        {
            var simplerFileSettingsProvider = new SimplerFileSettingsProvider();
            settings.Providers.Add(simplerFileSettingsProvider);
            foreach (SettingsProperty property in settings.Properties)
            {
                property.Provider = simplerFileSettingsProvider;
            }

            settings.Reload();
        }

        /// <summary>
        /// Initializes the provider.
        /// </summary>
        /// <param name="name">The friendly name of the provider.</param>
        /// <param name="config">A collection of the name/value pairs representing the provider-specific attributes specified in the
        /// configuration for this provider.</param>
        public override void Initialize(string name, System.Collections.Specialized.NameValueCollection config)
        {
            base.Initialize(this.ApplicationName, config);
        }

        /// <summary>
        /// Sets the values of the specified group of property settings.
        /// </summary>
        /// <param name="context">A SettingsContext describing the current application usage.</param>
        /// <param name="collection">A SettingsPropertyValueCollection representing the group of property settings to set.</param>
        public override void SetPropertyValues(SettingsContext context, SettingsPropertyValueCollection collection)
        {
            foreach (SettingsPropertyValue propVal in collection)
            {
                this.SetValue(propVal);
            }

            try
            {
                this.SettingsXml.Save(FilePath);
            }
            catch (Exception)
            {
                ////Log.Error("Error saving settings", ex);
            }
        }

        /// <summary>
        /// Returns the collection of settings property values for the specified application instance and settings property group.
        /// </summary>
        /// <param name="context">A SettingsContext describing the current application use.</param>
        /// <param name="collection">A SettingsPropertyCollection containing the settings property group whose values are to be retrieved.</param>
        /// <returns>A SettingsPropertyValueCollection containing the values for the specified settings property group.</returns>
        public override SettingsPropertyValueCollection GetPropertyValues(SettingsContext context, SettingsPropertyCollection collection)
        {
            // Create new collection of values
            SettingsPropertyValueCollection values = new SettingsPropertyValueCollection();

            // Iterate through the settings to be retrieved
            foreach (SettingsProperty setting in collection)
            {
                SettingsPropertyValue value = new SettingsPropertyValue(setting)
                {
                    IsDirty = true,
                    SerializedValue = this.GetValue(setting)
                };
                values.Add(value);
            }

            return values;
        }

        private string GetValue(SettingsProperty setting)
        {
            string value = string.Empty;

            try
            {
                XmlNode node = this.SettingsXml.SelectSingleNode(SettingsRoot + "/" + setting.Name);
                value = node.InnerText;
            }
            catch (Exception)
            {
                value = setting.DefaultValue != null ? setting.DefaultValue.ToString() : string.Empty;
            }

            return value;
        }

        private void SetValue(SettingsPropertyValue propVal)
        {
            XmlNode settingNode;

            // The setting value is stored as an element under the root
            try
            {
                settingNode = (XmlElement)this.SettingsXml.SelectSingleNode(SettingsRoot + "/" + propVal.Name);
            }
            catch (Exception)
            {
                settingNode = null;
            }

            // Check to see if the node exists, if so then set its new value
            if (settingNode != null)
            {
                settingNode.InnerText = propVal.SerializedValue.ToString();
            }
            else
            {
                // Store the value as an element of the Settings Root Node
                settingNode = this.SettingsXml.CreateElement(propVal.Name);
                settingNode.InnerText = propVal.SerializedValue.ToString();
                this.SettingsXml.SelectSingleNode(SettingsRoot).AppendChild(settingNode);
            }
        }
    }
}