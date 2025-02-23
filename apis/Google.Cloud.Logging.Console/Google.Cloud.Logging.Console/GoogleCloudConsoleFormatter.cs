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
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Logging.Console;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace Google.Cloud.Logging.Console;

/// <summary>
/// Console formatter for use with Google Cloud Logging.
/// </summary>
public sealed class GoogleCloudConsoleFormatter : ConsoleFormatter, IDisposable
{
    /// <summary>
    /// We don't get the current state of a Utf8JsonWriter, so when writing out scopes,
    /// we need to use the current depth of the writer to determine whether or
    /// not we've already started writing out the scopes.
    /// </summary>
    private const int NoScopesDepth = 1;

    /// <summary>
    /// The name for the Google Cloud console formatter.
    /// </summary>
    public static string FormatterName { get; } = "google-cloud";

    private static readonly JsonEncodedText s_messagePropertyName = JsonEncodedText.Encode("message");
    private static readonly JsonEncodedText s_exceptionPropertyName = JsonEncodedText.Encode("exception");
    private static readonly JsonEncodedText s_severityPropertyName = JsonEncodedText.Encode("severity");
    private static readonly JsonEncodedText s_categoryPropertyName = JsonEncodedText.Encode("category");
    private static readonly JsonEncodedText s_scopesPropertyName = JsonEncodedText.Encode("scopes");
    private static readonly JsonEncodedText s_formatParametersPropertyName = JsonEncodedText.Encode("format_parameters");

    // `trace`, `spanId` and `trace_sampled` are special JSON log fields used for log trace correlation.
    // Please see https://cloud.google.com/logging/docs/structured-logging#special-payload-fields for more information.
    private static readonly JsonEncodedText s_tracePropertyName = JsonEncodedText.Encode("logging.googleapis.com/trace");
    private static readonly JsonEncodedText s_spanIdPropertyName = JsonEncodedText.Encode("logging.googleapis.com/spanId");
    private static readonly JsonEncodedText s_traceSampledPropertyName = JsonEncodedText.Encode("logging.googleapis.com/trace_sampled");

    private static readonly JsonEncodedText s_debugSeverity = JsonEncodedText.Encode("DEBUG");
    private static readonly JsonEncodedText s_infoSeverity = JsonEncodedText.Encode("INFO");
    private static readonly JsonEncodedText s_warningSeverity = JsonEncodedText.Encode("WARNING");
    private static readonly JsonEncodedText s_errorSeverity = JsonEncodedText.Encode("ERROR");
    private static readonly JsonEncodedText s_criticalSeverity = JsonEncodedText.Encode("CRITICAL");

    private static readonly string s_defaultTraceId = default(ActivityTraceId).ToHexString();

    private readonly IDisposable _optionsReloadToken;
    private GoogleCloudConsoleFormatterOptions _options;

    /// <summary>
    /// Constructor accepting just an options, to simplify testing.
    /// </summary>
    /// <param name="options">The formatter options. Must not be null.</param>
    internal GoogleCloudConsoleFormatter(GoogleCloudConsoleFormatterOptions options)
        : base(FormatterName)
    {
        _options = options ?? throw new ArgumentNullException(nameof(options));
        _optionsReloadToken = null;
    }

    /// <summary>
    /// Constructs a new formatter which uses the specified monitor to retrieve
    /// options and watch for options changes.
    /// </summary>
    /// <param name="optionsMonitor">The monitor to observe for changes in options. Must not be null.</param>
    public GoogleCloudConsoleFormatter(IOptionsMonitor<GoogleCloudConsoleFormatterOptions> optionsMonitor)
        : this(optionsMonitor.CurrentValue)
    {
        _optionsReloadToken = optionsMonitor.OnChange(options => _options = options);
    }

    /// <inheritdoc />
    public override void Write<TState>(in LogEntry<TState> logEntry, IExternalScopeProvider scopeProvider, TextWriter textWriter)
    {
        string message = logEntry.Formatter(logEntry.State, logEntry.Exception) ?? "";
        using var output = new MemoryStream();
        {
            using var writer = new Utf8JsonWriter(output);
            {
                writer.WriteStartObject();
                writer.WriteString(s_messagePropertyName, message);
                writer.WriteString(s_categoryPropertyName, logEntry.Category);
                writer.WriteString(s_severityPropertyName, GetSeverity(logEntry.LogLevel));
                if (logEntry.Exception is object)
                {
                    writer.WriteString(s_exceptionPropertyName, ToInvariantString(logEntry.Exception));
                }

                MaybeWriteFormatParameters(writer, logEntry.State);
                MaybeWriteScopeInformation(writer, scopeProvider);
                MaybeWriteTraceInformation(writer);
                MaybeWriteLogAugmentation(writer, scopeProvider, logEntry);
                writer.WriteEndObject();
                writer.Flush();
            }
            // TODO: It would be lovely to have a more efficient way of writing the JSON to the console
            // than writing bytes and converting those bytes back into a string - but for the moment,
            // this is what we've got.
            textWriter.WriteLine(Encoding.UTF8.GetString(output.GetBuffer(), 0, (int) output.Position));
        }
    }

