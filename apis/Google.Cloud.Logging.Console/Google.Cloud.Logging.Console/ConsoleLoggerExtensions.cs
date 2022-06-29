// Copyright 2022 Google LLC
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
using System;

namespace Google.Cloud.Logging.Console;

/// <summary>
/// Extension methods to make it easier to configure <see cref="GoogleCloudConsoleFormatter"/>.
/// </summary>
public static class ConsoleLoggerExtensions
{
    /// <summary>
    /// Adds <see cref="GoogleCloudConsoleFormatter"/> to the given logging builder, with an
    /// action to configure options.
    /// </summary>
    /// <param name="builder">The builder to configure.</param>
    /// <param name="configure">A delegate to configure options for the formatter.</param>
    /// <returns>The original logging builder, for method chaining.</returns>
    public static ILoggingBuilder AddGoogleCloudConsole(
        this ILoggingBuilder builder,
        Action<GoogleCloudConsoleFormatterOptions> configure) =>
        builder.AddConsole(options => options.FormatterName = GoogleCloudConsoleFormatter.FormatterName)
            .AddConsoleFormatter<GoogleCloudConsoleFormatter, GoogleCloudConsoleFormatterOptions>(configure);

    /// <summary>
    /// Adds <see cref="GoogleCloudConsoleFormatter"/> to the given logging builder.
    /// </summary>
    /// <param name="builder">The builder to configure.</param>
    /// <returns>The original logging builder, for method chaining.</returns>
    public static ILoggingBuilder AddGoogleCloudConsole(
        this ILoggingBuilder builder) =>
        builder.AddConsole(options => options.FormatterName = GoogleCloudConsoleFormatter.FormatterName)
            .AddConsoleFormatter<GoogleCloudConsoleFormatter, GoogleCloudConsoleFormatterOptions>();
}