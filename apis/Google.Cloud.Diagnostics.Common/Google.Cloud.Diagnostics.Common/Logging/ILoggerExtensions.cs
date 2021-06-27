// Copyright 2021 Google LLC
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     https://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax;
using Google.Cloud.Logging.V2;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// Extensions for <see cref="ILogger"/> to allow augmenting the logged information with contextual data.
    /// <see cref="GoogleLogger"/>" will add the information to the <see cref="LogEntry"/> that is sent to
    /// Google Cloud Logging.
    /// For the consumption of other loggers, the information will be included in newly created scopes
    /// at the moment of logging, in a format that all loggers should understand.
    /// </summary>
    public static class ILoggerExtensions
    {
        /// <summary>
        /// <para>
        /// Adds labels to the returned logger that may be included with every subsequent log.
        /// How this information is included will depend on the actual <paramref name="logger"/>.
        /// <see cref="GoogleLogger"/>" will include this information in <see cref="LogEntry.Labels"/>.
        /// For the consumption of other loggers, the information will be included in newly created scopes
        /// at the moment of logging, in a format that all loggers should understand. 
        /// </para>
        /// <para>
        /// If <paramref name="logger"/> had already been augmented with labels, the old labels will be replaced
        /// by the new ones on the returned <see cref="ILogger"/>.
        /// </para>
        /// </summary>
        public static ILogger WithLabels(this ILogger logger, params KeyValuePair<string, string>[] labels) =>
            WithLabels(logger, labels.AsEnumerable());

        /// <summary>
        /// <para>
        /// Adds labels to the returned logger that may be included with every subsequent log.
        /// How this information is included will depend on the actual <paramref name="logger"/>.
        /// <see cref="GoogleLogger"/>" will include this information in <see cref="LogEntry.Labels"/>.
        /// For the consumption of other loggers, the information will be included in newly created scopes
        /// at the moment of logging, in a format that all loggers should understand. 
        /// </para>
        /// <para>
        /// If <paramref name="logger"/> had already been augmented with labels, the old labels will be replaced
        /// by the new ones on the returned <see cref="ILogger"/>.
        /// </para>
        /// </summary>
        public static ILogger WithLabels(this ILogger logger, IEnumerable<KeyValuePair<string, string>> labels) =>
            GaxPreconditions.CheckNotNull(logger, nameof(logger)) switch
            {
                AugmentedLogger augmented => augmented.WithLabels(labels),
                _ => AugmentedLogger.ForLabels(logger, labels)
            };

        /// <summary>
        /// <para>
        /// Adds labels to the returned logger that may be included with every subsequent log.
        /// How this information is included will depend on the actual <paramref name="logger"/>.
        /// <see cref="GoogleLogger"/>" will include this information in <see cref="LogEntry.Labels"/>.
        /// For the consumption of other loggers, the information will be included in newly created scopes
        /// at the moment of logging, in a format that all loggers should understand. 
        /// </para>
        /// <para>
        /// If <paramref name="logger"/> had already been augmented with labels, <paramref name="labels"/>
        /// will be added to the existing ones on the returned <see cref="ILogger"/>
        /// </para>
        /// </summary>
        public static ILogger WithAddedLabels(this ILogger logger, params KeyValuePair<string, string>[] labels) =>
            WithAddedLabels(logger, labels.AsEnumerable());

        /// <summary>
        /// <para>
        /// Adds labels to the returned logger that may be included with every subsequent log.
        /// How this information is included will depend on the actual <paramref name="logger"/>.
        /// <see cref="GoogleLogger"/>" will include this information in <see cref="LogEntry.Labels"/>.
        /// For the consumption of other loggers, the information will be included in newly created scopes
        /// at the moment of logging, in a format that all loggers should understand. 
        /// </para>
        /// <para>
        /// If <paramref name="logger"/> had already been augmented with labels, <paramref name="labels"/>
        /// will be added to the existing ones on the returned <see cref="ILogger"/>
        /// </para>
        /// </summary>
        public static ILogger WithAddedLabels(this ILogger logger, IEnumerable<KeyValuePair<string, string>> labels) =>
            GaxPreconditions.CheckNotNull(logger, nameof(logger)) switch
            {
                AugmentedLogger augmented => augmented.WithAddedLabels(labels),
                _ => AugmentedLogger.ForLabels(logger, labels)
            };

        private class AugmentedLogger : ILogger
        {
            private ILogger _innerLogger;
            private IEnumerable<KeyValuePair<string, string>> _labels;

            private AugmentedLogger(ILogger logger, IEnumerable<KeyValuePair<string, string>> labels) =>
                (_innerLogger, _labels) = 
                (GaxPreconditions.CheckNotNull(logger, nameof(logger)), GaxPreconditions.CheckNotNull(labels, nameof(labels)));

            public static AugmentedLogger ForLabels(ILogger logger, IEnumerable<KeyValuePair<string, string>> labels) =>
                new AugmentedLogger(logger, labels);

            public AugmentedLogger WithLabels(IEnumerable<KeyValuePair<string, string>> labels) =>
                new AugmentedLogger(_innerLogger, labels);

            public AugmentedLogger WithAddedLabels(IEnumerable<KeyValuePair<string, string>> extraLabels) =>
                new AugmentedLogger(_innerLogger, _labels.Concat(GaxPreconditions.CheckNotNull(extraLabels, nameof(extraLabels))));

            public IDisposable BeginScope<TState>(TState state) => _innerLogger.BeginScope(state);

            public bool IsEnabled(LogLevel logLevel) => _innerLogger.IsEnabled(logLevel);

            public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
            {
                using (_innerLogger.BeginScope(new LabellingScopeState(_labels)))
                {
                    _innerLogger.Log(logLevel, eventId, state, exception, formatter);
                }
            }
        }
    }
}
