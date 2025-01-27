using System;
using System.Collections.Generic;

namespace CefSharp.Dom
{
    /// <summary>
    /// <seealso cref="IDevToolsContext.Metrics"/> arguments.
    /// </summary>
    public class MetricEventArgs : EventArgs
    {
        /// <summary>
        /// Gets the title.
        /// </summary>
        /// <value>The title.</value>
        public string Title { get; }
        /// <summary>
        /// Gets the metrics.
        /// </summary>
        /// <value>The metrics.</value>
        public Dictionary<string, decimal> Metrics { get; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MetricEventArgs"/> class.
        /// </summary>
        /// <param name="title">Title.</param>
        /// <param name="metrics">Metrics.</param>
        public MetricEventArgs(string title, Dictionary<string, decimal> metrics)
        {
            Title = title;
            Metrics = metrics;
        }
    }
}
