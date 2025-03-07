﻿// (c) Copyright Microsoft Corporation.
// This source is subject to the Microsoft Public License (Ms-PL).
// Please see http://go.microsoft.com/fwlink/?LinkID=131993 for details.
// All other rights reserved.

using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
#if MIGRATION
using System.Windows.Shapes;
#else
using System;
using Windows.Foundation;
using Windows.UI.Xaml.Shapes;
#endif

#if MIGRATION
namespace System.Windows.Controls.DataVisualization.Charting
#else
namespace Windows.UI.Xaml.Controls.DataVisualization.Charting
#endif
{
    /// <summary>
    /// An axis that displays numeric values.
    /// </summary>
    [StyleTypedProperty(Property = "GridLineStyle", StyleTargetType = typeof(Line))]
    [StyleTypedProperty(Property = "MajorTickMarkStyle", StyleTargetType = typeof(Line))]
    [StyleTypedProperty(Property = "MinorTickMarkStyle", StyleTargetType = typeof(Line))]
    [StyleTypedProperty(Property = "AxisLabelStyle", StyleTargetType = typeof(DateTimeAxisLabel))]
    [StyleTypedProperty(Property = "TitleStyle", StyleTargetType = typeof(Title))]
    [TemplatePart(Name = AxisGridName, Type = typeof(Grid))]
    [TemplatePart(Name = AxisTitleName, Type = typeof(Title))]
    [OpenSilver.NotImplemented]
    public class DateTimeAxis : RangeAxis
    {
        #region public DateTime? ActualMaximum
        /// <summary>
        /// Gets the actual maximum value plotted on the chart.
        /// </summary>
        public DateTime? ActualMaximum
        {
            get { return (DateTime?)GetValue(ActualMaximumProperty); }
            private set { SetValue(ActualMaximumProperty, value); }
        }

        /// <summary>
        /// Identifies the ActualMaximum dependency property.
        /// </summary>
        public static readonly DependencyProperty ActualMaximumProperty =
            DependencyProperty.Register(
                "ActualMaximum",
                typeof(DateTime?),
                typeof(DateTimeAxis),
                null);
        #endregion public DateTime? ActualMaximum

        #region public DateTime? ActualMinimum
        /// <summary>
        /// Gets the actual maximum value plotted on the chart.
        /// </summary>
        public DateTime? ActualMinimum
        {
            get { return (DateTime?)GetValue(ActualMinimumProperty); }
            private set { SetValue(ActualMinimumProperty, value); }
        }

        /// <summary>
        /// Identifies the ActualMinimum dependency property.
        /// </summary>
        public static readonly DependencyProperty ActualMinimumProperty =
            DependencyProperty.Register(
                "ActualMinimum",
                typeof(DateTime?),
                typeof(DateTimeAxis),
                null);
        #endregion public DateTime? ActualMinimum

        #region public DateTime? Maximum
        /// <summary>
        /// Gets or sets the maximum value plotted on the axis.
        /// </summary>
        [TypeConverter(typeof(NullableConverter<DateTime>))]
        public DateTime? Maximum
        {
            get { return (DateTime?)GetValue(MaximumProperty); }
            set { SetValue(MaximumProperty, value); }
        }

        /// <summary>
        /// Identifies the Maximum dependency property.
        /// </summary>
        public static readonly DependencyProperty MaximumProperty =
            DependencyProperty.Register(
                "Maximum",
                typeof(DateTime?),
                typeof(DateTimeAxis),
                new PropertyMetadata(null, OnMaximumPropertyChanged));

        /// <summary>
        /// MaximumProperty property changed handler.
        /// </summary>
        /// <param name="d">DateTimeAxis2 that changed its Maximum.</param>
        /// <param name="e">Event arguments.</param>
        private static void OnMaximumPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            DateTimeAxis source = (DateTimeAxis)d;
            DateTime? newValue = (DateTime?)e.NewValue;
            source.OnMaximumPropertyChanged(newValue);
        }

        /// <summary>
        /// MaximumProperty property changed handler.
        /// </summary>
        /// <param name="newValue">New value.</param>
        private void OnMaximumPropertyChanged(DateTime? newValue)
        {
            this.ProtectedMaximum = newValue;
        }
        #endregion public DateTime? Maximum

        #region public DateTime? Minimum
        /// <summary>
        /// Gets or sets the minimum value to plot on the axis.
        /// </summary>
        [TypeConverter(typeof(NullableConverter<DateTime>))]
        public DateTime? Minimum
        {
            get { return (DateTime?)GetValue(MinimumProperty); }
            set { SetValue(MinimumProperty, value); }
        }

        /// <summary>
        /// Identifies the Minimum dependency property.
        /// </summary>
        public static readonly DependencyProperty MinimumProperty =
            DependencyProperty.Register(
                "Minimum",
                typeof(DateTime?),
                typeof(DateTimeAxis),
                new PropertyMetadata(null, OnMinimumPropertyChanged));

        /// <summary>
        /// MinimumProperty property changed handler.
        /// </summary>
        /// <param name="d">DateTimeAxis2 that changed its Minimum.</param>
        /// <param name="e">Event arguments.</param>
        private static void OnMinimumPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            DateTimeAxis source = (DateTimeAxis)d;
            DateTime? newValue = (DateTime?)e.NewValue;
            source.OnMinimumPropertyChanged(newValue);
        }

        /// <summary>
        /// MinimumProperty property changed handler.
        /// </summary>
        /// <param name="newValue">New value.</param>
        private void OnMinimumPropertyChanged(DateTime? newValue)
        {
            this.ProtectedMinimum = newValue;
        }
        #endregion public DateTime? Minimum

        #region public double? Interval
        /// <summary>
        /// Gets or sets the axis interval.
        /// </summary>
        [TypeConverter(typeof(NullableConverter<double>))]
        public double? Interval
        {
            get { return (double?)GetValue(IntervalProperty); }
            set { SetValue(IntervalProperty, value); }
        }

        /// <summary>
        /// Identifies the Interval dependency property.
        /// </summary>
        public static readonly DependencyProperty IntervalProperty =
            DependencyProperty.Register(
                "Interval",
                typeof(double?),
                typeof(DateTimeAxis),
                new PropertyMetadata(null, OnIntervalPropertyChanged));

        /// <summary>
        /// IntervalProperty property changed handler.
        /// </summary>
        /// <param name="d">DateTimeAxis2 that changed its Interval.</param>
        /// <param name="e">Event arguments.</param>
        private static void OnIntervalPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            DateTimeAxis source = (DateTimeAxis)d;
            source.OnIntervalPropertyChanged();
        }

        /// <summary>
        /// IntervalProperty property changed handler.
        /// </summary>
        private void OnIntervalPropertyChanged()
        {
            Invalidate();
        }
        #endregion public double? Interval

        #region public double ActualInterval
        /// <summary>
        /// Gets the actual interval.
        /// </summary>
        public double ActualInterval
        {
            get { return (double)GetValue(ActualIntervalProperty); }
            private set { SetValue(ActualIntervalProperty, value); }
        }

        /// <summary>
        /// Identifies the ActualInterval dependency property.
        /// </summary>
        public static readonly DependencyProperty ActualIntervalProperty =
            DependencyProperty.Register(
                "ActualInterval",
                typeof(double),
                typeof(DateTimeAxis),
                new PropertyMetadata(double.NaN));

        #endregion public double ActualInterval

        #region public DateTimeIntervalType IntervalType
        /// <summary>
        /// Gets or sets the interval to use for the axis.
        /// </summary>
        public DateTimeIntervalType IntervalType
        {
            get { return (DateTimeIntervalType)GetValue(IntervalTypeProperty); }
            set { SetValue(IntervalTypeProperty, value); }
        }

        /// <summary>
        /// Identifies the InternalIntervalType dependency property.
        /// </summary>
        public static readonly DependencyProperty IntervalTypeProperty =
            DependencyProperty.Register(
                "IntervalType",
                typeof(DateTimeIntervalType),
                typeof(DateTimeAxis),
                new PropertyMetadata(DateTimeIntervalType.Auto, OnIntervalTypePropertyChanged));

        /// <summary>
        /// IntervalTypeProperty property changed handler.
        /// </summary>
        /// <param name="d">DateTimeAxis that changed its InternalIntervalType.</param>
        /// <param name="e">Event arguments.</param>
        private static void OnIntervalTypePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            DateTimeAxis source = (DateTimeAxis)d;
            DateTimeIntervalType newValue = (DateTimeIntervalType)e.NewValue;
            source.OnIntervalTypePropertyChanged(newValue);
        }

        /// <summary>
        /// IntervalTypeProperty property changed handler.
        /// </summary>
        /// <param name="newValue">New value.</param>
        private void OnIntervalTypePropertyChanged(DateTimeIntervalType newValue)
        {
            this.ActualIntervalType = newValue;
            Invalidate();
        }
        #endregion public DateTimeIntervalType IntervalType

        #region public DateTimeIntervalType ActualIntervalType
        /// <summary>
        /// Gets or sets the actual interval type.
        /// </summary>
        private DateTimeIntervalType ActualIntervalType
        {
            get { return (DateTimeIntervalType)GetValue(ActualIntervalTypeProperty); }
            set { SetValue(ActualIntervalTypeProperty, value); }
        }

        /// <summary>
        /// Identifies the ActualIntervalType dependency property.
        /// </summary>
        private static readonly DependencyProperty ActualIntervalTypeProperty =
            DependencyProperty.Register(
                "ActualIntervalType",
                typeof(DateTimeIntervalType),
                typeof(DateTimeAxis),
                new PropertyMetadata(DateTimeIntervalType.Auto));

        #endregion public DateTimeIntervalType ActualIntervalType

        /// <summary>
        /// Gets the origin value on the axis.
        /// </summary>
        protected override IComparable Origin
        {
            get { return null; }
        }

        /// <summary>
        /// Instantiates a new instance of the DateTimeAxis2 class.
        /// </summary>
        [OpenSilver.NotImplemented]
        public DateTimeAxis()
        {
        }

        /// <summary>
        /// Creates a new instance of the DateTimeAxisLabel class.
        /// </summary>
        /// <returns>Returns  a new instance of the DateTimeAxisLabel class.
        /// </returns>
        protected override Control CreateAxisLabel()
        {
            return new DateTimeAxisLabel();
        }

        /// <summary>
        /// Prepares an instance of the DateTimeAxisLabel class by setting its
        /// IntervalType property.
        /// </summary>
        /// <param name="label">An instance of the DateTimeAxisLabel class.
        /// </param>
        /// <param name="dataContext">The data context to assign to the label.
        /// </param>
        protected override void PrepareAxisLabel(Control label, object dataContext)
        {
            DateTimeAxisLabel dateTimeAxisLabel = label as DateTimeAxisLabel;

            if (dateTimeAxisLabel != null)
            {
                dateTimeAxisLabel.IntervalType = ActualIntervalType;
            }
            base.PrepareAxisLabel(label, dataContext);
        }

        /// <summary>
        /// Returns a value indicating whether a value can plot.
        /// </summary>
        /// <param name="value">The value to plot.</param>
        /// <returns>A value indicating whether a value can plot.</returns>
        [OpenSilver.NotImplemented]
        public override bool CanPlot(object value)
        {
            return false;
        }

        /// <summary>
        /// Returns the actual interval to use to determine which values are 
        /// displayed in the axis.
        /// </summary>
        /// <param name="availableSize">The available size.</param>
        /// <returns>The actual interval to use to determine which values are 
        /// displayed in the axis.
        /// </returns>
        [OpenSilver.NotImplemented]
        private double CalculateActualInterval(Size availableSize)
        {
            return 0;
        }

        /// <summary>
        /// Returns a sequence of major values.
        /// </summary>
        /// <param name="availableSize">The available size.</param>
        /// <returns>A sequence of major values.</returns>
        [OpenSilver.NotImplemented]
        protected virtual IEnumerable<DateTime> GetMajorAxisValues(Size availableSize)
        {
            return Enumerable.Empty<DateTime>();
        }

        /// <summary>
        /// Returns a sequence of values to create major tick marks for.
        /// </summary>
        /// <param name="availableSize">The available size.</param>
        /// <returns>A sequence of values to create major tick marks for.
        /// </returns>
        [OpenSilver.NotImplemented]
        protected override IEnumerable<IComparable> GetMajorTickMarkValues(Size availableSize)
        {
            return Enumerable.Empty<IComparable>();
        }

        /// <summary>
        /// Returns a sequence of values to plot on the axis.
        /// </summary>
        /// <param name="availableSize">The available size.</param>
        /// <returns>A sequence of values to plot on the axis.</returns>
        [OpenSilver.NotImplemented]
        protected override IEnumerable<IComparable> GetLabelValues(Size availableSize)
        {
            return Enumerable.Empty<IComparable>();
        }

        /// <summary>
        /// This method accepts a date time and increments it.
        /// </summary>
        /// <param name="date">A date time.</param>
        /// <param name="interval">The interval used to increment the date time.
        /// </param>
        /// <returns>The new date time.</returns>
        private DateTime IncrementDateTime(DateTime date, double interval)
        {
            DateTimeIntervalType intervalType = this.ActualIntervalType;
            TimeSpan span = new TimeSpan(0);
            DateTime result;

            if (intervalType == DateTimeIntervalType.Days)
            {
                span = TimeSpan.FromDays(interval);
            }
            else if (intervalType == DateTimeIntervalType.Hours)
            {
                span = TimeSpan.FromHours(interval);
            }
            else if (intervalType == DateTimeIntervalType.Milliseconds)
            {
                span = TimeSpan.FromMilliseconds(interval);
            }
            else if (intervalType == DateTimeIntervalType.Seconds)
            {
                span = TimeSpan.FromSeconds(interval);
            }
            else if (intervalType == DateTimeIntervalType.Minutes)
            {
                span = TimeSpan.FromMinutes(interval);
            }
            else if (intervalType == DateTimeIntervalType.Weeks)
            {
                span = TimeSpan.FromDays(7.0 * interval);
            }
            else if (intervalType == DateTimeIntervalType.Months)
            {
                // Special case handling when current date point
                // to the last day of the month
                bool lastMonthDay = false;
                if (date.Day == DateTime.DaysInMonth(date.Year, date.Month))
                {
                    lastMonthDay = true;
                }

                // Add specified amount of months
                date = date.AddMonths((int)Math.Floor(interval));
                span = TimeSpan.FromDays(30.0 * (interval - Math.Floor(interval)));

                // Check if last month of the day was used
                if (lastMonthDay && span.Ticks == 0)
                {
                    // Make sure the last day of the month is selected
                    int daysInMobth = DateTime.DaysInMonth(date.Year, date.Month);
                    date = date.AddDays(daysInMobth - date.Day);
                }
            }
            else if (intervalType == DateTimeIntervalType.Years)
            {
                date = date.AddYears((int)Math.Floor(interval));
                span = TimeSpan.FromDays(365.0 * (interval - Math.Floor(interval)));
            }

            result = date.Add(span);

            return result;
        }

        /// <summary>
        /// Adjusts the beginning of the first interval depending on the type and size.
        /// </summary>
        /// <param name="start">Original start point.</param>
        /// <param name="intervalSize">Interval size.</param>
        /// <param name="type">Type of the interval (Month, Year, ...).</param>
        /// <returns>
        /// Adjusted interval start position.
        /// </returns>
        private static DateTime AlignIntervalStart(DateTime start, double intervalSize, DateTimeIntervalType type)
        {
            // Do not adjust start position for these interval type
            if (type == DateTimeIntervalType.Auto)
            {
                return start;
            }

            // Get the beginning of the interval depending on type
            DateTime newStartDate = start;

            // Adjust the months interval depending on size
            if (intervalSize > 0.0 && intervalSize != 1.0)
            {
                if (type == DateTimeIntervalType.Months && intervalSize <= 12.0 && intervalSize > 1)
                {
                    // Make sure that the beginning is aligned correctly for cases
                    // like quarters and half years
                    DateTime resultDate = newStartDate;
                    DateTime sizeAdjustedDate = new DateTime(newStartDate.Year, 1, 1, 0, 0, 0);
                    while (sizeAdjustedDate < newStartDate)
                    {
                        resultDate = sizeAdjustedDate;
                        sizeAdjustedDate = sizeAdjustedDate.AddMonths((int)intervalSize);
                    }

                    newStartDate = resultDate;
                    return newStartDate;
                }
            }

            // Check interval type
            switch (type)
            {
                case DateTimeIntervalType.Years:
                    int year = (int)((int)(newStartDate.Year / intervalSize) * intervalSize);
                    if (year <= 0)
                    {
                        year = 1;
                    }
                    newStartDate = new DateTime(year, 1, 1, 0, 0, 0);
                    break;

                case DateTimeIntervalType.Months:
                    int month = (int)((int)(newStartDate.Month / intervalSize) * intervalSize);
                    if (month <= 0)
                    {
                        month = 1;
                    }
                    newStartDate = new DateTime(newStartDate.Year, month, 1, 0, 0, 0);
                    break;

                case DateTimeIntervalType.Days:
                    int day = (int)((int)(newStartDate.Day / intervalSize) * intervalSize);
                    if (day <= 0)
                    {
                        day = 1;
                    }
                    newStartDate = new DateTime(newStartDate.Year, newStartDate.Month, day, 0, 0, 0);
                    break;

                case DateTimeIntervalType.Hours:
                    int hour = (int)((int)(newStartDate.Hour / intervalSize) * intervalSize);
                    newStartDate = new DateTime(
                        newStartDate.Year,
                        newStartDate.Month,
                        newStartDate.Day,
                        hour,
                        0,
                        0);
                    break;

                case DateTimeIntervalType.Minutes:
                    int minute = (int)((int)(newStartDate.Minute / intervalSize) * intervalSize);
                    newStartDate = new DateTime(
                        newStartDate.Year,
                        newStartDate.Month,
                        newStartDate.Day,
                        newStartDate.Hour,
                        minute,
                        0);
                    break;

                case DateTimeIntervalType.Seconds:
                    int second = (int)((int)(newStartDate.Second / intervalSize) * intervalSize);
                    newStartDate = new DateTime(
                        newStartDate.Year,
                        newStartDate.Month,
                        newStartDate.Day,
                        newStartDate.Hour,
                        newStartDate.Minute,
                        second,
                        0);
                    break;

                case DateTimeIntervalType.Milliseconds:
                    int milliseconds = (int)((int)(newStartDate.Millisecond / intervalSize) * intervalSize);
                    newStartDate = new DateTime(
                        newStartDate.Year,
                        newStartDate.Month,
                        newStartDate.Day,
                        newStartDate.Hour,
                        newStartDate.Minute,
                        newStartDate.Second,
                        milliseconds);
                    break;

                case DateTimeIntervalType.Weeks:

                    // Elements that have interval set to weeks should be aligned to the 
                    // nearest start of week no matter how many weeks is the interval.
                    newStartDate = new DateTime(
                        newStartDate.Year,
                        newStartDate.Month,
                        newStartDate.Day,
                        0,
                        0,
                        0);

                    newStartDate = newStartDate.AddDays(-((int)newStartDate.DayOfWeek));
                    break;
            }

            return newStartDate;
        }

        /// <summary>
        /// Recalculates a DateTime interval obtained from maximum and minimum.
        /// </summary>
        /// <param name="minimum">The minimum.</param>
        /// <param name="maximum">The maximum.</param>
        /// <param name="type">Date time interval type.</param>
        /// <param name="availableSize">The available size.</param>
        /// <returns>Auto Interval.</returns>
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Justification = "The method should inspect all variations of time span (millisec to year) and contains long case. Otherwise is simple and readable.")]
        private double CalculateDateTimeInterval(DateTime minimum, DateTime maximum, out DateTimeIntervalType type, Size availableSize)
        {
            DateTime dateTimeMin = minimum;
            DateTime dateTimeMax = maximum;
            TimeSpan timeSpan = dateTimeMax.Subtract(dateTimeMin);

            // this algorithm is designed to return close to 10 intervals.
            // we need to align the time span for PrefferedNumberOfIntervals
            double maxIntervals = Orientation == AxisOrientation.X ? MaximumAxisIntervalsPer200Pixels * 0.8 : MaximumAxisIntervalsPer200Pixels;
            double rangeMultiplicator = GetLength(availableSize) / (200 * 10 / maxIntervals);
            timeSpan = new TimeSpan((long)((double)timeSpan.Ticks / rangeMultiplicator));

            // Minutes
            double inter = timeSpan.TotalMinutes;

            // For Range less than 60 seconds interval is 5 sec
            if (inter <= 1.0)
            {
                // Milli Seconds
                double milliSeconds = timeSpan.TotalMilliseconds;
                if (milliSeconds <= 10)
                {
                    type = DateTimeIntervalType.Milliseconds;
                    return 1;
                }
                if (milliSeconds <= 50)
                {
                    type = DateTimeIntervalType.Milliseconds;
                    return 4;
                }
                if (milliSeconds <= 200)
                {
                    type = DateTimeIntervalType.Milliseconds;
                    return 20;
                }
                if (milliSeconds <= 500)
                {
                    type = DateTimeIntervalType.Milliseconds;
                    return 50;
                }

                // Seconds
                double seconds = timeSpan.TotalSeconds;

                if (seconds <= 7)
                {
                    type = DateTimeIntervalType.Seconds;
                    return 1;
                }
                else if (seconds <= 15)
                {
                    type = DateTimeIntervalType.Seconds;
                    return 2;
                }
                else if (seconds <= 30)
                {
                    type = DateTimeIntervalType.Seconds;
                    return 5;
                }
                else if (seconds <= 60)
                {
                    type = DateTimeIntervalType.Seconds;
                    return 10;
                }
            }
            else if (inter <= 2.0)
            {
                // For Range less than 120 seconds interval is 10 sec
                type = DateTimeIntervalType.Seconds;
                return 20;
            }
            else if (inter <= 3.0)
            {
                // For Range less than 180 seconds interval is 30 sec
                type = DateTimeIntervalType.Seconds;
                return 30;
            }
            else if (inter <= 10)
            {
                // For Range less than 10 minutes interval is 1 min
                type = DateTimeIntervalType.Minutes;
                return 1;
            }
            else if (inter <= 20)
            {
                // For Range less than 20 minutes interval is 1 min
                type = DateTimeIntervalType.Minutes;
                return 2;
            }
            else if (inter <= 60)
            {
                // For Range less than 60 minutes interval is 5 min
                type = DateTimeIntervalType.Minutes;
                return 5;
            }
            else if (inter <= 120)
            {
                // For Range less than 120 minutes interval is 10 min
                type = DateTimeIntervalType.Minutes;
                return 10;
            }
            else if (inter <= 180)
            {
                // For Range less than 180 minutes interval is 30 min
                type = DateTimeIntervalType.Minutes;
                return 30;
            }
            else if (inter <= 60 * 12)
            {
                // For Range less than 12 hours interval is 1 hour
                type = DateTimeIntervalType.Hours;
                return 1;
            }
            else if (inter <= 60 * 24)
            {
                // For Range less than 24 hours interval is 4 hour
                type = DateTimeIntervalType.Hours;
                return 4;
            }
            else if (inter <= 60 * 24 * 2)
            {
                // For Range less than 2 days interval is 6 hour
                type = DateTimeIntervalType.Hours;
                return 6;
            }
            else if (inter <= 60 * 24 * 3)
            {
                // For Range less than 3 days interval is 12 hour
                type = DateTimeIntervalType.Hours;
                return 12;
            }
            else if (inter <= 60 * 24 * 10)
            {
                // For Range less than 10 days interval is 1 day
                type = DateTimeIntervalType.Days;
                return 1;
            }
            else if (inter <= 60 * 24 * 20)
            {
                // For Range less than 20 days interval is 2 day
                type = DateTimeIntervalType.Days;
                return 2;
            }
            else if (inter <= 60 * 24 * 30)
            {
                // For Range less than 30 days interval is 3 day
                type = DateTimeIntervalType.Days;
                return 3;
            }
            else if (inter <= 60 * 24 * 30.5 * 2)
            {
                // For Range less than 2 months interval is 1 week
                type = DateTimeIntervalType.Weeks;
                return 1;
            }
            else if (inter <= 60 * 24 * 30.5 * 5)
            {
                // For Range less than 5 months interval is 2weeks
                type = DateTimeIntervalType.Weeks;
                return 2;
            }
            else if (inter <= 60 * 24 * 30.5 * 12)
            {
                // For Range less than 12 months interval is 1 month
                type = DateTimeIntervalType.Months;
                return 1;
            }
            else if (inter <= 60 * 24 * 30.5 * 24)
            {
                // For Range less than 24 months interval is 3 month
                type = DateTimeIntervalType.Months;
                return 3;
            }
            else if (inter <= 60 * 24 * 30.5 * 48)
            {
                // For Range less than 48 months interval is 6 months 
                type = DateTimeIntervalType.Months;
                return 6;
            }

            // For Range more than 48 months interval is year 
            type = DateTimeIntervalType.Years;
            double years = inter / 60 / 24 / 365;
            if (years < 5)
            {
                return 1;
            }
            else if (years < 10)
            {
                return 2;
            }

            // Make a correction of the interval
            return Math.Floor(years / 5);
        }
    }
}