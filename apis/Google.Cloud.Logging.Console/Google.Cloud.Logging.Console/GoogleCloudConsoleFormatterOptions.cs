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

using Microsoft.Extensions.Logging.Console;

namespace Google.Cloud.Logging.Console;

/// <summary>
/// Options for <see cref="GoogleCloudConsoleFormatter"/>.
/// </summary>
/// <remarks>
/// This class does not currently introduce any new formatter options,
/// but exists to allow further expansion without disruptive API changes.
/// </remarks>
public class GoogleCloudConsoleFormatterOptions : ConsoleFormatterOptions
{
    // Possible options:
    // - JSON property names (category, message etc)
    // - Severity names? (Seems unlikely)
    // - JsonTextWriterOptions (for debugging)

    // That said, for actual Google Cloud Logging, very few things are really flexible -
    // the property names for state and scopes are the only things that come to mind.
}
