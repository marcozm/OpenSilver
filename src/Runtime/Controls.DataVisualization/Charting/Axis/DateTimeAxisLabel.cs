﻿// (c) Copyright Microsoft Corporation.
// This source is subject to the Microsoft Public License (Ms-PL).
// Please see http://go.microsoft.com/fwlink/?LinkID=131993 for details.
// All other rights reserved.

using System.Diagnostics.CodeAnalysis;

#if MIGRATION
namespace System.Windows.Controls.DataVisualization.Charting
#else
namespace Windows.UI.Xaml.Controls.DataVisualization.Charting
#endif
{
    /// <summary>
    /// An axis label for displaying DateTime values.
    /// </summary>
    [OpenSilver.NotImplemented]
    public class DateTimeAxisLabel : AxisLabel
    {
        #region public DateTimeIntervalType IntervalType
        /// <summary>
        /// Gets or sets the interval type of the DateTimeAxis2.
        /// </summary>
        public DateTimeIntervalType IntervalType
        {
            get { return (DateTimeIntervalType)GetValue(IntervalTypeProperty); }
            set { SetValue(IntervalTypeProperty, value); }
        }

        /// <summary>
        /// Identifies the IntervalType dependency property.
        /// </summary>
        public static readonly DependencyProperty IntervalTypeProperty =
            DependencyProperty.Register(
                "IntervalType",
                typeof(DateTimeIntervalType),
                typeof(DateTimeAxisLabel),
                new PropertyMetadata(DateTimeIntervalType.Auto, OnIntervalTypePropertyChanged));

        /// <summary>
        /// IntervalTypeProperty property changed handler.
        /// </summary>
        /// <param name="d">DateTimeAxisLabel that changed its IntervalType.</param>
        /// <param name="e">Event arguments.</param>
        private static void OnIntervalTypePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            DateTimeAxisLabel source = (DateTimeAxisLabel)d;
            DateTimeIntervalType oldValue = (DateTimeIntervalType)e.OldValue;
            DateTimeIntervalType newValue = (DateTimeIntervalType)e.NewValue;
            source.OnIntervalTypePropertyChanged(oldValue, newValue);
        }

        /// <summary>
        /// IntervalTypeProperty property changed handler.
        /// </summary>
        /// <param name="oldValue">Old value.</param>
        /// <param name="newValue">New value.</param>        
        protected virtual void OnIntervalTypePropertyChanged(DateTimeIntervalType oldValue, DateTimeIntervalType newValue)
        {
            UpdateFormattedContent();
        }
        #endregion public DateTimeIntervalType IntervalType

        #region public string YearsIntervalStringFormat
        /// <summary>
        /// Gets or sets the format string to use when the interval is hours.
        /// </summary>
        public string YearsIntervalStringFormat
        {
            get { return GetValue(YearsIntervalStringFormatProperty) as string; }
            set { SetValue(YearsIntervalStringFormatProperty, value); }
        }

        /// <summary>
        /// Identifies the YearsIntervalStringFormat dependency property.
        /// </summary>
        public static readonly DependencyProperty YearsIntervalStringFormatProperty =
            DependencyProperty.Register(
                "YearsIntervalStringFormat",
                typeof(string),
                typeof(DateTimeAxisLabel),
                new PropertyMetadata(null, OnYearsIntervalStringFormatPropertyChanged));

        /// <summary>
        /// YearsIntervalStringFormatProperty property changed handler.
        /// </summary>
        /// <param name="d">DateTimeAxisLabel that changed its YearsIntervalStringFormat.</param>
        /// <param name="e">Event arguments.</param>
        private static void OnYearsIntervalStringFormatPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            DateTimeAxisLabel source = (DateTimeAxisLabel)d;
            source.OnYearsIntervalStringFormatPropertyChanged();
        }

        /// <summary>
        /// YearsIntervalStringFormatProperty property changed handler.
        /// </summary>    
        protected virtual void OnYearsIntervalStringFormatPropertyChanged()
        {
            UpdateFormattedContent();
        }
        #endregion public string YearsIntervalStringFormat

        #region public string MonthsIntervalStringFormat
        /// <summary>
        /// Gets or sets the format string to use when the interval is hours.
        /// </summary>
        public string MonthsIntervalStringFormat
        {
            get { return GetValue(MonthsIntervalStringFormatProperty) as string; }
            set { SetValue(MonthsIntervalStringFormatProperty, value); }
        }

        /// <summary>
        /// Identifies the MonthsIntervalStringFormat dependency property.
        /// </summary>
        public static readonly DependencyProperty MonthsIntervalStringFormatProperty =
            DependencyProperty.Register(
                "MonthsIntervalStringFormat",
                typeof(string),
                typeof(DateTimeAxisLabel),
                new PropertyMetadata(null, OnMonthsIntervalStringFormatPropertyChanged));

        /// <summary>
        /// MonthsIntervalStringFormatProperty property changed handler.
        /// </summary>
        /// <param name="d">DateTimeAxisLabel that changed its MonthsIntervalStringFormat.</param>
        /// <param name="e">Event arguments.</param>
        private static void OnMonthsIntervalStringFormatPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            DateTimeAxisLabel source = (DateTimeAxisLabel)d;
            source.OnMonthsIntervalStringFormatPropertyChanged();
        }

        /// <summary>
        /// MonthsIntervalStringFormatProperty property changed handler.
        /// </summary>    
        protected virtual void OnMonthsIntervalStringFormatPropertyChanged()
        {
            UpdateFormattedContent();
        }
        #endregion public string MonthsIntervalStringFormat

        #region public string WeeksIntervalStringFormat
        /// <summary>
        /// Gets or sets the format string to use when the interval is hours.
        /// </summary>
        public string WeeksIntervalStringFormat
        {
            get { return GetValue(WeeksIntervalStringFormatProperty) as string; }
            set { SetValue(WeeksIntervalStringFormatProperty, value); }
        }

        /// <summary>
        /// Identifies the WeeksIntervalStringFormat dependency property.
        /// </summary>
        public static readonly DependencyProperty WeeksIntervalStringFormatProperty =
            DependencyProperty.Register(
                "WeeksIntervalStringFormat",
                typeof(string),
                typeof(DateTimeAxisLabel),
                new PropertyMetadata(null, OnWeeksIntervalStringFormatPropertyChanged));

        /// <summary>
        /// WeeksIntervalStringFormatProperty property changed handler.
        /// </summary>
        /// <param name="d">DateTimeAxisLabel that changed its WeeksIntervalStringFormat.</param>
        /// <param name="e">Event arguments.</param>
        private static void OnWeeksIntervalStringFormatPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            DateTimeAxisLabel source = (DateTimeAxisLabel)d;
            source.OnWeeksIntervalStringFormatPropertyChanged();
        }

        /// <summary>
        /// WeeksIntervalStringFormatProperty property changed handler.
        /// </summary>    
        protected virtual void OnWeeksIntervalStringFormatPropertyChanged()
        {
            UpdateFormattedContent();
        }
        #endregion public string WeeksIntervalStringFormat

        #region public string DaysIntervalStringFormat
        /// <summary>
        /// Gets or sets the format string to use when the interval is hours.
        /// </summary>
        public string DaysIntervalStringFormat
        {
            get { return GetValue(DaysIntervalStringFormatProperty) as string; }
            set { SetValue(DaysIntervalStringFormatProperty, value); }
        }

        /// <summary>
        /// Identifies the DaysIntervalStringFormat dependency property.
        /// </summary>
        public static readonly DependencyProperty DaysIntervalStringFormatProperty =
            DependencyProperty.Register(
                "DaysIntervalStringFormat",
                typeof(string),
                typeof(DateTimeAxisLabel),
                new PropertyMetadata(null, OnDaysIntervalStringFormatPropertyChanged));

        /// <summary>
        /// DaysIntervalStringFormatProperty property changed handler.
        /// </summary>
        /// <param name="d">DateTimeAxisLabel that changed its DaysIntervalStringFormat.</param>
        /// <param name="e">Event arguments.</param>
        private static void OnDaysIntervalStringFormatPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            DateTimeAxisLabel source = (DateTimeAxisLabel)d;
            source.OnDaysIntervalStringFormatPropertyChanged();
        }

        /// <summary>
        /// DaysIntervalStringFormatProperty property changed handler.
        /// </summary>    
        protected virtual void OnDaysIntervalStringFormatPropertyChanged()
        {
            UpdateFormattedContent();
        }
        #endregion public string DaysIntervalStringFormat

        #region public string HoursIntervalStringFormat
        /// <summary>
        /// Gets or sets the format string to use when the interval is hours.
        /// </summary>
        public string HoursIntervalStringFormat
        {
            get { return GetValue(HoursIntervalStringFormatProperty) as string; }
            set { SetValue(HoursIntervalStringFormatProperty, value); }
        }

        /// <summary>
        /// Identifies the HoursIntervalStringFormat dependency property.
        /// </summary>
        public static readonly DependencyProperty HoursIntervalStringFormatProperty =
            DependencyProperty.Register(
                "HoursIntervalStringFormat",
                typeof(string),
                typeof(DateTimeAxisLabel),
                new PropertyMetadata(null, OnHoursIntervalStringFormatPropertyChanged));

        /// <summary>
        /// HoursIntervalStringFormatProperty property changed handler.
        /// </summary>
        /// <param name="d">DateTimeAxisLabel that changed its HoursIntervalStringFormat.</param>
        /// <param name="e">Event arguments.</param>
        private static void OnHoursIntervalStringFormatPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            DateTimeAxisLabel source = (DateTimeAxisLabel)d;
            source.OnHoursIntervalStringFormatPropertyChanged();
        }

        /// <summary>
        /// HoursIntervalStringFormatProperty property changed handler.
        /// </summary>    
        protected virtual void OnHoursIntervalStringFormatPropertyChanged()
        {
            UpdateFormattedContent();
        }
        #endregion public string HoursIntervalStringFormat

        #region public string MinutesIntervalStringFormat
        /// <summary>
        /// Gets or sets the format string to use when the interval is hours.
        /// </summary>
        public string MinutesIntervalStringFormat
        {
            get { return GetValue(MinutesIntervalStringFormatProperty) as string; }
            set { SetValue(MinutesIntervalStringFormatProperty, value); }
        }

        /// <summary>
        /// Identifies the MinutesIntervalStringFormat dependency property.
        /// </summary>
        public static readonly DependencyProperty MinutesIntervalStringFormatProperty =
            DependencyProperty.Register(
                "MinutesIntervalStringFormat",
                typeof(string),
                typeof(DateTimeAxisLabel),
                new PropertyMetadata(null, OnMinutesIntervalStringFormatPropertyChanged));

        /// <summary>
        /// MinutesIntervalStringFormatProperty property changed handler.
        /// </summary>
        /// <param name="d">DateTimeAxisLabel that changed its MinutesIntervalStringFormat.</param>
        /// <param name="e">Event arguments.</param>
        private static void OnMinutesIntervalStringFormatPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            DateTimeAxisLabel source = (DateTimeAxisLabel)d;
            source.OnMinutesIntervalStringFormatPropertyChanged();
        }

        /// <summary>
        /// MinutesIntervalStringFormatProperty property changed handler.
        /// </summary>    
        protected virtual void OnMinutesIntervalStringFormatPropertyChanged()
        {
            UpdateFormattedContent();
        }
        #endregion public string MinutesIntervalStringFormat

        #region public string SecondsIntervalStringFormat
        /// <summary>
        /// Gets or sets the format string to use when the interval is hours.
        /// </summary>
        public string SecondsIntervalStringFormat
        {
            get { return GetValue(SecondsIntervalStringFormatProperty) as string; }
            set { SetValue(SecondsIntervalStringFormatProperty, value); }
        }

        /// <summary>
        /// Identifies the SecondsIntervalStringFormat dependency property.
        /// </summary>
        public static readonly DependencyProperty SecondsIntervalStringFormatProperty =
            DependencyProperty.Register(
                "SecondsIntervalStringFormat",
                typeof(string),
                typeof(DateTimeAxisLabel),
                new PropertyMetadata(null, OnSecondsIntervalStringFormatPropertyChanged));

        /// <summary>
        /// SecondsIntervalStringFormatProperty property changed handler.
        /// </summary>
        /// <param name="d">DateTimeAxisLabel that changed its SecondsIntervalStringFormat.</param>
        /// <param name="e">Event arguments.</param>
        private static void OnSecondsIntervalStringFormatPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            DateTimeAxisLabel source = (DateTimeAxisLabel)d;
            source.OnSecondsIntervalStringFormatPropertyChanged();
        }

        /// <summary>
        /// SecondsIntervalStringFormatProperty property changed handler.
        /// </summary>    
        protected virtual void OnSecondsIntervalStringFormatPropertyChanged()
        {
            UpdateFormattedContent();
        }
        #endregion public string SecondsIntervalStringFormat

        #region public string MillisecondsIntervalStringFormat
        /// <summary>
        /// Gets or sets the format string to use when the interval is hours.
        /// </summary>
        public string MillisecondsIntervalStringFormat
        {
            get { return GetValue(MillisecondsIntervalStringFormatProperty) as string; }
            set { SetValue(MillisecondsIntervalStringFormatProperty, value); }
        }

        /// <summary>
        /// Identifies the MillisecondsIntervalStringFormat dependency property.
        /// </summary>
        public static readonly DependencyProperty MillisecondsIntervalStringFormatProperty =
            DependencyProperty.Register(
                "MillisecondsIntervalStringFormat",
                typeof(string),
                typeof(DateTimeAxisLabel),
                new PropertyMetadata(null, OnMillisecondsIntervalStringFormatPropertyChanged));

        /// <summary>
        /// MillisecondsIntervalStringFormatProperty property changed handler.
        /// </summary>
        /// <param name="d">DateTimeAxisLabel that changed its MillisecondsIntervalStringFormat.</param>
        /// <param name="e">Event arguments.</param>
        private static void OnMillisecondsIntervalStringFormatPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            DateTimeAxisLabel source = (DateTimeAxisLabel)d;
            source.OnMillisecondsIntervalStringFormatPropertyChanged();
        }

        /// <summary>
        /// MillisecondsIntervalStringFormatProperty property changed handler.
        /// </summary>    
        protected virtual void OnMillisecondsIntervalStringFormatPropertyChanged()
        {
            UpdateFormattedContent();
        }
        #endregion public string MillisecondsIntervalStringFormat

#if !SILVERLIGHT
        /// <summary>
        /// Initializes the static members of the DateTimeAxisLabel class.
        /// </summary>
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = "Dependency properties are initialized in-line.")]
        static DateTimeAxisLabel()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DateTimeAxisLabel), new FrameworkPropertyMetadata(typeof(DateTimeAxisLabel)));
        }

#endif    

        /// <summary>
        /// Instantiates a new instance of the DateTimeAxisLabel class.
        /// </summary>
        public DateTimeAxisLabel()
        {
#if SILVERLIGHT
            this.DefaultStyleKey = typeof(DateTimeAxisLabel);
#endif
        }

        /// <summary>
        /// Updates the formatted text.
        /// </summary>
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Justification = "Code is not overly complex.")]
        [OpenSilver.NotImplemented]
        protected override void UpdateFormattedContent()
        {
        }
    }
}