    private void MaybeWriteFormatParameters<TState>(Utf8JsonWriter writer, TState state)
    {
        // If we have format params and its more than just the original message add them.
        if (state is IEnumerable<KeyValuePair<string, object>> formatParams &&
            formatParams.Any(pair => pair.Key != "{OriginalFormat}"))
        {
            writer.WritePropertyName(s_formatParametersPropertyName);
            WriteKeyValuePairs(writer, formatParams);
        }
    }

    private void MaybeWriteScopeInformation(Utf8JsonWriter writer, IExternalScopeProvider scopeProvider)
    {
        if (!_options.IncludeScopes || scopeProvider is null)
        {
            return;
        }

        // Write the scopes as an array property, but only if there are any.
        scopeProvider.ForEachScope(WriteScope, writer);
        // If there are no scopes, the write state will still be "object". If
        // we've written at least one scope, the write state will be "array".
        if (writer.CurrentDepth != NoScopesDepth)
        {
            writer.WriteEndArray();
        }

        static void WriteScope(object value, Utf8JsonWriter writer)
        {
            // Detect "first scope" and start the scopes array property.
            if (writer.CurrentDepth == NoScopesDepth)
            {
                writer.WritePropertyName(s_scopesPropertyName);
                writer.WriteStartArray();
            }

            if (value is IEnumerable<KeyValuePair<string, object>> kvps)
            {
                WriteKeyValuePairs(writer, kvps);
            }
            else
            {
                // TODO: Consider special casing integers etc.
                writer.WriteStringValue(ToInvariantString(value));
            }
        }
    }

    private static void WriteKeyValuePairs(Utf8JsonWriter writer, IEnumerable<KeyValuePair<string, object>> pairs)
    {
        writer.WriteStartObject();
        foreach (var pair in pairs)
        {
            string key = pair.Key;
            if (string.IsNullOrEmpty(key))
            {
                continue;
            }
            if (char.IsDigit(key[0]))
            {
                key = "_" + key;
            }
            writer.WriteString(key, ToInvariantString(pair.Value));
        }
        writer.WriteEndObject();
    }

    private void MaybeWriteTraceInformation(Utf8JsonWriter writer)
    {
        if (string.IsNullOrWhiteSpace(_options.TraceGoogleCloudProjectId) || Activity.Current is not Activity activity)
        {
            return;
        }

        var traceId = activity.TraceId.ToHexString();

        // `Equals` implementation in `ActivityTraceId` has a bug. Please see https://github.com/dotnet/runtime/issues/85198 for more details.
        // String comparision is unfortunate but currently the only available workaround.
        if (traceId == s_defaultTraceId)
        {
            return;
        }

        var trace = $"projects/{_options.TraceGoogleCloudProjectId}/traces/{traceId}";
        writer.WriteString(s_tracePropertyName, trace);
        writer.WriteString(s_spanIdPropertyName, activity.SpanId.ToString());
        writer.WriteBoolean(s_traceSampledPropertyName, activity.Recorded);
    }

    private void MaybeWriteLogAugmentation<TState>(Utf8JsonWriter writer, IExternalScopeProvider scopeProvider, LogEntry<TState> logEntry)
    {
        if (_options.LogAugmenter is null)
        {
            return;
        }

        var CurrentDepth = writer.CurrentDepth;
        _options.LogAugmenter.AugmentFormattedLogEntry(logEntry, scopeProvider, writer);
        if (writer.CurrentDepth != CurrentDepth)
        {
            throw new InvalidOperationException("The log augmenter must not change the depth of the JSON writer.");
        }
    }

    private static JsonEncodedText GetSeverity(LogLevel logLevel) =>
        logLevel switch
        {
            LogLevel.Trace or LogLevel.Debug => s_debugSeverity,
            LogLevel.Information => s_infoSeverity,
            LogLevel.Warning => s_warningSeverity,
            LogLevel.Error => s_errorSeverity,
            LogLevel.Critical => s_criticalSeverity,
            _ => throw new ArgumentOutOfRangeException(nameof(logLevel))
        };

    private static string ToInvariantString(object obj) => Convert.ToString(obj, CultureInfo.InvariantCulture);

    void IDisposable.Dispose() => _optionsReloadToken?.Dispose();
}
