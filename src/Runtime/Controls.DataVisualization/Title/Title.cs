﻿// (c) Copyright Microsoft Corporation.
// This source is subject to the Microsoft Public License (Ms-PL).
// Please see http://go.microsoft.com/fwlink/?LinkID=131993 for details.
// All other rights reserved.

#if MIGRATION
namespace System.Windows.Controls.DataVisualization
#else
namespace Windows.UI.Xaml.Controls.DataVisualization
#endif
{
    /// <summary>
    /// Represents the title of a data visualization control.
    /// </summary>
    /// <QualityBand>Preview</QualityBand>
    public partial class Title : ContentControl
    {
#if !SILVERLIGHT
        /// <summary>
        /// Initializes the static members of the Title class.
        /// </summary>
        static Title()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Title), new FrameworkPropertyMetadata(typeof(Title)));
        }

#endif
        /// <summary>
        /// Initializes a new instance of the Title class.
        /// </summary>
        public Title()
        {
#if SILVERLIGHT
            DefaultStyleKey = typeof(Title);
#endif
        }
    }
}