using System.Collections.Generic;

namespace Google.Cloud.Diagnostics.AspNetCore
{
    /// <summary>
    /// Provides a hook to augment labels when a log entry is being logged.
    /// </summary>
    public interface ILogEntryLabelProvider
    {
        /// <summary>
        /// Invokes the provider to augment log entry labels.
        /// </summary>
        /// <param name="labels">A dictionary of log entry labels.</param>
        void Invoke(Dictionary<string, string> labels);
    }
}
