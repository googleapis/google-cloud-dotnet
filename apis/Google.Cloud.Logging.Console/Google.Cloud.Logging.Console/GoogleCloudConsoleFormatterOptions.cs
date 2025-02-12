// Copyright 2020 Google LLC
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

using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace Google.Cloud.Logging.Console;

/// <summary>
/// Options for <see cref="GoogleCloudConsoleFormatter"/>.
/// </summary>
public class GoogleCloudConsoleFormatterOptions : ConsoleFormatterOptions
{
    // Possible options:
    // - JSON property names (category, message etc)
    // - Severity names? (Seems unlikely)
    // - JsonTextWriterOptions (for debugging)

    // That said, for actual Google Cloud Logging, very few things are really flexible -
    // the property names for state and scopes are the only things that come to mind.

    /// <summary>
    /// The ID of the Google Cloud Project where trace data is being written to Google Cloud Trace.
    /// Optional. Set this property to enable Google Cloud Trace and Logging correlation.
    /// </summary>
    /// <remarks>
    /// This property has no effect on where log entries are written to.
    /// It also has no effect on whether trace information is actually exported to Google Cloud Trace or to which Google Cloud Project traces are exported to.
    /// When set, this property informs the Console Logger to include trace context information (if any) on the log entries, assuming the trace information is being stored on the specified Google Cloud Project.
    /// Note that when running your code in Google Cloud, for instance in Google Cloud Run, trace information is automatically collected and exported by the runtime.
    /// </remarks>
    public string TraceGoogleCloudProjectId { get; set; }


    /// <summary>
    /// The service identifier that will be used to annotate the logs. Recommended.
    /// Should be set to the service name plus optionally the environment name.
    /// <see href="https://cloud.google.com/error-reporting/reference/rest/v1beta1/ServiceContext"/>
    /// </summary>
    public string ServiceIdentifier { get; set; }

    /// <summary>
    /// The version of the service that is being logged. Optional.
    /// <see href="https://cloud.google.com/error-reporting/reference/rest/v1beta1/ServiceContext"/>
    /// </summary>
    public string ServiceVersion { get; set; }

    /// <summary>
    /// The minimum severity level that should trigger Google Cloud Error Reporting.
    /// <see href="https://cloud.google.com/error-reporting/docs/formatting-error-messages#log-text"/>
    /// </summary>
    public LogLevel ErrorReportingLogLevel { get; set; } = LogLevel.Error;
}
